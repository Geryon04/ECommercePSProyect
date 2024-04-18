using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Domain.Entities;

namespace C_Aplication.Interfaces
{
    public interface ISaleProductService
    {
        SaleProduct CreateSaleProduct(Product product);
    }
}