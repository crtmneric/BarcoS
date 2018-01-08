using BarcoS.Classes.Beans;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarcoS.Classes.Views.MainForms
{
    public partial class frmDBConnection : Form
    {
        public frmDBConnection()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString= string.Format("Data Source={0};Initial catalog={1};User ID={2};Password={3};",cmbServer.Text,txtDatabase.Text,txtUsrname.Text,txtPass.Text);
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SqlHelper helper = new SqlHelper(connectionString);
                if(helper.IsConnection())
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("Bağlantı başarılı!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    MessageBox.Show("Bağlantı başarısız!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Cursor = Cursors.Default;
            }
              catch(Exception ex)
            {
                frmLogin.Log.Error("Test failed", ex);
            }
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("metadata=res://*/Models.Model.csdl|res://*/Models.Model.ssdl|res://*/Models.Model.msl;provider=System.Data.SqlClient;provider connection string=';Data Source={0};Initial catalog={1};User ID={2};Password={3};MultipleActiveResultSets=True;App=EntityFramework';", cmbServer.Text, txtDatabase.Text, txtUsrname.Text, txtPass.Text);
            try
            {               
                    AppSettings setting = new AppSettings();
                    setting.SaveConnectionString("CloudEntities", connectionString);
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\cookies.rna";
                    StreamWriter file2 = new StreamWriter(path);
                    file2.WriteLine("datasource:saved");
                    file2.Close();
                    MessageBox.Show("Başarıyla Kaydedildi! Sistem yeniden başlatılıyor..", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin.Log.Info("Database settings applied succesfully!");
                    Process.Start(Application.ExecutablePath);
                    Application.Exit();
            }
            catch (Exception ex)
            {
                frmLogin.Log.Error("DB CONNECTION STRING SAVE FAILED!", ex);
            }
        }

        private void frmDBConnection_Load(object sender, EventArgs e)
        {
            
            cmbServer.Items.Add(Environment.MachineName);
            cmbServer.Items.Add(".");
            cmbServer.Items.Add("(local)");
            cmbServer.Items.Add(@".\SQLEXPRESS");
            cmbServer.Items.Add(@"(LocalDB)\MSSQLLocalDB");
            cmbServer.Items.Add(string.Format(@"{0}\SQLEXPRESS",Environment.MachineName));
            cmbServer.Items.Add(string.Format(@"{0}(LocalDB)\MSSQLLocalDB",Environment.MachineName));
            cmbServer.SelectedIndex=0;
        }

        private void frmDBConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
