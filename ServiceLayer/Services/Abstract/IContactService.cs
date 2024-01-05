using EntityLayer.WevApplication.ViewModels.CategoryVM;
using EntityLayer.WevApplication.ViewModels.ContactVM;

namespace ServiceLayer.Services.Abstract;

public interface IContactService
{
    Task<List<ContactListVM>> GetAllListAsync();
    Task AddContactList(ContactAddVM request);
    Task DeleteAsync(int id);
    Task<ContactUpdateVM> GetById(int id);
    Task UpdateContactAsync(ContactUpdateVM request);
}