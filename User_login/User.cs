using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_login
{
    
    class User
    {
        private int userid_;
        private string username_;
        private string email_;
        

        public User(int userid_, string username_, string email_)
        {
            this.userid_ = userid_;
            this.username_ = username_;
            this.email_ = email_;
            
        }

        public int Userid_ { get => userid_; set => userid_ = value; }
        public string Username_ { get => username_; set => username_ = value; }
        public string Email_ { get => email_; set => email_ = value; }


        public override string ToString()
        {
            return Username_;
        }
    }
}
