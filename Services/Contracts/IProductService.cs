using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Items;

namespace Services.Contracts
{
    public interface IProductService
    {
        public bool Add(Product product);
        public bool Update(Product product);    
        public bool Remove(Product product);    
        public Product GetById(int id);
        public int Save();
        public List<Product> GetAll();
        public List<Product> GetByDefault(Expression<Func<Product, bool>> exp);

    }
}
