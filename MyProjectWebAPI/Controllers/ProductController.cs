using AutoMapper;
using BL;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjectWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        IProductBL _productBL;
        IMapper _mapper;
        public ProductController(IProductBL ProductBL, IMapper mapper)
        {
            _productBL = ProductBL;
            _mapper = mapper;
        }

        // GET: ProductController
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            List<Product> product = await _productBL.GetAllBL();

            if (product != null)
                return Ok(product);
            return NoContent();
            
        }
        
        // GET: ProductController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetByCategoryAsync(int id)
        {
            List<Product> product1 = await _productBL.GetByCategoryBL(id);

            if (product1 != null)
                return Ok(product1);
            return NoContent();
        }

        
        
       
    }
}
