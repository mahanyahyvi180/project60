using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Class1
    {

        public class CommissionEmployee : Object
        {
            public string FirstName { get; }
            public string LastName { get; }
            public string SocialSecurityNumber { get; }
            private decimal grossSale;
            private decimal commissionRate;

            public CommissionEmployee(string firstName, string lastName, string socialSecurity, decimal grossSale, decimal commissionRate)
            {
                FirstName = firstName;
                LastName = lastName;
                SocialSecurityNumber = SocialSecurityNumber;
                GrossSales = grossSale;
                CommissionRate = commissionRate;
            }

            public decimal GrossSales
            {
                get
                {
                    return grossSale;
                }

                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)}must be>=0");
                    }

                    grossSale = value;
                }
            }

            public decimal CommissionRate
            {
                get
                {

                    return commissionRate;
                }
                set
                {
                    if (value <= 0 || value >= 1)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)}must be>0 and<1");
                    }

                    commissionRate = value;
                }
            }

            public decimal Earings() => commissionRate * grossSale;

            public override string ToString() => $"commission employee:{FirstName}{LastName}\n" + $"social security number:{SocialSecurityNumber}\n" + $"gross sales:{grossSale:C}\n" + $"commission rate:{commissionRate:F2}";

            
                
            

        }
    }
}
