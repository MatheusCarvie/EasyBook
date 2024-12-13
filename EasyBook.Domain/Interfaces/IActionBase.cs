namespace EasyBook.Domain.Interfaces
{
    public interface IActionBase<TModel, TDto>
    {
        public Task<TDto[]> GetAll();
        public Task<TDto> GetById(Guid id);
        public Task<TDto> Create(TModel model);
        public Task<TDto> Update(Guid id, TModel model);
        public Task Delete(Guid id);
    }
}
