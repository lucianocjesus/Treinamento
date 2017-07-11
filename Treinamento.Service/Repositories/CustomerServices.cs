using System.Collections.Generic;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Repositories.Infrastructures;
using Treinamento.Domain.Repositories.Services;
using Treinamento.Domain.Repositories.Uow;

namespace Treinamento.Service.Repositories
{
    public class CustomerServices : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IUnityOfWork _unityOfWork;

        public CustomerServices(ICustomerRepository customerRepository, IUnityOfWork unityOfWork)
        {
            _repository = customerRepository;
            _unityOfWork = unityOfWork;
        }

        public IList<Customer> GetByRange(int skip = 0, int take = 25)
        {
            return _repository.GetByRange(skip, take);
        }

        public Customer GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Save(Customer customer)
        {
            _repository.Save(customer);
            _unityOfWork.Commit();
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
            _unityOfWork.Commit();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _unityOfWork.Commit();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
