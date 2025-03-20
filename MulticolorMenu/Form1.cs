using System.Runtime.InteropServices;

namespace MulticolorMenu
{
    public partial class Form1 : Form
    {
        // Fields
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form? activeForm;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Drag Functionality in the Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5f, FontStyle.Bold);
                    panelTitleBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Loader Form
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) => 
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormProducts(), sender);
            };
            timer.Start();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormOrders(), sender);
            };
            timer.Start();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormCustomer(), sender);
            };
            timer.Start();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormReporting(), sender);
            };
            timer.Start();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormNotifications(), sender);
            };
            timer.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLoader(), sender);
            // Setting the timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds wait
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                // Opening the content of the main form
                OpenChildForm(new Forms.FormSettings(), sender);
            };
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
