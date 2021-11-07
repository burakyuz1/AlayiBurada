﻿using AlayıBurada.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlayıBurada.Interfaces
{
    public interface IProductService:IGenericService<Product>
    {
        
        //Sadece bu entity'e özgü metodlar gelecek . Mesela;
        List<Product> ProductList();
        int ProductCountByCategory(int categoryId);

        
        
    }
}
