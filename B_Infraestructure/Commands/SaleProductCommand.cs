using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Domain.Entities;
using C_Aplication.Interfaces;
using B_Infraestructure.Persistence;

namespace B_Infraestructure.Commands
{
    public class SaleProductCommand : ISaleProductCommand
    {
        private readonly AppDbContext _context;
        
        public SaleProductCommand(AppDbContext context){
            _context = context;
        }

        public void InsertSaleProduct(Sale sale , SaleProduct saleProduct){
            _context.Add(sale);
            _context.Add(saleProduct);
            _context.SaveChanges();
        }
    }
}