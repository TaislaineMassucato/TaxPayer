using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    abstract class Taxi
    {
        public string Name { get; set; }
        public double Anuallcome { get; set; }

        public Taxi(string nome, double anos) 
        {
            Name = nome;
            Anuallcome = anos;
        }
        public abstract double Tax();
    }
}
