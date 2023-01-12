using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    internal class Company : Taxi
    {
        public int NumberOfEmployees { get; set; }


        public Company(string nome, double anos, int numberOfEmployees) : base(nome, anos)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return Anuallcome * 0.14;
            }
            else
            {
                return Anuallcome * 0.16;
            }
        }
    }
}
