﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
		List<Product> TGetProductsWithCategory();
		int TProductCount();
		public int TProductCountByCategoryNameHamburger();
		public int TProductCountByCategoryNamePizza();
		public string TMaxPriceByProduct();
		public string TMinPriceByProduct();
		public decimal TProductPriceAvg();
		public decimal TProductPriceByHamburger();
	}
}
