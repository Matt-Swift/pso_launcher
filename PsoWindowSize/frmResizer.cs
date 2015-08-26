using EasyHook;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Reflection;
//using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Yggdrasill;

namespace PsoWindowSize
{

    public partial class frmResizer : Form
    {
        struct Ratio
        {
            public int W;
            public int H;
        }

        Ratio ratio = new Ratio();
        bool updatingValue = false;
        bool hasExePath = false;
        string exePath = string.Empty;

        int ScreenWidth = 0;
        int ScreenHeight = 0;

        private Ratio GetRatio(int resW, int resH)
        {
            ratio = new Ratio();

            int gcd = GetGCD(resW, resH);

            ratio.W = resW / gcd;
            ratio.H = resH / gcd;

            return ratio;
        }

        public frmResizer()
        {
            InitializeComponent();
        }

        public int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;

                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }

        private string GetProcessFileName(Process p)
        {
            StringBuilder strbld = new StringBuilder(1024);

            // Setting up the variable for the second argument for EnumProcessModules
            IntPtr[] hMods = new IntPtr[1024];

            GCHandle gch = GCHandle.Alloc(hMods, GCHandleType.Pinned); // Don't forget to free this later
            IntPtr pModules = gch.AddrOfPinnedObject();

            // Setting up the rest of the parameters for EnumProcessModules
            uint uiSize = (uint)(Marshal.SizeOf(typeof(IntPtr)) * (hMods.Length));
            uint cbNeeded = 0;
            if (WinAPI.EnumProcessModules(p.Handle, pModules, uiSize, out cbNeeded) == 1)
            {
                Int32 uiTotalNumberofModules = (Int32)(cbNeeded / (Marshal.SizeOf(typeof(IntPtr))));

                WinAPI.GetModuleFileNameEx(p.Handle, hMods[0], strbld, (uint)(strbld.Capacity));
            }

            // Must free the GCHandle object
            gch.Free();

            return strbld.ToString();
        }

