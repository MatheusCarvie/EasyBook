using AutoMapper;
using EasyBook.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EasyBook.Infrastructure.Repositorys.Base
{
    public abstract class AppRepositoryBase<TEntity, TModel, TDto> : IActionBase<TModel, TDto> 
        where TEntity : class // TEntity deve ser uma classe
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public AppRepositoryBase(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TDto[]> GetAll()
        {
            // Acessa dinamicamente o DbSet<TEntity> correspondente
            var dbSet = _context.Set<TEntity>();

            // Obtém todos os registros
            var entities = await dbSet.ToListAsync();

            // Mapeia as entidades para DTOs e as retornas
            return _mapper.Map<TDto[]>(entities);
        }

        public async Task<TDto> GetById(Guid id)
        {
            var dbSet = _context.Set<TEntity>();

            // Obtem a entidade pelo id
            var entity = await dbSet.FindAsync(id);

            if (entity == null) throw new Exception("Dado invalido");

            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> Create(TModel model)
        {
            var dbSet = _context.Set<TEntity>();
            var entity = _mapper.Map<TEntity>(model);

            // Adiciona uma nova entidade
            await dbSet.AddAsync(entity);

            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> Update(Guid id, TModel model)
        {
            var dbSet = _context.Set<TEntity>();
            var entity = await dbSet.FindAsync(id);

            if (entity == null) throw new Exception("Dado invalido");

            // Desanexa a entidade para evitar conflitos de contexto
            dbSet.Entry(entity).State = EntityState.Detached;

            // Mapeia a entidade com os valores da model
            var mappedEntity= _mapper.Map<TEntity>(model);

            // Atualiza os valores da entidade
            dbSet.Update(mappedEntity);

            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            return _mapper.Map<TDto>(mappedEntity);
        }

        public async Task Delete(Guid id)
        {
            var dbSet = _context.Set<TEntity>();
            var entity = await dbSet.FindAsync(id);

            if(entity == null) throw new Exception("Dado invalido");
            
            dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
