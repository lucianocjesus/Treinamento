using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Repositories.Infrastructures;
using Treinamento.Infra.Contexts;

namespace Treinamento.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDataContext _appDataContext;

        public CustomerRepository(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public IList<Customer> GetByRange(int skip = 0, int take = 25)
        {
            return _appDataContext.Customers.OrderBy(x=>x.Name).Skip(skip).Take(take).ToList();
        }

        public Customer GetById(int id)
        {
            return _appDataContext.Customers.Find(id);
        }

        public void Save(Customer customer)
        {
            _appDataContext.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            _appDataContext.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            _appDataContext.Customers.Remove(customer);
        }

        public void Dispose()
        {
            _appDataContext.Dispose();
        }
    }
}
