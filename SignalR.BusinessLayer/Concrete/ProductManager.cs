using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;


		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public Product TGetByID(int id)
		{
			return _productDal.GetByID(id);
		}

		public List<Product> TGetListAll()
		{
			return _productDal.GetListAll();
		}

		public List<Product> TGetProductsWithCategory()
		{
			return _productDal.GetProductsWithCategory();
		}
		public int TProductCount()
		{
			return _productDal.ProductCount();
		}
		public int TProductCountByCategoryNameHamburger()
		{
			return _productDal.ProductCountByCategoryNameHamburger();
		}

		public int TProductCountByCategoryNamePizza()
		{
			return _productDal.ProductCountByCategoryNamePizza();
		}
		 
		public decimal TProductPriceAvg()
		{
			return _productDal.ProductPriceAvg();
		}
		public string TMaxPriceByProduct()
		{
			return _productDal.MaxPriceByProduct();
		}
		public string TMinPriceByProduct()
		{
			return _productDal.MinPriceByProduct();
		}

		public decimal TProductPriceByHamburger()
		{
			return _productDal.ProductPriceByHamburger();
		}





		public void TAdd(Product entity)
		{
			_productDal.Add(entity);
		}

		public void TDelete(Product entity)
		{
			_productDal.Delete(entity);
		}


		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}

	}
}
