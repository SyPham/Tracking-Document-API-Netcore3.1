using API.Helpers;
using API.Models;
using API.Repository;
using API.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service.Implementation
{
    public class UserService : ICommonService<UserAccount, int>
    {
        private readonly IRepository<UserAccount, int> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IRepository<UserAccount, int> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Add(UserAccount entity)
        {
            _repository.Add(entity);
        }

        public IQueryable<UserAccount> FindAll()
        {
            return _repository.FindAll();
        }

        public PagedList<UserAccount> FindAllPaging(string keyword, int page, int pageSize)
        {
            return PagedList<UserAccount>.Create(_repository.FindAll(x=>x.Username == keyword).ToList(),page,pageSize);
        }

        public UserAccount FindById(int id)
        {
            return _repository.FindById(id);

        }
        public void Remove(int id)
        {
            _repository.Remove(id);

        }

        public void RemoveMultiple(List<UserAccount> entities)
        {
            _repository.RemoveMultiple(entities);

        }

        public void Update(UserAccount entity)
        {
            _repository.Remove(entity);

        }

        void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
