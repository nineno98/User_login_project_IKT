﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_login
{
    
    class User
    {
        private int userid_;
        private string unsername_;
        private string email_;
        

        public User(int userid_, string unsername_, string email_)
        {
            this.userid_ = userid_;
            this.unsername_ = unsername_;
            this.email_ = email_;
            
        }

        public int Userid_ { get => userid_; set => userid_ = value; }
        public string Unsername_ { get => unsername_; set => unsername_ = value; }
        public string Email_ { get => email_; set => email_ = value; }
    }
}
