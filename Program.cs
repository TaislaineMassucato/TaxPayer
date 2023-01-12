using System.Globalization;
using System.Runtime.Serialization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Taxi> list= new List<Taxi>();

            Console.WriteLine("Enter the number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Indivisual or company (i/c)? ");
                char ic = char.Parse (Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Anual income: ");
                double anu = double.Parse (Console.ReadLine());

                if (ic == 'c' || ic == 'C')
                {
                    Console.WriteLine ("Number of employees: ");
                    int empregados = int.Parse (Console.ReadLine());

                    list.Add(new Company (nome, anu, empregados));
                }
                else
                {
                    Console.WriteLine ("Healt expenditures: ");
                    double despesadaude = double.Parse (Console.ReadLine());

                    list.Add(new Individual (nome, anu, despesadaude));
                }
            }


            double soma = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach(Taxi tx in list)
            {
                double tributacao = tx.Tax();

                Console.WriteLine(tx.Name + " $ " + tributacao.ToString("F2",CultureInfo.InvariantCulture));
                soma += tributacao;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL IMPOSTO: $"+soma.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}