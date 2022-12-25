namespace XBoxControllerApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RightProgressBar = new System.Windows.Forms.ProgressBar();
            this.LeftProgressBar = new System.Windows.Forms.ProgressBar();
            this.ChangeButton = new Krypton.Toolkit.KryptonButton();
            this.BreakProgressBar = new XBoxControllerApp.VerticalProgressBar();
            this.ThrottleProgressBar = new XBoxControllerApp.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RightProgressBar
            // 
            this.RightProgressBar.Location = new System.Drawing.Point(132, 12);
            this.RightProgressBar.Maximum = 32767;
            this.RightProgressBar.Name = "RightProgressBar";
            this.RightProgressBar.Size = new System.Drawing.Size(120, 20);
            this.RightProgressBar.TabIndex = 1;
            // 
            // LeftProgressBar
            // 
            this.LeftProgressBar.Location = new System.Drawing.Point(12, 12);
            this.LeftProgressBar.Maximum = 32768;
            this.LeftProgressBar.Name = "LeftProgressBar";
            this.LeftProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LeftProgressBar.RightToLeftLayout = true;
            this.LeftProgressBar.Size = new System.Drawing.Size(120, 20);
            this.LeftProgressBar.TabIndex = 2;
            // 
            // ChangeButton
            // 
            this.ChangeButton.CornerRoundingRadius = 10F;
            this.ChangeButton.Location = new System.Drawing.Point(98, 137);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ChangeButton.Size = new System.Drawing.Size(68, 25);
            this.ChangeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangeButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangeButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangeButton.StateCommon.Border.Rounding = 10F;
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Values.Text = "";
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BreakProgressBar
            // 
            this.BreakProgressBar.BackColor = System.Drawing.Color.Red;
            this.BreakProgressBar.ForeColor = System.Drawing.Color.Red;
            this.BreakProgressBar.Location = new System.Drawing.Point(12, 38);
            this.BreakProgressBar.Maximum = 255;
            this.BreakProgressBar.Name = "BreakProgressBar";
            this.BreakProgressBar.Size = new System.Drawing.Size(80, 124);
            this.BreakProgressBar.TabIndex = 4;
            this.BreakProgressBar.UseKrypton = true;
            // 
            // ThrottleProgressBar
            // 
            this.ThrottleProgressBar.BackColor = System.Drawing.Color.Lime;
            this.ThrottleProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.ThrottleProgressBar.Location = new System.Drawing.Point(172, 38);
            this.ThrottleProgressBar.Maximum = 255;
            this.ThrottleProgressBar.Name = "ThrottleProgressBar";
            this.ThrottleProgressBar.Size = new System.Drawing.Size(80, 124);
            this.ThrottleProgressBar.TabIndex = 3;
            this.ThrottleProgressBar.UseKrypton = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(266, 174);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.BreakProgressBar);
            this.Controls.Add(this.ThrottleProgressBar);
            this.Controls.Add(this.LeftProgressBar);
            this.Controls.Add(this.RightProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Геймпад";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar RightProgressBar;
        private System.Windows.Forms.ProgressBar LeftProgressBar;
        private VerticalProgressBar BreakProgressBar;
        private VerticalProgressBar ThrottleProgressBar;
        private Krypton.Toolkit.KryptonButton ChangeButton;
    }
}

