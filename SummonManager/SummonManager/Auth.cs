using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SummonManager.CLASSES.IRole_namespace;

namespace SummonManager
{
    public partial class Auth : Form
    {
        public IRole UVO;
        public Auth()
        {
            InitializeComponent();
            tbLogin.Focus();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            DBUser dbu = new DBUser();
            UVO = dbu.Login(tbLogin.Text, tbPass.Text);
            if (UVO == null)
            {
                MessageBox.Show("Неверный логин или пароль!");
                tbPass.Text = "";
                return;
            }
            this.Hide();
            //Last user logon

            RegistryKey key;
            if (Registry.CurrentUser.GetValue("Software\\Pusk_SummonManager") == null)
            {
                key = Registry.CurrentUser.CreateSubKey("Software\\Pusk_SummonManager");
                //key.SetValue("Name", "Isabella");
                key.Close();
            }
            key = Registry.CurrentUser.OpenSubKey("Software\\Pusk_SummonManager", true);
            key.SetValue("LastUser", tbLogin.Text);


            //Main mf = new Main(UVO);
           // mf.ShowDialog();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Pusk_SummonManager");
            if (key != null)
            {
                object o = key.GetValue("LastUser");
                if (o == null)
                {
                    return;
                }
                string LastUser = o.ToString();
                tbLogin.Text = LastUser;
                this.ActiveControl = tbPass;
                key.Close();
            }
        }
    }
}
