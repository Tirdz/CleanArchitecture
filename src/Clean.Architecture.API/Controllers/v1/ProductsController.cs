﻿using Clean.Architecture.Business.Common.Models;
using Clean.Architecture.Business.Products.Queries.GetProductById;
using Clean.Architecture.Business.Products.Queries.GetProducts;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductsController : ApiControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]        
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await Mediator.Send(new GetProductsQuery()));
        }

        [MapToApiVersion("1.0")]
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllProducts(long id)
        {
            var query = new GetProductByIdQuery { ProductId = id };
            return Ok(await Mediator.Send(query));
        }
    }
}
