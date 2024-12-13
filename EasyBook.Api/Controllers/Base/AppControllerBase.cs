using EasyBook.Application.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace EasyBook.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class AppControllerBase<TEntity, TModel, TDto> : ControllerBase where TEntity : class
    {
        private readonly AppServiceBase<TEntity, TModel, TDto> _service;
        public AppControllerBase(AppServiceBase<TEntity, TModel, TDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TDto[]>> GetAll()
        {
            var response = await _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById(Guid id)
        {
            var response = await _service.GetById(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<TDto>> Create(TModel model)
        {
            var response = await _service.Create(model);
            return Created(string.Empty, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TDto>> Update(Guid id, TModel model)
        {
            var response = await _service.Update(id, model);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
