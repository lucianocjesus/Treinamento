using System.Collections.Generic;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Repositories.Infrastructures;
using Treinamento.Domain.Repositories.Services;
using Treinamento.Infra.Repositories;

namespace Treinamento.Service.Repositories
{
    public class CustomerServices : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerServices()
        {
            _repository = new CustomerRepository();
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
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
