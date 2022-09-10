using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LojaEntities())
            {
                //criando clientes
                Cliente cliente1 = new Cliente()
                {
                    Nome = "Smeagol",
                    Email = "smeagol@gollum.com"
                };
                db.Clientes.Add(cliente1);
                db.SaveChanges();

                Cliente cliente2 = new Cliente()
                {
                    Nome = "Harry Potter",
                    Email = "harry@potter.com"
                };
                db.Clientes.Add(cliente2);
                db.SaveChanges();

                Cliente cliente3 = new Cliente()
                {
                    Nome = "Thanos",
                    Email = "thanos@inevitavel.com"
                };
                db.Clientes.Add(cliente3);
                db.SaveChanges();

                //criando pedidos
                cliente1.Pedidoes.Add(new Pedido
                {
                    Item = "Precioso",
                    Preco = 1000
                });

                cliente2.Pedidoes.Add(new Pedido
                {
                    Item = "Nimbus 2000",
                    Preco = 10000
                });

                cliente3.Pedidoes.Add(new Pedido
                {
                    Item = "Jóias do Infinito",
                    Preco = 500000
                });
            }
        }
    }
}
