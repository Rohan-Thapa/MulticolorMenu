namespace MulticolorMenu.Forms
{
    partial class FormProducts
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
            WelcomeTxt.Location = new Point(333, 47);
            WelcomeTxt.Name = "WelcomeTxt";
            WelcomeTxt.Size = new Size(463, 30);
            WelcomeTxt.TabIndex = 0;
            WelcomeTxt.Text = "Welcome to the Product Section";
            // 
            // welcomebtn
            // 
            welcomebtn.Location = new Point(450, 256);
            welcomebtn.Name = "welcomebtn";
            welcomebtn.Size = new Size(197, 90);
            welcomebtn.TabIndex = 1;
            welcomebtn.Text = "Welcome";
            welcomebtn.UseVisualStyleBackColor = true;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 599);
            Controls.Add(welcomebtn);
            Controls.Add(WelcomeTxt);
            Name = "FormProducts";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeTxt;
        private Button welcomebtn;
    }
}