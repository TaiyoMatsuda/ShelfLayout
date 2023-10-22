﻿using Microsoft.AspNetCore.Mvc;
using ShelfLayout.Server.Usecases.Shelf;
using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShelfController : ControllerBase
    {
        private readonly IShelfUsecase _usecase;

        public ShelfController(IShelfUsecase usecase)
        {
            _usecase = usecase;
        }

        [HttpGet]
        public async Task<ActionResult<CabinetResponse>> GetCabinet()
        {
            var response = await _usecase.GetCabinet();
            return Ok(response);
        }
    }
}
