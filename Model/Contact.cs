using System;

namespace CRM
{
    public class Contact
    {
        #region private attributes
        private string _name;
        private string _firstname;
        private DateTime _dateOfBirth;
        private string _nationality;
        private string _email;
        private string _pathToImg;
        #endregion private attributes

        #region public methods
        public Contact (string name, string firstname, DateTime dateOfBirth, string nationality, string email, string pathToImg = "")
        {
            //TODO
        }

        public string Name
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }           
        }

        public string Firstname
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        public string Nationality
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        public string Email
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        public string PathToImg
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
            set
            {
                //TODO
                throw new NotImplementedException();
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
