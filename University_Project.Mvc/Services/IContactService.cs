using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public interface IContactService
    {
        void CreateContact(Contact contact);
        List<Contact> GetContacts();
        void DeleteContactById(int id);
    }
}