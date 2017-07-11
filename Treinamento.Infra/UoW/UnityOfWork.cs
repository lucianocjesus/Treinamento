using Treinamento.Domain.Repositories.Uow;
using Treinamento.Infra.Contexts;

namespace Treinamento.Infra.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly AppDataContext _dataContext;

        public UnityOfWork(AppDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Commit()
        {
            _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
