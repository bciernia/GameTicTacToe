using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe.Repository
{
    public class TicTacToeRepository
    {
        private readonly Model.Context _context;

        public TicTacToeRepository(Model.Context context)
        {
            _context = context;
        }

        public int AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();

            return employee.Id;
        }

        public IQueryable<Employee> GetAllEmployees()
        {
            var list = _context.Employees;

            return list;
        }
    }
}
