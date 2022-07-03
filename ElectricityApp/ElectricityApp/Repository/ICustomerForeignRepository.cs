using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityApp.Repository
{
    public interface ICustomerForeignRepository
    {
        IEnumerable<CustomerForeign> GetAll();
        CustomerForeign GetById(int id);
        void AddNew(CustomerForeign customer);
        void Update(CustomerForeign customer);
        void Remove(int id);
        double AverageTotal();
    }
}
