using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swiggy.PaymentModule;
using Swiggy.PaymentModule.Extension;

namespace Swiggy.ClientUI
{
    class Program
    {
        static void Main()
        {
            Payment payment = new Payment();
            payment.PayByCreditCard();
            payment.PayByUPI();
        }
    }
}
