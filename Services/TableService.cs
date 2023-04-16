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
    public class TableService : ITableService
    {
        private ProductContext _context;
        public TableService(ProductContext context)
        {
           _context = context;
        }
        public bool Add(Table table)
        {
            _context.Set<Table>().Add(table);
            return true;
        }

        public List<Table> GetAll()
        {
            return _context.Set<Table>().ToList();
        }

        public List<Table> GetByDefault(Expression<Func<Table, bool>> expression)
        {
            return _context.Set<Table>().Where(expression).ToList();
        }

        public Table GetById(int id)
        {
            return _context.Set<Table>().Find(id);
        }

        public bool Remove(Table table)
        {
            _context.Set<Table>().Remove(table);
            return true;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public bool Update(Table table)
        {
            try
            {
                _context.Set<Table>().Update(table);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
