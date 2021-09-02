using System;
using System.Collections.Generic;

namespace CrmBusiness
{
    /// <summary>
    /// This class is designed to be Contact list manager
    /// </summary>
    public class ContactListManager
    {
        #region private attributes
        private List<Contact> _contacts;
        private DateTime _creationDate;
        private DateTime _lastUpdate;
        #endregion private attributes

        #region public methods
        /// <summary>
        /// This constructor allows to create a new contact object
        /// </summary>
        /// <param name="contacts">A list of contacts to insert in the manager</param>
        public ContactListManager(List<Contact> contacts = null)
        {
            if(contacts != null)
            {
                _contacts = contacts;
            }

            _creationDate = DateTime.Now;
            _lastUpdate = _creationDate;
        }

        /// <summary>
        /// This property gets the list of contacts present in the manager
        /// </summary>
        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        /// <summary>
        /// This method adds a list of contacts
        /// </summary>
        /// <remarks>A duplicate will be identified with is emailaddress</remarks>
        /// <param name="contacts">A list of contact</param>
        /// <param name="allowDuplicate">Flase = duplicate is not allowed (will be removed), True = duplicate is possible</param>
        public void Add(List<Contact> contactsToAdd, Boolean allowDuplicate=false)
        {
            if (contactsToAdd != null)
            {
                if (!(allowDuplicate))
                {
                    foreach (Contact contact in contactsToAdd)
                    {
                        if (!(Exist(contact)))
                        {
                            contactsToAdd.Add(contact);
                            UpdateLastUpdate();
                        }
                    }
                }
                else
                {
                    _contacts.AddRange(contactsToAdd);
                    UpdateLastUpdate();
                }
            }
        }

        /// <summary>
        /// This method remove the contacts passed as argument from the manager's contacts list
        /// </summary>
        /// <param name="contacts"></param>
        public void Remove(List<Contact> contactsToRemove)
        {
            foreach(Contact contact in contactsToRemove)
            {
                if (Exist(contact))
                {
                    _contacts.Remove(contact);
                    UpdateLastUpdate();
                }
            }
        }
        #endregion public methods

        #region private methods
        private bool Exist(Contact contactToFind)
        {
            bool result = false;
            if(_contacts == null)
            {
                return result;
            }
            foreach (Contact existingContact in _contacts)
            {
                if (existingContact.Email == contactToFind.Email)
                {
                    result = true;
                }
            }
            return result;
        }

        private void UpdateLastUpdate()
        {
            _lastUpdate = DateTime.Now;
        }
        #endregion private methods

    }
}
