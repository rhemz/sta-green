using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sta_Green
{
    class BigCheckbox : CheckBox
    {
        public BigCheckbox()
        {
            TextAlign = ContentAlignment.MiddleRight;
        }

        public override bool  AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = false; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int size = ClientSize.Height - 2;
            Rectangle rc = new Rectangle(new Point(0, 1), new Size(size, size));
            ControlPaint.DrawCheckBox(e.Graphics, rc, Checked ? ButtonState.Checked : ButtonState.Normal);
        }

    }
}
