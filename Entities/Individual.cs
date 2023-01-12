using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    internal class Individual : Taxi
    {
        public double HealthExpenditures { get; set; }

        public Individual(string nome, double anos, double gastosaude) : base(nome, anos)
        {
            HealthExpenditures = gastosaude;

        }
        public override double Tax()
        {
            if(Anuallcome < 20000.00)
            {
                return Anuallcome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Anuallcome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
