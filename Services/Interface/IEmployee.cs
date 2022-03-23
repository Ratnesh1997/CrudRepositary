using CrudRepositary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepositary.Services.Interface
{
    interface IEmployee
    {

        List<Emp> GetAllDetails();
        Emp InsertCustomer(Emp data);
        bool Delete(int id);
        Emp GetById(int id);
        Emp Update(Emp data1);
    }
}
