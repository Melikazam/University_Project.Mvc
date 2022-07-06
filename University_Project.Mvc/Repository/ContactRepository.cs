using System.Collections.Generic;
using System.Linq;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;


        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            _context.Contacts.Remove(_context.Contacts.FirstOrDefault(u => u.Id == id));
            _context.SaveChanges();
        }

        public List<Contact> GetContacts()
        {
            return _context.Contacts.Select(u => u).ToList();
        }
    }
}
