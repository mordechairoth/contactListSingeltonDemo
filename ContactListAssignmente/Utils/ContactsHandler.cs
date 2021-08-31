using ContactListAssignmente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContactListAssignmente.Utils
{
    public class ContactsHandler
    {
        private readonly List<Contact> _contacts;
        private static ContactsHandler _contactsHandler;
        public int Count { get => _contacts.Count; }
        private int _idCounter;
        
        private ContactsHandler()
        { 
            _contacts = new List<Contact>();
            _idCounter = 0;
        }

        public static ContactsHandler GetInstance()
        {
            return _contactsHandler ??= new ContactsHandler();
        }

        public void Add(Contact contact)
        {
            contact.Id = _idCounter++;
            _contacts.Add(contact);
        }

        public bool Remove(int id)
        {
            return _contacts.Remove(_contacts.Find(x => x.Id == id));
        }

        public bool Edit(Contact contact)
        {
            bool removed = Remove(contact.Id);

            if (removed)
                _contacts.Add(contact);

            return removed;
        }

        public IEnumerable<Contact> All()
        {
            return _contacts;
        }

        public Contact Find(int id)
        {
            return _contacts.First(x => x.Id == id);
        }
    }
}
