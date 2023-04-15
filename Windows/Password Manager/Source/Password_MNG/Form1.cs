using System.IO;

namespace Password_MNG
{
    public partial class Main_Form : Form
    {

        public Main_Form()
        {
            InitializeComponent();
        }

        string fileName = "passwords.txt";
        string filePath;
        List<Button> btn_dict = new List<Button>();
        private void Main_Form_Load(object sender, EventArgs e)
        {
            filePath = Path.Combine(Application.StartupPath, fileName);
            if (!File.Exists(filePath))
            {
                Error_Text.Visible = true;
                File.Create(filePath);
            }
        }
        private void Load_TEST_Click(object sender, EventArgs e)
        {
            if(btn_dict != new List<Button>())
            {
                foreach(Button button in btn_dict)
                {
                    Controls.Remove(button);
                }
            }
            try
            {
                string[] pswrd_file = File.ReadAllLines(filePath);
                if (pswrd_file.Length != 0)
                {
                    Error_Text.Visible = false;
                    int y = 0;
                    foreach (string pswrd in pswrd_file)
                    {
                        Button pwrd_btn = new Button();
                        pwrd_btn.Size = new Size(122, 23);
                        pwrd_btn.Location = new Point(89, 139 + y);
                        pwrd_btn.Text = pswrd;
                        pwrd_btn.BackColor = Color.White;
                        pwrd_btn.ForeColor = Color.Black;
                        pwrd_btn.Click += Click_hdl;
                        Controls.Add(pwrd_btn);
                        btn_dict.Add(pwrd_btn);
                        y = y + 25;
                    }
                }
                else
                {
                    Error_Text.Visible = true;
                    Error_Text.Text = "No passwords in: passwords.txt";
                }
            }
            catch
            {
                Error_Text.Visible = true;
                Error_Text.Text = "Critical Error!\nrestarting software in:";
                timer2.Start();
            }
        }
        int seconds = 5;
        string password;
        public void Click_hdl(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            Tima_Text.Text = "Timer: 0";
            seconds = 5;
            password = pressedButton.Text;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tima_Text.Text = "Timer: "+seconds--.ToString();
            if(seconds < 0) {
                timer1.Stop();
                SendKeys.Send(password);
                Tima_Text.Text = "Writen!";
                seconds= 0;
            }
        }
        int seconds2 = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Tima_Text.Text = "Timer: " + seconds2--.ToString();
            if (seconds2 < 0)
            {
                timer2.Stop();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }
        string pass;
        private void Pass_Gen_Click(object sender, EventArgs e)
        {
            foreach(int i in Enumerable.Range(0,13))//13 chars long
            {
                Random random = new Random();
                int numba = random.Next(0, 77);
                char[] Abet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_=+`~[]{};<>?,./".ToCharArray();
                pass += Abet[numba];
            }
            File.AppendAllText(fileName, "\n"+pass);
            try
            {
                Load_TEST_Click(null, null);
                pass = "";
            }
            catch
            {
                Error_Text.Visible = true;
                Error_Text.Text = "Critical Error!\nrestarting software in:";
                timer2.Start();
            }
        }
    }
}