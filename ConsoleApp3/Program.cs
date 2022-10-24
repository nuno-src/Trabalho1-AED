using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int op = 7;
            while (op != 0)
            {
                Console.WriteLine("1 - Adicionar veiculo");
                Console.WriteLine("2 - Editar");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    
                    case 1: Registar(); break;
                    case 2: Editar(); break;
                    

                    default:Console.WriteLine("OPÇÃO ERRADA");
                        break;




                }


            }

            




        }



        static void Registar()
        {
            Console.Write("Insira a matricula:");
            string mat = Console.ReadLine();
            Console.Write("Insira a cor:");
            string cor = Console.ReadLine();
            Console.Write("Insira a estado:");
            string estado = Console.ReadLine();
            Console.Write("Insira a seguro:");
            string seguro = Console.ReadLine();
            Console.Write("Insira o nome do proprietario:");
            string np = Console.ReadLine();

            Veiculo novo_veiculo = new Veiculo(mat, cor, estado, seguro, np);

            
            Seguradora.GuardarVeiculo(novo_veiculo);
            Seguradora.GuardarMatricula(novo_veiculo.Matricula);

            Console.WriteLine("Matriculas registadas:");
            Console.WriteLine(string.Join(", ", Seguradora.GetMatriculas()));

            //Console.WriteLine(Seguradora.GetMatriculas());
            Console.WriteLine("\nVeiculo registado com sucesso!");


           
        }

        static void Editar()
        {
            Console.Write("Insira a matricula:");
            string mat = Console.ReadLine();

            /*
            foreach (string matricula in Seguradora.GetMatriculas())
            {
                if (matricula == mat)
                { 
                    matricula.
                }
            }
            */

            foreach (Veiculo v in Seguradora.GetVeiculos())
            {
                foreach (string d in Seguradora.GetMatriculas())
                {
                    if (d == mat)
                    {

                        Console.Write("Insira a matricula:");
                        v.Matricula = Console.ReadLine();
                        Console.Write("Insira a cor:");
                        v.Cor = Console.ReadLine();
                        Console.Write("Insira a estado:");
                        v.Estado = Console.ReadLine();
                        Console.Write("Insira a seguro:");
                        v.Seguro = Console.ReadLine();
                        Console.Write("Insira o nome do proprietario:");
                        v.Nome_proprietario = Console.ReadLine();

                        Console.WriteLine($"Novos dados: {v.Matricula} , {v.Seguro} , {v.Estado} , {v.Seguro} , {v.Nome_proprietario}");
                        Console.WriteLine("\nVeiculo editado com sucesso!");

                    }
                    else {
                        continue;
                    
                    }

                }
                break;
            }
















        }
    }
}
