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

    public class OrderController : ControllerBase
    {
        IOrderBL _orderBL;
        IMapper _mapper;
        public OrderController(IOrderBL orderBL, IMapper mapper)
        {
            _orderBL = orderBL;
            _mapper = mapper;
        }
        // POST: OrderController/Create
        [HttpPost]

        public async Task<ActionResult< OrderDTO>> Post(OrderDTO order)
        {
            {
                Order orderr = await _orderBL.PostBL(_mapper.Map<Order>(order));
                if (orderr == null)
                    return NoContent();
                return _mapper.Map<OrderDTO>(orderr);
            }
        }

        }
}
