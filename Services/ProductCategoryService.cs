using Entities.Context;
using Entities.Items;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private ProductContext _context;
        public ProductCategoryService(ProductContext context)
        {
            _context = context;
        }

        public bool Add(ProductCategory productCategory)
        {
           _context.Set<ProductCategory>().Add(productCategory);
            return true;
        }

        public List<ProductCategory> GetAll()
        {
            return _context.Set<ProductCategory>().ToList();
        }


        public ProductCategory GetById(int id)
        {
            return _context.Set<ProductCategory>().Find(id);
        }

        public bool Remove(ProductCategory productCategory)
        {
            _context.Set<ProductCategory>().Remove(productCategory);
            return true;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public bool Update(ProductCategory productCategory)
        {
            try
            {
                _context.Set<ProductCategory>().Update(productCategory);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        List<ProductCategory> IProductCategoryService.GetByDefault(Expression<Func<ProductCategory, bool>> expression)
        {
            return _context.Set<ProductCategory>().Where(expression).ToList();
        }
    }
}
