using System;

namespace Treinamento.Domain.Repositories.Uow
{
    public interface IUnityOfWork : IDisposable
    {
        void Commit();
    }
}
