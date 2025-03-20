namespace MulticolorMenu.Forms
{
    partial class FormNotifications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeTxt = new Label();
            welcomebtn = new Button();
            SuspendLayout();
            // 
            // WelcomeTxt
            // 
            WelcomeTxt.AutoSize = true;
            WelcomeTxt.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeTxt.Location = new Point(307, 37);
            WelcomeTxt.Name = "WelcomeTxt";
            WelcomeTxt.Size = new Size(493, 30);
            WelcomeTxt.TabIndex = 0;
            WelcomeTxt.Text = "Welcome to Notifications Section";
            // 
            // welcomebtn
            // 
            welcomebtn.Location = new Point(409, 242);
            welcomebtn.Name = "welcomebtn";
            welcomebtn.Size = new Size(220, 113);
            welcomebtn.TabIndex = 1;
            welcomebtn.Text = "Welcome";
            welcomebtn.UseVisualStyleBackColor = true;
            // 
            // FormNotifications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 599);
            Controls.Add(welcomebtn);
            Controls.Add(WelcomeTxt);
            Name = "FormNotifications";
            Text = "Notifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeTxt;
        private Button welcomebtn;
    }
}