using Entities.Context;
using Entities.Items;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class ProductService : IProductService
    {
        private ProductContext _context;    
        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public bool Add(Product product)
        {
            _context.Set<Product>().Add(product);   
            return true;
        }
        public List<Product> GetAll() 
        {
            return _context.Set<Product>().ToList();
        }
        public List<Product> GetByDefault(Expression<Func<Product, bool>> expression)
        {
            return _context.Set<Product>().Where(expression).ToList();
        }
        public Product GetById(int id) 
        {
            return _context.Set<Product>().Find(id);
        }
        public bool Remove(Product product)
        { 
            _context.Set<Product>().Remove(product);
            return true;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
        public bool Update(Product product) 
        {
            try
            {
                _context.Set<Product>().Update(product);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
