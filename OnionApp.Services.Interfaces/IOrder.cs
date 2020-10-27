using System;
using System.Collections.Generic;
using System.Text;
using OnionApp.Domain.Core;

namespace OnionApp.Services.Interfaces
{
    public interface IOrder
    {
        void MakeOrder(Book book);
    }
}
