using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyFinance.Domain.Entities;
using MyFinance.Shared.Dtos;

namespace MyFinance.Data.Mappings
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<Transaction, TransactionDto>();
        }
    }
}
