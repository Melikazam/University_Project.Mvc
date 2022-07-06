using System;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void CreateContact(Contact contact)
        {
            _contactRepository.AddContact(contact);
        }

        public void DeleteContactById(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public List<Contact> GetContacts()
        {
            return _contactRepository.GetContacts();
        }
    }
}
