﻿using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.AbstractServices
{
    public interface ICategoryService
    {
        //List
        IEnumerable<Category> GetAllCategories();

        //Create
        string Create(Category entity);

        //Update
        string Update(Category entity);

        //Delete
        string Delete(int id);

        //Get
        Category GetById(int id);
    }
}
