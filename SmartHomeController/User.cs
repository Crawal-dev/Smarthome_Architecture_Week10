using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class User
    {

        // private fields
        private int userID;
        private string userName;
        private string contactInfo;

        // public properties
        public int UserID
        {  
            get { return userID; } 
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        // Parameterised constructor
        public User(int constructorUserId, string constructorUserName, string constructorContactInfo)
        {
            UserID = constructorUserId;
            UserName = constructorUserName;
            ContactInfo = constructorContactInfo;
        }

        // Methods
        public void Login(int UserID, string UserName)
        {

        }

        public void Logout()
        {

        }

        public void ControlDevice()
        {

        }

    }
}
