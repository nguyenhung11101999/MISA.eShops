using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.eShop.Web.Api
{
    /// <summary>
    /// Thực hiện trả về cho client
    /// CreatedBy: nmhung(23/3/2021)
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        #region DECLARE
        IBaseService<T> _baseService;
        #endregion

        #region CONSTRUCTOR
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }
        #endregion

        // GET: api/<BaseController>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetTs();
            return Ok(entities);
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var entity = _baseService.GetTById(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return StatusCode(204);
            }
        }

        // POST api/<BaseController>
        [HttpPost]
        public IActionResult Post(T entity)
        {
            var serviceResult = _baseService.Add(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        // PUT api/<BaseController>/5
        [HttpPut]
        public IActionResult Put([FromBody] T entity)
        {
            var serviceResult = _baseService.Update(entity);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var serviceResult = _baseService.Delete(id);
            if (serviceResult.MISACode == ApplicationCore.Enums.MISACode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }
    }
}