        public static Bitmap PrintWindow(IntPtr hwnd)
        {
            RECT rc = new RECT();
            WinAPI.GetWindowRect(hwnd, ref rc);

            int rcWidth = rc.Right - rc.Left;
            int rcHeight = rc.Bottom - rc.Top;

            Bitmap bmp = new Bitmap(rcWidth, rcHeight, PixelFormat.Format24bppRgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            WinAPI.PrintWindow(hwnd, hdcBitmap, 0);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }

        public static Bitmap PrintWindowBlt(IntPtr hwnd)
        {
            RECT rc = new RECT();
            WinAPI.GetClientRect(hwnd, ref rc);

            int rcWidth = rc.Right - rc.Left;
            int rcHeight = rc.Bottom - rc.Top;

            if (rcHeight.Equals(0) || rcWidth.Equals(0))
            {
                return null;
            }

            Bitmap bmp = new Bitmap(rcWidth, rcHeight, PixelFormat.Format24bppRgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            IntPtr windowDC = WinAPI.GetDC(hwnd);

            WinAPI.BitBlt(hdcBitmap, 0, 0, bmp.Width, bmp.Height, windowDC, 0, 0, TernaryRasterOperations.SRCCOPY);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            WinAPI.ReleaseDC(hwnd, windowDC);

            return bmp;
        }

        //public void ChangeResolution(int iWidth, int iHeight)
        //{
        //    Screen screen = Screen.PrimaryScreen;

        //    DEVMODE dm = new DEVMODE();
        //    dm.dmDeviceName = new String(new char[32]);
        //    dm.dmFormName = new String(new char[32]);
        //    dm.dmSize = (short)Marshal.SizeOf(dm);

        //    if (0 != WinAPI.EnumDisplaySettings(null, WinAPI.ENUM_CURRENT_SETTINGS, ref dm))
        //    {

        //        dm.dmPelsWidth = iWidth;
        //        dm.dmPelsHeight = iHeight;

        //        int iRet = WinAPI.ChangeDisplaySettings(ref dm, WinAPI.CDS_TEST);

        //        if (iRet == WinAPI.DISP_CHANGE_FAILED)
        //        {
        //            MessageBox.Show("Unable to process your request");
        //            MessageBox.Show("Description: Unable To Process Your Request. Sorry For This Inconvenience.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            iRet = WinAPI.ChangeDisplaySettings(ref dm, WinAPI.CDS_UPDATEREGISTRY);

        //            switch (iRet)
        //            {
        //                case WinAPI.DISP_CHANGE_SUCCESSFUL:
        //                    {
        //                        break;

        //                        //successfull change
        //                    }
        //                case WinAPI.DISP_CHANGE_RESTART:
        //                    {

        //                        MessageBox.Show("Description: You Need To Reboot For The Change To Happen.\n If You Feel Any Problem After Rebooting Your Machine\nThen Try To Change Resolution In Safe Mode.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        break;
        //                        //windows 9x series you have to restart
        //                    }
        //                default:
        //                    {

        //                        MessageBox.Show("Description: Failed To Change The Resolution.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        break;
        //                        //failed to change
        //                    }
        //            }
        //        }

        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("PSO");
            if (processes.Length < 1)
            {
                MessageBox.Show("Error: PSO is not running.\r\nPlease open PSO before trying to resize it.", "PSO not running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RECT windowRect = new RECT();
            RECT clientRect = new RECT();
            int windowWidth = 0;
            int windowHeight = 0;
            int clientWidth = 0;
            int clientHeight = 0;

            WinAPI.GetWindowRect(processes[0].MainWindowHandle, ref windowRect);
            windowHeight = windowRect.Bottom - windowRect.Top;
            windowWidth = windowRect.Right - windowRect.Left;

            WinAPI.GetClientRect(processes[0].MainWindowHandle, ref clientRect);
            clientHeight = clientRect.Bottom - clientRect.Top;
            clientWidth = clientRect.Right - clientRect.Left;

            if (rdoPerfect.Checked)
            {
                //ChangeResolution(ScreenWidth, ScreenHeight);



                //WinAPI.SetWindowLong(processes[0].MainWindowHandle, nIndex.GWL_STYLE, dwNewLong.WS_OVERLAPPEDWINDOW);

                //WinAPI.SetWindowPos(processes[0].MainWindowHandle, HWND.Top, 0, 0, ((640 * (cboRatio.SelectedIndex + 1)) + (windowWidth - clientWidth)),
                //                                                                   ((480 * (cboRatio.SelectedIndex + 1)) + (windowHeight - clientHeight)), 
                //                                                                   SetWindowPosFlags.SHOWWINDOW);

                WinAPI.MoveWindow(processes[0].MainWindowHandle, windowRect.Left, windowRect.Top, ((640 * (cboRatio.SelectedIndex + 1)) + (windowWidth - clientWidth)),
                                                                                                  ((480 * (cboRatio.SelectedIndex + 1)) + (windowHeight - clientHeight)), true);
            }
            else
            {
                WinAPI.MoveWindow(processes[0].MainWindowHandle, windowRect.Left, windowRect.Top, ((int)txtW.Value + (windowWidth - clientWidth)),
                                                                                                  ((int)txtH.Value + (windowHeight - clientHeight)), true);
            }
        }

        private void UpdateRatio()
        {
            ratio = GetRatio((int)txtW.Value, (int)txtH.Value);
            lblRatio.Text = string.Format("Ratio: {0}:{1}", ratio.W, ratio.H);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            chkAutoResize.Checked = true;
            chkWindowed.Checked = true;
            cmdResize.Enabled = false;
            cmdScreenshot.Enabled = false;
            cboRatio.SelectedIndex = 0;
            timer.Enabled = true;
            UpdateRatio();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("PSO");
            try
            {
                if (processes.Length > 0)
                {
                    if (!hasExePath)
                    {
                        exePath = GetProcessFileName(processes[0]);
                        hasExePath = true;
                    }

                    RECT clientRect = new RECT();
                    WinAPI.GetClientRect(processes[0].MainWindowHandle, ref clientRect);

                    lblPsoStatus.Text = string.Format("PSO is running. Dimensions: {0} x {1}.", clientRect.Right, clientRect.Bottom);

                    if (rdoPerfect.Checked)
                    {
                        txtW.Value = clientRect.Right;
                        txtH.Value = clientRect.Bottom;
                        UpdateRatio();
                    }
                    cmdResize.Enabled = true;
                    cmdScreenshot.Enabled = true;
                    cmdStartOffline.Enabled = false;
                    cmdStartOnline.Enabled = false;
                    cmdOptions.Enabled = false;

                    if (chkAutoResize.Checked)
                    {
                        int desiredWidth = 0;
                        int desiredHeight = 0;
                        if (rdoPerfect.Checked)
                        {
                            int multiplier = cboRatio.SelectedIndex + 1;
                            desiredWidth = 640 * multiplier;
                            desiredHeight = 480 * multiplier;
                        }
                        else
                        {
                            desiredWidth = (int)txtW.Value;
                            desiredHeight = (int)txtH.Value;
                        }

                        if ((clientRect.Right != desiredWidth) || (clientRect.Bottom != desiredHeight))
                        {
                            button1_Click(sender, e);
                        }
                    }
                }
                else
                {
                    lblPsoStatus.Text = "PSO is NOT running.";
                    cmdResize.Enabled = false;
                    cmdScreenshot.Enabled = false;
                    cmdStartOffline.Enabled = true;
                    cmdStartOnline.Enabled = true;
                    cmdOptions.Enabled = true;
                    hasExePath = false;
                }
            }
            catch
            {
                return;
            }
        }

        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustom.Checked)
            {
                fraCustom.Enabled = true;
                cboRatio.Enabled = false;
            }
        }

        private void rdoPerfect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPerfect.Checked)
            {
                cboRatio.Enabled = true;
                fraCustom.Enabled = false;
            }
        }

        private void txtW_ValueChanged(object sender, EventArgs e)
        {
            if (!updatingValue)
            {
                updatingValue = true;
                if (chkLockRatio.Checked)
                {
                    txtH.Value = (int)(txtW.Value * ratio.H / ratio.W);
                }
                else
                {
                    UpdateRatio();
                }
                updatingValue = false;
            }
        }

        private void txtH_ValueChanged(object sender, EventArgs e)
        {
            if (!updatingValue)
            {
                updatingValue = true;
                if (chkLockRatio.Checked)
                {
                    txtW.Value = (int)(txtH.Value * ratio.W / ratio.H);
                }
                else
                {
                    UpdateRatio();
                }
                updatingValue = false;
            }
        }

        private void cmdScreenshot_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("PSO");

            string psoBasePath = exePath.Substring(0, exePath.LastIndexOf('\\'));

            FileInfo[] files = new DirectoryInfo(psoBasePath + "\\Backup").GetFiles("pso_image_???.bmp");

            int highest = -1;
            foreach (FileInfo file in files)
            {
                int number = int.Parse(file.Name.Substring(10, 3));
                highest = (number > highest) ? number : highest;
            }
            Bitmap bmp = PrintWindowBlt(processes[0].MainWindowHandle);
            bmp.Save(string.Format("{0}\\Backup\\pso_image_{1}.bmp", psoBasePath, (++highest).ToString("000")), ImageFormat.Bmp);

            PrintWindow(processes[0].MainWindowHandle); //This is just to flash the screen. 
            Assembly assembly = Assembly.GetExecutingAssembly();

            SoundPlayer player = new SoundPlayer(assembly.GetManifestResourceStream("PsoWindowSize.05_26.wav"));
            player.Play();
        }

        private void cmdStartOnline_Click(object sender, EventArgs e)
        {
            timer.Stop();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SonicTeam\PSOV2", true);
            key.SetValue("CTRLFLAG1", (uint)0x0000001e, RegistryValueKind.DWord);
            key.Close();
#if !DEBUG
            Directory.SetCurrentDirectory(Application.StartupPath);
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(Application.StartupPath + "\\pso.exe", "-online");
#else
            Directory.SetCurrentDirectory(@"C:\Jogos\Phantasy Star Online");
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(@"C:\Jogos\Phantasy Star Online\pso.exe", "-online");
#endif
            psoProcessInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                Process.Start(psoProcessInfo);
            }
            catch
            {
                MessageBox.Show("Error: To launch the game, the launcher must be in the\r\nsame folder as \"pso.exe\".", "PSO not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            timer.Start();
        }

        private void cmdStartOffline_Click(object sender, EventArgs e)
        {
            timer.Stop();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SonicTeam\PSOV2", true);
            key.SetValue("CTRLFLAG1", (uint)0x0000000e, RegistryValueKind.DWord);
            key.Close();

#if !DEBUG
            Directory.SetCurrentDirectory(Application.StartupPath);
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(Application.StartupPath + "\\pso.exe", "-offline");
#else
            Directory.SetCurrentDirectory(@"C:\Jogos\Phantasy Star Online");
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(@"C:\Jogos\Phantasy Star Online\pso.exe", "-offline");
#endif
            psoProcessInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                Process.Start(psoProcessInfo);
            }
            catch
            {
                MessageBox.Show("Error: To launch the game, the launcher must be in the\r\nsame folder as \"pso.exe\".", "PSO not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            timer.Start();
        }

        private void cmdOptions_Click(object sender, EventArgs e)
        {
            timer.Stop();
#if !DEBUG
            Directory.SetCurrentDirectory(Application.StartupPath);
            ProcessStartInfo processInfo = new ProcessStartInfo(Application.StartupPath + "\\option.exe", "-autorun.exe -s");
#else
            Directory.SetCurrentDirectory(@"C:\Jogos\Phantasy Star Online");
            ProcessStartInfo processInfo = new ProcessStartInfo(@"C:\Jogos\Phantasy Star Online\option.exe", "-autorun.exe -s");
#endif
            processInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                Process process = Process.Start(processInfo);
                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Error: To launch the game, the launcher must be in the\r\nsame folder as \"options.exe\".", "Options not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            timer.Start();
        }

        public struct ThdArgs
        {
            public Process psoProc;
            public RegistryKey key;
            public UInt32 value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* Don't try to start the game twice... */
            bool windowed = chkWindowed.Checked;

            uint value = (uint)0x00000010;

            /* Figure out the working directory to set and set the flag in the registry... */
            RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\SonicTeam\PSOV2", true);
            k.SetValue("CTRLFLAG1", value, RegistryValueKind.DWord);
#if !DEBUG
            string dir = Application.StartupPath;
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(Application.StartupPath + "\\pso.exe", "-online");
#else
            string dir = @"C:\Jogos\Phantasy Star Online";
            ProcessStartInfo psoProcessInfo = new ProcessStartInfo(@"C:\Jogos\Phantasy Star Online\pso.exe", "-online");
#endif
            Kernel32.STARTUPINFO si = new Kernel32.STARTUPINFO();
            Kernel32.PROCESS_INFORMATION pi = new Kernel32.PROCESS_INFORMATION();

            Directory.SetCurrentDirectory(dir);

            /* Get the icon from one of the exes that have an icon */
            System.Drawing.Icon icon = System.Drawing.Icon.ExtractAssociatedIcon("online.exe");

            /* Start PSO... */
            bool ran = Kernel32.CreateProcess(null, "pso.exe -online",
                IntPtr.Zero, IntPtr.Zero, true,
                (uint)Kernel32.ProcessCreationFlags.CREATE_SUSPENDED,
                IntPtr.Zero, dir, ref si, out pi);

            if (!ran)
            {
                Console.Out.WriteLine("CANNOT START PSO!");
                //k.SetValue("CTRLFLAG1", value, RegistryValueKind.DWord);
                return;
            }
            
            Process psoProc = Process.GetProcessById((int)pi.dwProcessId);

            string ChannelName = null;
            RemoteHooking.IpcCreateServer<YggdrasillInterface>(ref ChannelName, WellKnownObjectMode.SingleCall);

            try
            {
                RemoteHooking.Inject((int)pi.dwProcessId, Path.Combine(Application.StartupPath, "Mithos.dll"), null, ChannelName,
                chkVista.Checked, windowed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                psoProc.Kill();
                return;
            }

            /* Set up for doing the stuff we need to to the binary... */
            ProcessHaxxor haxxor = new ProcessHaxxor(psoProc);

            Kernel32.ResumeThread(pi.hThread);

            Thread.Sleep(1000);

            /* Pause it while we hax it up. */
            foreach (ProcessThread pT in psoProc.Threads)
            {
                IntPtr pOpenThread = Kernel32.OpenThread(Kernel32.ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    break;
                }

                Kernel32.SuspendThread(pOpenThread);
            }

            haxxor.PatchPSO(chkWhiteNames.Checked,
                            chkWordFilter.Enabled,
                            chkMusicFix.Enabled,
                            chkMapFix.Enabled);

            /* Wake it up. */
            foreach (ProcessThread pT in psoProc.Threads)
            {
                IntPtr pOpenThread = Kernel32.OpenThread(Kernel32.ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    break;
                }

                Kernel32.ResumeThread(pOpenThread);
            }

            if (windowed)
            {
                RECT windowRect = new RECT();
                RECT clientRect = new RECT();

                int windowHeight = 0;
                int windowWidth = 0;
                int clientHeight = 0;
                int clientWidth = 0;

                Thread.Sleep(750);
                IntPtr wnd = User32.FindWindow("PSO for PC", "PSO for PC");

                WinAPI.GetWindowRect(wnd, ref windowRect);
                windowHeight = windowRect.Bottom - windowRect.Top;
                windowWidth = windowRect.Right - windowRect.Left;

                WinAPI.GetClientRect(wnd, ref clientRect);
                clientHeight = clientRect.Bottom - clientRect.Top;
                clientWidth = clientRect.Right - clientRect.Left;

                if (rdoPerfect.Checked)
                {
                    User32.SetWindowPos(wnd, IntPtr.Zero, 0, 0, (int)((640 * (cboRatio.SelectedIndex + 1)) + (windowWidth - clientWidth)),
                                                                (int)((480 * (cboRatio.SelectedIndex + 1)) + (windowHeight - clientHeight)), 2);
                }
                else
                {
                    User32.SetWindowPos(wnd, IntPtr.Zero, 0, 0, (int)((int)txtW.Value + (windowWidth - clientWidth)),
                                                                (int)((int)txtH.Value + (windowHeight - clientHeight)), 2);
                }
                
                User32.SendMessage(wnd, User32.WM_SETICON, User32.ICON_BIG, icon.Handle);
            }

            /* Make a thread to wait until the game exits to clean up. */
            //ThdArgs args = new ThdArgs();
            //args.psoProc = psoProc;
            //args.key = k;
            //args.value = value;
            //Thread thd = new Thread(this.WaitThd);
            //thd.Start(args);

        }
    }
}
