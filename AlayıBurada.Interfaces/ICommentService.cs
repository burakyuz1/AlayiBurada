﻿using AlayıBurada.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlayıBurada.Interfaces
{
    public interface ICommentService :IGenericService<Comment>
    {
        List<Comment> GetComments(Product product); 
    }
}
