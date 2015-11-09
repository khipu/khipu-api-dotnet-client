## Usage

### Basic usage
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khipu;
using Khipu.Api;
using Khipu.Client;
using Khipu.Model;

namespace ApiClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Secret = "123abc";
            Configuration.ReceiverId = 1234;
            PaymentApi a = new PaymentApi();

            DateTime d = DateTime.Now;
            try {
                DateTime dt = DateTime.Now;
                dt = dt.AddDays(1);
                CreateResponse r = a.PaymentsPost("test payment", "CLP", 44, expiresDate: dt, sendReminders: false);
                System.Console.WriteLine(r);
                PaymentResponse r2 = a.PaymentsIdGet(r.PaymentId);
                System.Console.WriteLine(r2);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            System.Console.Read();
        }
    }
}
```
