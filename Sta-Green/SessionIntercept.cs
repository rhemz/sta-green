namespace Sta_Green
{
    class SessionIntercept
    {
        public const int WM_QUERYENDSESSION = 0x0011;
        public const int WM_ENDSESSION = 0x0016;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MONITOR_POWER = 0xF170;
        public const int SC_SCREENSAVE = 0xF140;
    }
}
