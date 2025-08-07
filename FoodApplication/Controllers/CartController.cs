using AutoMapper;
using FoodApplication.Contracts;
using FoodApplication.Data;
using FoodApplication.Exceptions;
using FoodApplication.Models.Carts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CartController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IICartRepository _repository;

    public CartController(IICartRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cart>> GetCart(int id)
    {
        return Ok(await _repository.GetAsync(id));
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<ActionResult> UpdateCart(int id, [FromBody] CartBase cartBase)
    {
        var cart = await _repository.GetAsync(id);
        _mapper.Map(cartBase, cart);
        try
        {
            await _repository.UpdateAsync(cart);
        }
        catch (Exception e)
        {
            throw new AppErrorResponse(e.Message);
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<ActionResult> DeleteCart(int id)
    {
        try
        {
            await _repository.DeleteAsync(id);
        }
        catch (Exception e)
        {
            throw new AppErrorResponse(e.Message);
        }

        return NoContent();
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Cart>> CreateCart([FromBody] CartBase cartBase)
    {
        var cart = _mapper.Map<Cart>(cartBase);
        try
        {
            await _repository.AddAsync(cart);
        }
        catch (Exception e)
        {
            throw new AppErrorResponse(e.Message);
        }

        return CreatedAtAction(nameof(GetCart), new { id = cart.Id }, cart);
    }
}