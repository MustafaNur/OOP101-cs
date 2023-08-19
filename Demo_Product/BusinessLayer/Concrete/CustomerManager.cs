﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public List<Customer> IGetList()
        {
           return _customerdal.GetList();
        }

        public void TDelete(Customer t)
        {
            _customerdal.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customerdal.GetById(id);
        }

        public void TInsert(Customer t)
        {
            _customerdal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerdal.Update(t);
        }
    }
}
