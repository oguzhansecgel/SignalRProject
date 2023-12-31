﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ProductList()
		{
			var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
			return Ok(value);
		}
		[HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory() 
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
			{
				ProductDescription = y.ProductDescription,
				ImageURL = y.ImageURL,
				ProductPrice = y.ProductPrice,
				ProductID = y.ProductID,
				ProductName = y.ProductName,
				ProductStatus = y.ProductStatus,
				CategoryName = y.Category.CategoryName
			});
			return Ok(values.ToList());
		}
		[HttpGet("ProductCount")]
		public IActionResult ProductCount() 
		{
			return Ok(_productService.TProductCount());
		}
		[HttpGet("ProductCountByHambuger")]
		public IActionResult ProductCountByHambuger()
		{
			return Ok(_productService.TProductCountByCategoryNameHamburger());
		}
		[HttpGet("ProductCountByPizza")]
		public IActionResult ProductCountByPizza()
		{
			return Ok(_productService.TProductCountByCategoryNamePizza());
		}
		[HttpGet("MaxPriceProduct")]
		public IActionResult MaxPriceProduct()
		{
			return Ok(_productService.TMaxPriceByProduct());
		}
		[HttpGet("MinPriceProduct")]
		public IActionResult MinPriceProduct()
		{
			return Ok(_productService.TMinPriceByProduct());
		}
		[HttpGet("AvgPrice")]
		public IActionResult AvgPriceProduct()
		{
			return Ok(_productService.TProductPriceAvg());
		}
		[HttpGet("AvgPriceHambuger")]
		public IActionResult AvgPriceHambuger()
		{
			return Ok(_productService.TProductPriceByHamburger());
		}







		[HttpPost]
		public IActionResult CreateProduct(CreateProductDto createProductDto)
		{
			_productService.TAdd(new Product()
			{
				ProductDescription = createProductDto.ProductDescription,
				ImageURL = createProductDto.ImageURL,
				ProductPrice = createProductDto.ProductPrice,
				ProductName = createProductDto.ProductName,
				ProductStatus = createProductDto.ProductStatus,
				CategoryID=createProductDto.CategoryID
			});
			return Ok("Ürün Bilgisi Eklendi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteProduct(int id)
		{
			var value = _productService.TGetByID(id);
			_productService.TDelete(value);
			return Ok("Ürün Bilgisi Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetByID(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{
			_productService.TUpdate(new Product()
			{
				ProductDescription = updateProductDto.ProductDescription,
				ImageURL = updateProductDto.ImageURL,
				ProductPrice = updateProductDto.ProductPrice,
				ProductName = updateProductDto.ProductName,
				ProductStatus = updateProductDto.ProductStatus,
				ProductID = updateProductDto.ProductID,
				CategoryID = updateProductDto.CategoryID
			});
			return Ok("Ürün Bilgisi Güncellendi");
		}
	}
}
