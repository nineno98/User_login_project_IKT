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
    }
}
