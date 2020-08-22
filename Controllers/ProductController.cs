using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivateWork.API.Models.Input;
using PrivateWork.API.Models.OutputModel;
using PrivateWork.Data;
using PrivateWork.Data.Dto;

namespace PrivateWork.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductsRepositoty _repo;
        private readonly IMapper _mapper;
        

        public ProductController(IProductsRepositoty repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ProductGeneralOutputModel>> GetAllProducts()
        {
            var dataWrapper = _repo.GetAllProducts();
            return MakeResponse(dataWrapper, _mapper.Map<List<ProductGeneralOutputModel>>);
        }

        [HttpGet("category/{categoryId}")]
        public ActionResult<List<ProductGeneralOutputModel>> GetProductByCategory(int categoryId)
        {
            var dataWrapper = _repo.GetProductByCategory(categoryId);
            return MakeResponse(dataWrapper, _mapper.Map<List<ProductGeneralOutputModel>>);
        }

        [HttpGet("{productId}")]
        public ActionResult<ProductGeneralOutputModel> GetProductById(int productId)
        {
            var dataWrapper = _repo.GetProductById(productId);
            return MakeResponse(dataWrapper, _mapper.Map<ProductGeneralOutputModel>);
        }

        [HttpPost]
        public ActionResult<ProductGeneralOutputModel> AddProduct([FromBody] ProductInputModel product)
        {
            var dataWrapper = _repo.AddOrUpdateProduct(_mapper.Map<ProductDto>(product));
            return MakeResponse(dataWrapper, _mapper.Map<ProductGeneralOutputModel>);
        }

        [HttpPut]
        public ActionResult<ProductGeneralOutputModel> UpdateProduct([FromBody] ProductInputModel product)
        {
            var dataWrapper = _repo.AddOrUpdateProduct(_mapper.Map<ProductDto>(product));
            return MakeResponse(dataWrapper, _mapper.Map<ProductGeneralOutputModel>);
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