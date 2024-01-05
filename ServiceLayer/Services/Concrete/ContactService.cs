using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WevApplication.Entities;
using EntityLayer.WevApplication.ViewModels.ContactVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete;

public class ContactService : IContactService
{
    #region private fields

    private readonly IGenericRepository<Contact> _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    #endregion

    public ContactService(IGenericRepository<Contact> repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task AddContactList(ContactAddVM request)
    {
        var contact = _mapper.Map<Contact>(request);
        await _repository.AddEntityAsync(contact);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var contact = await _repository.GetById(id);
        _repository.Delete(contact);
        await _unitOfWork.CommitAsync();
    }

    public async Task<List<ContactListVM>> GetAllListAsync()
    {
        var contactList = await _repository.GetAllList().ProjectTo<ContactListVM>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return contactList;
    }

    public async Task<ContactUpdateVM> GetById(int id)
    {
        var contact = await _repository.Where(x => x.Id == id).ProjectTo<ContactUpdateVM>(_mapper.ConfigurationProvider)
            .SingleAsync();
        return contact;
    }

    public async Task UpdateContactAsync(ContactUpdateVM request)
    {
        var contact = _mapper.Map<Contact>(request);
        _repository.Update(contact);
        await _unitOfWork.CommitAsync();
    }
}