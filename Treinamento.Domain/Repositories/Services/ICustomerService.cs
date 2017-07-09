using System;
using System.Collections.Generic;
using Treinamento.Domain.Entities;

namespace Treinamento.Domain.Repositories.Services
{
    public interface ICustomerService : IDisposable
    {
        //Tudo que minha entidade pode ou não fazer em relação a aplicação web.
        IList<Customer> GetByRange(int skip = 0, int take = 25);
        Customer GetById(int id);
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
