using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Repositories;
using HandsOnAPIUsingEF.Models;
namespace HandsOnAPIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductRepository ProductRepository;
        public ProductController()
        {
            ProductRepository = new ProductRepository();
        }
        //Action methods and end points
        [HttpGet,Route("GetAllProducts")]
        public IActionResult Getall()
        {
            return StatusCode(200, ProductRepository.GetProducts());
        }
        [HttpGet,Route("GetProductById/{id}")]
        public IActionResult Get(int id)
        {
            return StatusCode(200, ProductRepository.GetProduct(id));
           // return ProductRepository.GetProduct(id);
        }
        [HttpPost,Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            ProductRepository.AddProduct(product);
            return StatusCode(200, "Record Added");
        }
        [HttpPut, Route("EditProduct")]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return StatusCode(200, "Record Edited");
        }
        [HttpDelete,Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            ProductRepository.DeleteProduct(id);
            return StatusCode(200);
        }
    }
}
