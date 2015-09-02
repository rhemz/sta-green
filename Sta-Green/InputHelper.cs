using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Sta_Green
{
    class InputHelper
    {
        [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);


        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(sizeof(int))] //[FieldOffset(8)] for x64
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        public enum Keys : ushort
        {
            SHIFT = 0x10,
            CONTROL = 0x11,
            MENU = 0x12,
            ESCAPE = 0x1B,
            BACK = 0x08,
            TAB = 0x09,
            RETURN = 0x0D,
            PRIOR = 0x21,
            NEXT = 0x22,
            END = 0x23,
            HOME = 0x24,
            LEFT = 0x25,
            UP = 0x26,
            RIGHT = 0x27,
            DOWN = 0x28,
            SELECT = 0x29,
            PRINT = 0x2A,
            EXECUTE = 0x2B,
            SNAPSHOT = 0x2C,
            INSERT = 0x2D,
            DELETE = 0x2E,
            HELP = 0x2F,
            NUMPAD0 = 0x60,
            NUMPAD1 = 0x61,
            NUMPAD2 = 0x62,
            NUMPAD3 = 0x63,
            NUMPAD4 = 0x64,
            NUMPAD5 = 0x65,
            NUMPAD6 = 0x66,
            NUMPAD7 = 0x67,
            NUMPAD8 = 0x68,
            NUMPAD9 = 0x69,
            MULTIPLY = 0x6A,
            ADD = 0x6B,
            SEPARATOR = 0x6C,
            SUBTRACT = 0x6D,
            DECIMAL = 0x6E,
            DIVIDE = 0x6F,
            F1 = 0x70,
            F2 = 0x71,
            F3 = 0x72,
            F4 = 0x73,
            F5 = 0x74,
            F6 = 0x75,
            F7 = 0x76,
            F8 = 0x77,
            F9 = 0x78,
            F10 = 0x79,
            F11 = 0x7A,
            F12 = 0x7B,
            OEM_1 = 0xBA,   // ',:' for US
            OEM_PLUS = 0xBB,   // '+' any country
            OEM_COMMA = 0xBC,   // ',' any country
            OEM_MINUS = 0xBD,   // '-' any country
            OEM_PERIOD = 0xBE,   // '.' any country
            OEM_2 = 0xBF,   // '/?' for US
            OEM_3 = 0xC0,   // '`~' for US
            MEDIA_NEXT_TRACK = 0xB0,
            MEDIA_PREV_TRACK = 0xB1,
            MEDIA_STOP = 0xB2,
            MEDIA_PLAY_PAUSE = 0xB3,
            LWIN = 0x5B,
            RWIN = 0x5C
        }


        public const int INPUT_MOUSE = 0;
        public const int INPUT_KEYBOARD = 1;
        public const int INPUT_HARDWARE = 2;

        public const uint MOUSEEVENTF_MOVE = 0x0001;
        public const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const uint MOUSEEVENTF_LEFTUP = 0x0004;
        public const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        public const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        public const uint MOUSEEVENTF_XDOWN = 0x0080;
        public const uint MOUSEEVENTF_XUP = 0x0100;
        public const uint MOUSEEVENTF_WHEEL = 0x0800;
        public const uint MOUSEEVENTF_VIRTUALDESK = 0x4000;
        public const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
 
        public const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const uint KEYEVENTF_KEYUP = 0x0002;
        public const uint KEYEVENTF_UNICODE = 0x0004;
        public const uint KEYEVENTF_SCANCODE = 0x0008;




        public int GetLastInput()
        {
            int idle = 0;
            LASTINPUTINFO last = new LASTINPUTINFO();
            last.cbSize = (uint)Marshal.SizeOf(last);
            last.dwTime = 0;

            int ticks = Environment.TickCount;
            if (GetLastInputInfo(ref last))
            {
                int lastTick = (int)last.dwTime;
                idle = ticks - lastTick;
            }

            return (idle > 0) ? (idle / 1000) : 0;
        }



        // Mouse shenanigans

        public Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        public void MoveMouse(Point p)
        {
            INPUT[] input = new INPUT[2];
            input[0].type = INPUT_MOUSE;
            input[0].mi = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE);
            input[1].type = INPUT_MOUSE;
            input[1].mi = CreateMouseInput(p.X, p.Y, 0, 0, MOUSEEVENTF_MOVE);

            SendInput((uint)input.Length, input, Marshal.SizeOf(input[0].GetType()));
        }

        public void MoveMouse(Point start, Point destination)
        {
            INPUT[] input = new INPUT[2];
            input[0].type = INPUT_MOUSE;
            input[0].mi = CreateMouseInput(start.X, start.Y, 0, 0, MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE);
            input[1].type = INPUT_MOUSE;
            input[1].mi = CreateMouseInput(destination.X, destination.Y, 0, 0, MOUSEEVENTF_MOVE);

            SendInput((uint)input.Length, input, Marshal.SizeOf(input[0].GetType()));
        }

        private MOUSEINPUT CreateMouseInput(int x, int y, uint data, uint t, uint flag)
        {
            MOUSEINPUT input = new MOUSEINPUT();
            input.dx = x;
            input.dy = y;
            input.mouseData = data;
            input.time = t;
            //input.dwFlags = MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE;
            input.dwFlags = flag;

            return input;
        }



        // Keyboard shenanigans

        public void SendKeystroke(ushort key)
        {
            INPUT[] input = new INPUT[2];
            input[0].type = INPUT_KEYBOARD;
            input[0].ki = CreateKeybdInput((short)key, 0);

            input[0].type = INPUT_KEYBOARD;
            input[0].ki = CreateKeybdInput((short)key, KEYEVENTF_KEYUP);

            SendInput((uint)input.Length, input, Marshal.SizeOf(input[0].GetType()));
        }

        private KEYBDINPUT CreateKeybdInput(short wVK, uint flag)
        {
            KEYBDINPUT k = new KEYBDINPUT();
            k.wVk = (ushort)wVK;
            k.wScan = 0;
            k.time = 0;
            k.dwExtraInfo = IntPtr.Zero;
            k.dwFlags = flag;

            return k;
        }
    }

}
