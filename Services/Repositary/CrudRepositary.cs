using CrudRepositary.DataAccess;
using CrudRepositary.Models;
using CrudRepositary.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepositary.Services.Repositary
{
    public class CrudRepositary : IEmployee
    {

        private readonly DataContext _Conn;
        public CrudRepositary(DataContext Conn) { _Conn = Conn; }
        public bool Delete(int id)
        {
            var deleteData = _Conn.emps.SingleOrDefault(dataid => dataid.Id == id);
            _Conn.emps.Remove(deleteData);
            _Conn.SaveChanges();
            return true;
        }

        public List<Emp> GetAllDetails()
        {
            return _Conn.emps.ToList();
        }

        public Emp GetById(int id)
        {
            return _Conn.emps.SingleOrDefault(dataid => dataid.Id == id);
        }

        public Emp InsertCustomer(Emp data)
        {
            _Conn.emps.Add(data);
            _Conn.SaveChanges();
            return data;
        }

        public Emp Update(Emp data1)
        {
            _Conn.emps.Update(data1);
            _Conn.SaveChanges();
            return data1;
        }
    }
}
