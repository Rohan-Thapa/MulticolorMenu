namespace MulticolorMenu.Forms
{
    partial class FormCustomer
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
            WelcomeTxt.Location = new Point(377, 45);
            WelcomeTxt.Name = "WelcomeTxt";
            WelcomeTxt.Size = new Size(418, 30);
            WelcomeTxt.TabIndex = 0;
            WelcomeTxt.Text = "Welcome to Customer Section";
            // 
            // welcomebtn
            // 
            welcomebtn.Location = new Point(496, 247);
            welcomebtn.Name = "welcomebtn";
            welcomebtn.Size = new Size(196, 82);
            welcomebtn.TabIndex = 1;
            welcomebtn.Text = "Welcome";
            welcomebtn.UseVisualStyleBackColor = true;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 599);
            Controls.Add(welcomebtn);
            Controls.Add(WelcomeTxt);
            Name = "FormCustomer";
            Text = "Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeTxt;
        private Button welcomebtn;
    }
}