using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityApp.Repository
{
    public interface ICustomerVietnameseRepository
    {
        IEnumerable<CustomerVietnamese> GetAll();
        CustomerVietnamese GetById(int id);
        void AddNew(CustomerVietnamese customer);
        void Update(CustomerVietnamese customer);
        void Remove(int id);
        double TotalByType (int type);
    }
}
