using SistemaRRHH_EF_DF.Modelo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRRHH_EF_DF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new db_RRHHContext())
            { 
                foreach (var cliente in context.Clientes.ToList()) 
                {
                Console.WriteLine(cliente.Nombre);
                }
             }
        }
    }
}
