using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using BarcoS.Models;
using System.IO;
namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmLogin : Form
    {
        int falsePass = 0;
        int animateCounter = 0;
        Boolean trueDB = true;
        public static readonly ILog Log = LogManager.GetLogger(typeof(RollingFileAppender));
        CloudEntities db;
        public static String sessionuser;
        private void SetDb()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\cookies.rna";
            if (File.Exists(path))
            {
                StreamReader file2 = new StreamReader(path);
                String dbConnection = file2.ReadLine();
                file2.Close();
                if (!dbConnection.Contains("datasource:saved"))
                {
                    frmDBConnection dbSettings = new frmDBConnection();
                    dbSettings.ShowDialog();
                }
                if (dbConnection.Contains("datasource:saved") && !trueDB)
                {
                    frmDBConnection dbSettings = new frmDBConnection();
                    dbSettings.ShowDialog();
                }
            }
            else
            {
                frmDBConnection dbSettings = new frmDBConnection();
                dbSettings.ShowDialog();
            }
            BarcoS.Classes.Beans.Logger.Setup();
            Log.Info("System Started Succesfully.");
            digitalGauge2.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
            tmrAnimate.Enabled = true;
            db = new CloudEntities();
        }
        public frmLogin()
        {            
            InitializeComponent();
          
            try
            {
               
                SetDb();
            }
            catch(Exception ex)
            {
                Log.Error("Logger,login or settings file cant load:", ex);
            }
           
         
        }

     
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 9;
        }

     

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text.Length == 4)
                {
                    int parsedValue;
                    if (!int.TryParse(txtPass.Text, out parsedValue))
                    {
                        handleNonIntegerPassword();
                        return;
                    }
                    int password = Convert.ToInt32(txtPass.Text);

                    if (db.users.Count() == 0 && txtPass.Text == "1234")
                    {
                        handleDefaultLogin();
                    }
                    else if (db.users.Where(u => u.password == password).SingleOrDefault() != null)
                    {
                        handleSuccessfulLogin(password);
                    }
                    else
                    {
                        handleFalseLoginAttempt();
                    }
                }
               
            }
            catch(Exception ex)
            {
                trueDB = false;
                SetDb();
                MessageBox.Show("Database bağlantınızı doğru yaptığınızdan emin olunuz! Programı yeniden başlatıyoruz.Problemin devam etmesi halinde iletişime geçiniz", "Üzgünüz..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Cannot connect to database or pass input is wrong",ex);               
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();

            }

        }

        private void handleFalseLoginAttempt()
        {
            Log.Warn("False login attempt! tried to login with this pass :" + txtPass.Text);
            falsePass = 0;
            tmrFalsePass.Enabled = true;
            txtPass.Text = String.Empty;
        }

        private void handleNonIntegerPassword()
        {
            MessageBox.Show("Kullanıcı şifreleri sadece rakamlardan oluşabilir.", "Üzgünüm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Log.Warn("False login attempt! tried to login with this pass :" + txtPass.Text);
            falsePass = 0;
            tmrFalsePass.Enabled = true;
            txtPass.Text = String.Empty;
        }

        private void handleSuccessfulLogin(int password)
        {
            this.Cursor = Cursors.WaitCursor;
            sessionuser = db.users.Where(u => u.password == password).Select(u => u.auth_name).SingleOrDefault();
            Log.Info("Login successfully with:" + sessionuser);
            txtPass.BackColor = Color.Green;
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
            tmrAnimate.Enabled = false;
            tmrFalsePass.Enabled = false;
        }

        private void handleDefaultLogin()
        {
            this.Cursor = Cursors.WaitCursor;
            Log.Info("Login successfully with defaulth account.");
            txtPass.BackColor = Color.Green;
            frmMain mainForm = new frmMain();
            mainForm.Show();
            frmUsers frmUsers = new frmUsers();
            frmUsers.Show();
            frmIntrdctnLogin frmIntrd = new frmIntrdctnLogin();
            frmIntrd.ShowDialog();
            this.Hide();
            tmrAnimate.Enabled = false;
            tmrFalsePass.Enabled = false;
        }

        private void tmrFalsePass_Tick(object sender, EventArgs e)
        {
            falsePass++;
            if(falsePass<6)
            {
                if (falsePass % 2 == 0)
                {
                    txtPass.BackColor = Color.FromArgb(153,0,0);
                }
                else
                {
                    txtPass.BackColor = Color.White;
                }
            }
            else
            {
                tmrFalsePass.Enabled = false;
            }

          
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPass.Focus();
            txtPass.Text += 0;
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            animateCounter++;
            if(animateCounter%2==0)
            {
                digitalGauge2.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 5);
            }
            else
            {
                digitalGauge2.Text = digitalGauge2.Text.Substring(0, 2) + digitalGauge2.Text.Substring(3, 2);
            }
    
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            String before = txtPass.Text;
            if(txtPass.Text.Length>0)
            {
                before = before.Substring(0, txtPass.Text.Length - 1);
            }
            txtPass.Text = before;
          
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        

      
    }
}
