using Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Contracts
{
    public interface ITableService
    {
        public bool Add(Table table);
        public bool Update(Table table);
        public bool Remove(Table table);
        public Table GetById(int id);
        public int Save();
        public List<Table> GetAll();
        public List<Table> GetByDefault(Expression<Func<Table, bool>> expression);
    }
}
