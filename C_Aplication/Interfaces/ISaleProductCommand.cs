using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Domain.Entities;

namespace C_Aplication.Interfaces
{
    public interface ISaleProductCommand
    {
        void InsertSaleProduct(Sale sale , SaleProduct saleProduct);
    }
}