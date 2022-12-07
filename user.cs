using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    class User
    {
        public string name;
        public string password;

        public void addUser() 
        {
            
        }
    }

    class Member : User 
    {
        public Member(string memberName, string pw) 
        {
            this.name = memberName;
            this.password = pw;

            if()
        }
    }

    class Librarian : User 
    {
        private string code = "5678";
        private bool success;
        public Librarian(string librarianName, string pw, string access) 
        {
            if (access == code)
            {
                this.name = librarianName;
                this.password = pw;
                this.success = true;
            }
            else 
            {
                this.success = false;
            }
        }
        public void removeUser(string userName) 
        {
            if (this.success) 
            {

            }
        }

        public void listUsers() 
        {
        }
    }
}
