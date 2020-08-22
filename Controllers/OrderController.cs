
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using PrivateWork.Data;
using PrivateWork.API.Models;
using System;

namespace PrivateWork.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public ActionResult<OrderOutputModel> GetOrderById(int id)
        {
            var dataWrapper = _repo.GetOrderById(id);
            return MakeResponse(dataWrapper, _mapper.Map<OrderOutputModel>);
        }


        private delegate T DtoConverter<T, K>(K dto);

       
        private ActionResult<T> MakeResponse<T, K>(DataWrapper<K> dataWrapper, DtoConverter<T, K> dtoConverter)
        {
            if (!dataWrapper.IsOk)
            {
                return BadRequest(dataWrapper.ExceptionMessage);
            }
            return Ok(dtoConverter(dataWrapper.Data));
        }

    }
}