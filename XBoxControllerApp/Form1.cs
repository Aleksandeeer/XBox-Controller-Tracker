using System;
using System.Drawing;
using System.Windows.Forms;
using SharpDX.XInput;

namespace XBoxControllerApp
{
    public partial class Form1 : Krypton.Toolkit.KryptonForm
    {
        private Controller controller;
        int xLeftStick;
        byte throttleTrigger, breakTrigger;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(950, 102);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller(UserIndex.One);

            timer.Start();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            controller.GetState(out State state);
            //Левый стик по оси X - управление
            xLeftStick = state.Gamepad.LeftThumbX;
            //Правый стик - газ
            throttleTrigger = state.Gamepad.RightTrigger;
            //Левый стик - тормоз
            breakTrigger = state.Gamepad.LeftTrigger;

            //Установка значений - газ
            ThrottleProgressBar.Value = throttleTrigger;
            if (throttleTrigger > 0)
                ThrottleProgressBar.Value = throttleTrigger - 1;

            //Установка значений - тормоз
            BreakProgressBar.Value = breakTrigger;
            if (breakTrigger > 0)
                BreakProgressBar.Value = breakTrigger - 1;

            //Установка значений - управление
            if (xLeftStick > 0)
            {
                RightProgressBar.Value = xLeftStick;
                RightProgressBar.Value = xLeftStick - 1;
                LeftProgressBar.Value = 0;
            }
            else
            {

                LeftProgressBar.Value = Math.Abs(xLeftStick);
                LeftProgressBar.Value = Math.Abs(xLeftStick + 1);
                RightProgressBar.Value = 0;
            }
        }
    }

    public class VerticalProgressBar : Krypton.Toolkit.KryptonProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
