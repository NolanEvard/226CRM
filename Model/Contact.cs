namespace CRM
{
    public class Contact
    {
        #region private attributes
        private string _name;
        private string _firstname;
        #endregion private attributes

        #region public methods
        public Contact (string name, string firstname)
        {
            _name = name;
            _firstname = firstname;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
