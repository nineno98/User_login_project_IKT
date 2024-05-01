using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_login_GUI
{
    public partial class LoginForm : Form
    {
        private bool isAuthenticated_ = false;
        ConnectToDatabase connect;
        GenerateHash hashing;
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool IsAuthenticated { get => isAuthenticated_; set => isAuthenticated_ = value; }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            connect = new ConnectToDatabase();
            hashing = new GenerateHash();

            
        }

        private void belepes_gomb_Click(object sender, EventArgs e)
        {
            string felhaszn = felhasznev.Text;
            string passwd = jelszo.Text;

            if (felhaszn != "" && passwd != "")
            {
                belepes(felhaszn, passwd);
            }
            else
            {
                MessageBox.Show("Nem lehet üres mező!");
            }
        }

        private void belepes(string felhaszn, string passwd)
        {
            if (connect.FindUsername(felhaszn))
            {
                if (connect.CheckPasswdForUser(felhaszn, passwd))
                {
                    isAuthenticated_ = true;
                    this.Close();
                }
                else
                {
                    isAuthenticated_ = false;
                    MessageBox.Show("Hibás jelszó!");
                    felhasznev.Text = "";
                    jelszo.Text = "";
                }
            }
            else
            {
                isAuthenticated_ = false;
                MessageBox.Show("Hibás felhasználónév!");
                felhasznev.Text = "";
                jelszo.Text = "";
            }
        }
    }
}
