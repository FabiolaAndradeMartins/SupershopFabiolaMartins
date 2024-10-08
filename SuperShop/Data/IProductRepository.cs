﻿using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
