using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Resolution
{

    [Flags()]
    public enum DisplayDeviceStateFlags : int
    {
        AttachedToDesktop = 0x1,
        MultiDriver = 0x2,
        PrimaryDevice = 0x4,
        MirroringDriver = 0x8,
        VGACompatible = 0x10,
        Removable = 0x20,
        ModesPruned = 0x8000000,
        Remote = 0x4000000,
        Disconnect = 0x2000000
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICE
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        [MarshalAs(UnmanagedType.U4)]
        public DisplayDeviceStateFlags StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [Flags()]
    public enum ChangeDisplaySettingsFlags : uint
    {
        CDS_NONE = 0,
        CDS_UPDATEREGISTRY = 0x00000001,
        CDS_TEST = 0x00000002,
        CDS_FULLSCREEN = 0x00000004,
        CDS_GLOBAL = 0x00000008,
        CDS_SET_PRIMARY = 0x00000010,
        CDS_VIDEOPARAMETERS = 0x00000020,
        CDS_ENABLE_UNSAFE_MODES = 0x00000100,
        CDS_DISABLE_UNSAFE_MODES = 0x00000200,
        CDS_RESET = 0x40000000,
        CDS_RESET_EX = 0x20000000,
        CDS_NORESET = 0x10000000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;
        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;

        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;

        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmPosition;

        public int dmDisplayFlags;
        public int dmDisplayFrequency;

        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;

        public int dmPanningWidth;
        public int dmPanningHeight;
    };

    [Flags()]
    public enum DISP_CHANGE : int
    {
        SUCCESSFUL = 0,
        RESTART = 1,
        FAILED = -1,
        BADMODE = -2,
        NOTUPDATED = -3,
        BADFLAGS = -4,
        BADPARAM = -5,
        BADDUALVIEW = -6
    }

    public class User_32
    {
        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettingsEx(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode, uint dwFlags);
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, ChangeDisplaySettingsFlags dwflags, IntPtr lParam);

        public const int ENUM_CURRENT_SETTINGS = -1;
    }



    public class ScreenResolution
    {
        public static string? processName = "cs2"; // Имя процесса CS2 без ".exe"
        static bool isResolutionChanged = false;
        static int originalWidth = 0; 
        static int originalHeight = 0;
        static int widthToChange = 0;
        static int heightToChange = 0;
        static bool isOriginalResolutionSaved = false;

        static public string ChangeResolution(int width, int height, int deviceIDIn = 0)
        {        
            uint deviceID = 0;
            if (deviceIDIn < 0)
            {
                deviceID = 0;
            }
            else
            {
                deviceID = (uint)deviceIDIn;
            }

            DISPLAY_DEVICE d = new DISPLAY_DEVICE();
            d.cb = Marshal.SizeOf(d);

            DEVMODE dm = GetDevMode();

            User_32.EnumDisplayDevices(null, deviceID, ref d, 1);

            if (0 != User_32.EnumDisplaySettingsEx(d.DeviceName, User_32.ENUM_CURRENT_SETTINGS, ref dm, 0))
            {
                if (!isOriginalResolutionSaved)
                {
                    originalWidth = dm.dmPelsWidth;
                    originalHeight = dm.dmPelsHeight;
                    isOriginalResolutionSaved = true;
                }

                dm.dmPelsWidth = width;
                dm.dmPelsHeight = height;

                int iRet = User_32.ChangeDisplaySettingsEx(d.DeviceName, ref dm, IntPtr.Zero, ChangeDisplaySettingsFlags.CDS_TEST, IntPtr.Zero);

                if (iRet == (int)DISP_CHANGE.FAILED)
                {
                    return "Не удалось Обработать Ваш Запрос.";
                }
                else
                {
                    iRet = User_32.ChangeDisplaySettingsEx(d.DeviceName, ref dm, IntPtr.Zero, ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY, IntPtr.Zero);

                    switch (iRet)
                    {
                        case (int)DISP_CHANGE.SUCCESSFUL:
                            {
                                return "Успешно";
                            }
                        case (int)DISP_CHANGE.RESTART:
                            {
                                return "Для внесения изменений необходимо перезагрузить пк.\n Если после перезагрузки возникнут какие-либо проблемы, попробуйте изменить разрешение в безопасном режиме.";
                            }
                        default:
                            {
                                return "Не удалось сменить разрешение.";
                            }
                    }

                }

            }
            else
            {
                return "Не удалось сменить разрешение.";
            }
        }

        private static DEVMODE GetDevMode()
        {
            DEVMODE dm = new DEVMODE();
            dm.dmDeviceName = new String(new char[32]);
            dm.dmFormName = new String(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);
            return dm;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Имя процесса (без .exe): ");
            processName = Console.ReadLine();
            Console.WriteLine($"Ширина (x): ");
            widthToChange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Высота (y): ");
            heightToChange = Convert.ToInt16(Console.ReadLine());
            Task.Run(() => MonitorProcess()); 
            Console.Clear();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        static void MonitorProcess()
        {
            while (true)
            {
                bool isExeRunning = Process.GetProcessesByName(processName).Length > 0;              
                if (isExeRunning && !isResolutionChanged)
                {
                    Console.WriteLine("Файл запущен! Меняем разрешение...");
                    ChangeResolution(widthToChange, heightToChange);
                    isResolutionChanged = true;
                }
                else if (!isExeRunning && isResolutionChanged)
                {
                    Console.WriteLine("Файл закрыт! Возвращаем исходное разрешение...");
                    ChangeResolution(originalWidth, originalHeight);
                    isResolutionChanged = false;
                }

                Thread.Sleep(3000);
            }
        }
    }
}


