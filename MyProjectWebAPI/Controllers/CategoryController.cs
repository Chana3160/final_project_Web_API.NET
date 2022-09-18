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

    public class CategoryController : ControllerBase
    {

        ICategoryBL _categoryBL;
        IMapper _mapper;
        public CategoryController(ICategoryBL CategoryBL,IMapper mapper)
        {
            _categoryBL = CategoryBL;
            _mapper = mapper;
        }

        [HttpGet]
        // GET: Category

        //public String Get(){
        //    return "bbvcbbv";
        //}
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            List<Category> Category = await _categoryBL.GetAllBL();

            if (Category != null)
                return Ok(Category);
            return NoContent();

        }

    }
}
