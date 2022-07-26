﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public interface IBrandService
        {
            List<Brand> GetAll();
            Brand GetById(int brandId);

            void Insert(Brand brand);

            void Update(Brand brand);

            void Delete(Brand brand);
        }

    }
}
