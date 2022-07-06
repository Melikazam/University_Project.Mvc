using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);

        void DeleteContact(int Id);

        List<Contact> GetContacts();

    }
}