using EasyBook.Domain.Entities.Base;
using EasyBook.Domain.Interfaces;
using EasyBook.Infrastructure.Repositorys.Base;

namespace EasyBook.Application.Services.Base
{
    public abstract class AppServiceBase<TEntity, TModel, TDto> : IServiceRepository<TModel, TDto> where TEntity : AppEntityBase
    {
        private readonly AppRepositoryBase<TEntity, TModel, TDto> _repository;

        public AppServiceBase(AppRepositoryBase<TEntity, TModel, TDto> repository)
        {
            _repository = repository;
        }

        public async Task<TDto[]> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TDto> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<TDto> Create(TModel model)
        {
            return await _repository.Create(model);
        }
        public async Task<TDto> Update(Guid id, TModel model)
        {
           return await _repository.Update(id, model);
        }

        public async Task Delete(Guid id)
        {
           await _repository.Delete(id);
            return;
        }
    }
}
