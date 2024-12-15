using AutoMapper;
using EasyBook.Domain.Entities.Base;
using EasyBook.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EasyBook.Infrastructure.Repositorys.Base
{
    public abstract class AppRepositoryBase<TEntity, TModel, TDto> : IServiceRepository<TModel, TDto> 
        where TEntity : AppEntityBase // TEntity deve ser uma classe
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

            //Atualiza os campos de data de Criação e Atualização
            entity.Created = DateTime.UtcNow;
            entity.Updated = DateTime.UtcNow;

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

            // Altera os valores da Entidade para os valores da Model
            var mappedEntity = _mapper.Map(model, entity);

            // Atualiza a data de Atualização
            mappedEntity.Updated = DateTime.UtcNow;

            // Informa que houve atualizações
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
