namespace MulticolorMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnExit = new Button();
            btnSettings = new Button();
            btnNotifications = new Button();
            btnReporting = new Button();
            btnCustomer = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnNotifications);
            panelMenu.Controls.Add(btnReporting);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 660);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.Image = Properties.Resources.exit_logo;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 600);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(12, 0, 0, 0);
            btnExit.Size = new Size(220, 60);
            btnExit.TabIndex = 7;
            btnExit.Text = "    Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 380);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "    Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Dock = DockStyle.Top;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = Color.Gainsboro;
            btnNotifications.Image = Properties.Resources.alarm__1_;
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 320);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Padding = new Padding(12, 0, 0, 0);
            btnNotifications.Size = new Size(220, 60);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "    Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReporting
            // 
            btnReporting.Dock = DockStyle.Top;
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.ForeColor = Color.Gainsboro;
            btnReporting.Image = Properties.Resources.bar_chart;
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 260);
            btnReporting.Name = "btnReporting";
            btnReporting.Padding = new Padding(12, 0, 0, 0);
            btnReporting.Size = new Size(220, 60);
            btnReporting.TabIndex = 4;
            btnReporting.Text = "    Reporting";
            btnReporting.TextAlign = ContentAlignment.MiddleLeft;
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            btnReporting.Click += btnReporting_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = Color.Gainsboro;
            btnCustomer.Image = Properties.Resources.value__1_;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 200);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(12, 0, 0, 0);
            btnCustomer.Size = new Size(220, 60);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "    Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.ForeColor = Color.Gainsboro;
            btnOrders.Image = Properties.Resources.shopping_list;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 140);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(12, 0, 0, 0);
            btnOrders.Size = new Size(220, 60);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "    Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.Gainsboro;
            btnProducts.Image = Properties.Resources.shopping_cart__1_;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 80);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(12, 0, 0, 0);
            btnProducts.Size = new Size(220, 60);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "    Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(86, 45);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Platform for NGOs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "सहयोगी हातहरू";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mental_health_and_behaviour_support;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1062, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Corbel", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(964, 1);
            btnMinimize.Margin = new Padding(1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(33, 33);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            toolTip3.SetToolTip(btnMinimize, "Minimize the Window");
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Corbel", 15F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(997, 0);
            btnMaximize.Margin = new Padding(1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(33, 33);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            toolTip2.SetToolTip(btnMaximize, "Maximize the Window");
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.AccessibleDescription = "";
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Corbel", 15F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1028, 0);
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 33);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            toolTip1.SetToolTip(btnClose, "Close the Window");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.cross_out__2_;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(497, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(pictureBox2);
            panelDesktop.Controls.Add(label4);
            panelDesktop.Controls.Add(label3);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1062, 580);
            panelDesktop.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(351, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 321);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(389, 475);
            label4.Name = "label4";
            label4.Size = new Size(294, 33);
            label4.TabIndex = 1;
            label4.Text = "Powered by Matrika Technology";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 62);
            label3.Name = "label3";
            label3.Size = new Size(432, 28);
            label3.TabIndex = 0;
            label3.Text = "Welcome to the NGO Connections";
            // 
            // Form1
            // 
            AccessibleDescription = "    ";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1282, 660);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1050, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NGO Management (सहयोगी हातहरू)";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProducts;
        private Button btnSettings;
        private Button btnNotifications;
        private Button btnReporting;
        private Button btnCustomer;
        private Button btnOrders;
        private Panel panelTitleBar;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panelDesktop;
        private Button btnCloseChildForm;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnExit;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
    }
}
