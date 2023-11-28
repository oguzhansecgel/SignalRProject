using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContext context) : base(context)
		{
		}

		public List<Product> GetProductsWithCategory()
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).ToList();
			return values;
		}

		public string MaxPriceByProduct()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.ProductPrice == (context.Products.Max(y => y.ProductPrice))).Select(z => z.ProductName).FirstOrDefault();
		}

		public string MinPriceByProduct()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.ProductPrice == (context.Products.Min(y => y.ProductPrice))).Select(z => z.ProductName).FirstOrDefault();
		}

		//public decimal MaxPriceByProduct()
		//{
		//	using var context = new SignalRContext();
		//	var values = context.Products.OrderByDescending(x => x.ProductPrice).Select(x=>x.ProductPrice).FirstOrDefault();
		//	return values;
		//}

		public int ProductCount()
		{
			using var context = new SignalRContext();
			var values = context.Products.Count();
			return values;
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNamePizza()
		{
			using var context = new SignalRContext();
			//return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Pizza").Select(z => z.CategoryID).FirstOrDefault())).Count();
			return context.Products.Where(x => x.Category.CategoryName == "Pizza").Count();		
			
		}
		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			return context.Products.Average(x => x.ProductPrice);
		}

		public decimal ProductPriceByHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.ProductPrice);
		}
	}
}
