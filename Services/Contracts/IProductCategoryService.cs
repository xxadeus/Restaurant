using Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Contracts
{
    public interface IProductCategoryService
    {
        public bool Add(ProductCategory productCategory);
        public bool Update(ProductCategory productCategory);
        public bool Remove(ProductCategory productCategory);
        public ProductCategory GetById(int id);
        public int Save();
        public List<ProductCategory> GetAll();
        public List<ProductCategory> GetByDefault(Expression<Func<ProductCategory, bool>> exp);
    }
}
