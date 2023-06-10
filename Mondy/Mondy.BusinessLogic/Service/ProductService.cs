using Mondy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Mondy.BusinessLogic.Service
{
    public class ProductService : Service
	{
        public ServiceResponse<Product> GetById(int id)
        {
            return Success(DbContext.Products.FirstOrDefault(x => x.Id == id));
        }

        public ServiceResponse<List<Product>> Get(Func<Product, bool> pred)
        {
            var prod = DbContext.Products
                .Where(pred)
                .ToList();

            return Success(prod);
        }

        public ServiceResponse<Product> Create(Product product)
        {
            DbContext.Products.Add(product);
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<Product> Edit(Product product)
        {
            DbContext.Entry(product).State = EntityState.Modified;
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<Product> Delete(Product product)
        {
            DbContext.Entry(product).State = EntityState.Deleted;
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<List<Product>> Take(int howMuch)
        {
            var prod = DbContext.Products
                .OrderByDescending(x => x.Created)
                .Take(howMuch)
                .ToList();

            return Success(prod);
        }

        public ServiceResponse<List<Product>> GetAll()
        {
            var prod = DbContext.Products
                .ToList();

            return Success(prod);
        }
    }
}
