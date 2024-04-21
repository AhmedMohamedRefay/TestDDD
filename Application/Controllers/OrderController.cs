using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using Test.Application.AuMapp;
using Test.Application.Dto;
using Test.Domain.Interfaces;
using Test.Domain.OrderAggregation;
using Test.Domain.ProductAggregation;
using Test.Domain.SeedWork;

namespace Test.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HttpClient _httpClient;

        public OrderController(IUnitOfWork unitOfWork, HttpClient httpClient)
        {
            _unitOfWork = unitOfWork;
            _httpClient = httpClient;
        }

        [HttpGet("GetToken")]
        public async Task<dynamic>   GetToken()
        {
            var requestContent = new FormUrlEncodedContent(
       [
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
            new KeyValuePair<string, string>("username", "ahmed"),
            new KeyValuePair<string, string>("password", "ahmed"),
            new KeyValuePair<string, string>("client_id", "clinet_mobile"),
            new KeyValuePair<string, string>("client_secret", "secret"),
            new KeyValuePair<string, string>("scope","myApi.read")
        ]);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.PostAsync("https://localhost:7029/connect/token",requestContent);

            var responseContent = await response.Content.ReadAsStringAsync();

            var jsonResponse = JObject.Parse(responseContent);

            var accessToken = jsonResponse.GetValue("access_token").ToString();
            return accessToken;
            


        }
        [HttpPost("addOrder")]
        public IActionResult addOrder([FromBody]orderDTO order)
        {

            var orderitem = new OrderItem(order.itemName,order.itemDescription,order.itemPrice,order.itemQuantity,order.productId);
            Address address = new Address(order.Street,order.City,order.Country,order.ZipCode);

            var ord = new Order(address);

            ord.AddOrderItem(orderitem);
            _unitOfWork.OrderRepository.AddAsync(ord);
            _unitOfWork.save(); 

            return Ok(ord);
        }

        [HttpGet("getOrders")]
        public IActionResult getOrders()
        {
            var orders = MapperConfig.InitializeAutomapper().Map<List<ResponseOrderDTO>>(_unitOfWork.OrderRepository.GetAll());


            return Ok(orders);
        }

        [HttpGet("getOrder/{id}")]
        public IActionResult getOrder(Guid id)
        {
            var order = _unitOfWork.OrderRepository.GetByIdAsync(id);
            if (order == null) { return NotFound("Item not found !"); }
            var ord = MapperConfig.InitializeAutomapper().Map<ResponseOrderDTO>(order);

            return Ok(ord);
        }

        
    }
}
