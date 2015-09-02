using System;
using System.Drawing;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Sta_Green
{
    public partial class View : Form
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        private readonly Controller _controller;

        private const int defaultInterval = 10;
        private const int defaultThreshhold = 240;
        private Point defaultPoint = new Point(20, 20);

        public int Interval
        {
            get 
            {
                try
                {
                    return Int32.Parse(intervalField.Text) * 1000;
                }
                catch
                {
                    Interval = defaultInterval;
                }

                return defaultInterval * 1000;
            }

            set { intervalField.Text = value.ToString(); }
        }

        public int Threshhold
        {
            get
            {
                try
                {
                    return Int32.Parse(threshholdField.Text); 
                }
                catch
                {
                    Threshhold = defaultThreshhold;
                }
                return defaultThreshhold;
            }

            set { threshholdField.Text = value.ToString(); }
        }

        public bool SimulateKeyboard
        {
            get { return sendKeystrokesCheckbox.Checked; }
        }

        public bool SimulateMouse
        {
            get { return sendMouseCheckbox.Checked; }
        }

        public Point MouseCoords
        {
            get
            {
                try
                {
                    return new Point(Int32.Parse(mouseXField.Text), Int32.Parse(mouseYField.Text));
                }
                catch
                {
                    mouseXField.Text = defaultPoint.X.ToString();
                    mouseYField.Text = defaultPoint.Y.ToString();
                }
                return defaultPoint;
            }
        }

        public bool BlockWindowsShutdown
        {
            get { return blockShutdownCheckbox.Checked; }
        }



        public View()
        {
            InitializeComponent();

            _controller = new Controller(this);

            Application.Idle += OnLoad;
        }

        private void OnLoad(Object s, EventArgs e)
        {
            Application.Idle -= OnLoad;
            Resize += View_Resize;
            trayIcon.DoubleClick += TrayIconDoubleClick;
            sendMouseCheckbox.CheckedChanged += updateOptionsChecked;
            sendKeystrokesCheckbox.CheckedChanged += updateOptionsChecked;
            enabledCheckbox.CheckedChanged += new EventHandler(enabledCheckbox_CheckedChanged);
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == SessionIntercept.WM_QUERYENDSESSION || m.Msg == SessionIntercept.WM_ENDSESSION)
                && BlockWindowsShutdown)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void updateOptionsChecked(object sender, EventArgs e)
        {
            enabledCheckbox.Enabled = !(!sendKeystrokesCheckbox.Checked && !sendMouseCheckbox.Checked);
            if (sender == sendMouseCheckbox)
            {
                mouseXField.Enabled = sendMouseCheckbox.Checked;
                mouseYField.Enabled = sendMouseCheckbox.Checked;
            }
        }

        private void View_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        public void DisplayStatus(string msg, bool success)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                statusLabel.ForeColor = success ? Color.Green : Color.Red;
                statusLabel.Text = String.Format("{0}", msg);
            });
        }

        void TrayIconDoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
            SetForegroundWindow(Handle);
        }

        private void enabledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _controller.Enabled = (sender as CheckBox).Checked;
            optionsGroup.Enabled = !(sender as CheckBox).Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}