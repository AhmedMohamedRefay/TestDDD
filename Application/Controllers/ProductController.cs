using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.AuMapp;
using Test.Application.Dto;
using Test.Application.MidleWare;
using Test.Domain.Interfaces;
using Test.Domain.ProductAggregation;
using Test.Domain.ProductAggregation.updateProductInput;
using Test.Infrastructure.Repository;
using Test.Infrastructure.Service;

namespace Test.Application.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
 
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ICacheService _cacheService;
        public ProductController(IProductRepository productRepository, ICacheService cacheService)

        {
            _productRepository = productRepository;
            _cacheService = cacheService;
        }


        [HttpPost("addProduct")]
        public IActionResult addProduct(productDTO productDTO)
        {

            var prod = new Product(productDTO.name, productDTO.description, productDTO.price);
            _productRepository.Add(prod);
            _productRepository.SaveChange();
            return Ok();
        }
       // [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("getProducts")]
         public IActionResult GetProducts()
        {
            var prod = MapperConfig.InitializeAutomapper().Map<List<productDTO>>(_productRepository.GetAll());

            return Ok(_productRepository.GetAll());
        }
        
        [HttpGet("getProduct/{id}")]
        public IActionResult GetProduct(Guid id)
        {
           // var product = _productRepository.GetById(id);
           //if (product == null) { throw new BadRequestException("this product you request it not found now will add in future"); }
           //var prod= MapperConfig.InitializeAutomapper().Map<productDTO>(product);
            
           // return Ok(prod);

            
            var cacheData = _cacheService.GetData<productDTO>($"{id}_product");
            if (cacheData != null)
            {
                
              //  var prod= MapperConfig.InitializeAutomapper().Map<productDTO>(cacheData);

                return Ok(cacheData);
                
            }

           var filteredData = _productRepository.GetById(id);
            var prod2 = MapperConfig.InitializeAutomapper().Map<productDTO>(filteredData);
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            _cacheService.SetData($"{id}_product", prod2, expirationTime);
             // var prod2 = MapperConfig.InitializeAutomapper().Map<productDTO>(filteredData);

            return Ok(prod2);
        }

        [HttpPut("updateProduct/{id}")]
        public IActionResult udateProducts(Guid id, [FromBody]productDTO product)
        {

            var _product = _productRepository.GetById(id);
            if (_product != null)
            {
                //var prod = new Product(product.name,product.description,product.price);

                _product.UpdateProduct(new updateProduct(product.name, product.description, product.price));
                //_product.setName(product.name);
                //_product.setDscription(product.description);
                //_product.setPrice(product.price);

                _productRepository.Update(_product);
                _productRepository.SaveChange();
                return Ok();
            }
            return NotFound("Item not found !");
        
      
    }  
        }


    
}

