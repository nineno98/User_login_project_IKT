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
    public partial class Form1 : Form
    {
        List<User> users;
        ConnectToDatabase connect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new ConnectToDatabase();
            users = new List<User>();
            //frissit();
        }

        private void frissit()
        {
            users.Clear();
            lista_listbox.Items.Clear();
            users = connect.SelectUsers();
            lista_listbox.Items.AddRange(users.ToArray());
        }

        private void lista_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_button_Click(object sender, EventArgs e)
        {
            frissit();
        }

        private void kilepes_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
