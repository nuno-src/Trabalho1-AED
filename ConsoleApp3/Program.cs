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
        static Seguradora r = new Seguradora(100);
        static void Main(string[] args)
        {

            

            int op = 7;
            while (op != 0)
            {
                Console.WriteLine("\n-------------------MENU-----------------");
                Console.WriteLine("1 - Adicionar veiculo");
                Console.WriteLine("2 - Consultar veiculos");
                Console.WriteLine("3 - Editar dados veiculos");
                Console.WriteLine("4 - Adicionar Proprietario");
                Console.WriteLine("5 - Consultar Proprietarios");
                Console.WriteLine("6 - Editar dados Proprietarios");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("------------------------------------------");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    
                    case 1: FazerRegisto(); break;
                    case 2: FazerConsulta(); break;
                    case 3: Editar(); break;
                    case 4: FazerRegistoP(); break;
                    case 5: FazerConsultaP(); break;
                    case 6: EditarP(); break;
                    case 7: Environment.Exit(0); break;

                    

                    default:Console.WriteLine("OPÇÃO ERRADA");
                        break;


                }

            }

            



        }

        //--------------------- Veiculo -------------------------------
        static private void FazerRegisto() 
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

            
            Console.Write("Insira o numero de acidentes do veiculo:");
            int n_acidentes = int.Parse(Console.ReadLine());


            r.Registar(mat, cor, estado, seguro, np, n_acidentes);
            

           

            Console.WriteLine("\nVeiculo registado com sucesso!");
        }

        static private void FazerConsulta()
        {
            Console.Write("Insira a matricula:");
            string mat = Console.ReadLine();


            try
            {

                

                foreach (Veiculo v in r.GetVeiculos())
                {
                    if (v.Matricula == mat)
                    {

                        Console.WriteLine($"Veiculo encontrado! - {v.Matricula} , {v.Seguro} , {v.Estado} , {v.Seguro} , {v.Nome_proprietario}, {v.Num_acidentes}");
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(" ");

            }

        }

        static void Editar()
        {
            Console.Write("Insira a matricula:");
            string mat = Console.ReadLine();

            /*
            foreach (string matricula in Seguradora.GetVeiculos())
            {
                if (matricula == mat)
                { 
                    matricula.
                }
            }
            */

            try
            {
                foreach (Veiculo v in r.GetVeiculos())
                {


                    if (v.Matricula == mat)
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

                        Console.Write("Insira o numero de acidentes do veiculo:");
                        int n_acidentes = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Novos dados: {v.Matricula} , {v.Seguro} , {v.Estado} , {v.Seguro} , {v.Nome_proprietario}, {v.Num_acidentes}");
                        Console.WriteLine("\nVeiculo editado com sucesso!");

                    }
                    else
                    {
                        continue;

                    }



                }
            }
            catch (Exception)
            {
                Console.WriteLine(" ");

            }
        }


        //--------------------------- Proprietario ---------------------------------------

        static private void FazerRegistoP()
        {


            Console.Write("Insira o nome:");
            string nome = Console.ReadLine();

            Console.Write("Insira o Nif:");
            int nif = int.Parse(Console.ReadLine());

            

            r.RegistarP(nome, nif);




            Console.WriteLine("\nProprietario registado com sucesso!");
        }

        static private void FazerConsultaP()
        {
            Console.Write("Insira o Nif:");
            int nif = int.Parse(Console.ReadLine());


            try
            {



                foreach (Proprietário p in r.GetProprietarios())
                {
                    if (p.Nif == nif)
                    {

                        Console.WriteLine($"Prfoprietario encontrado! - {p.Nome} , {p.Nif}");
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(" ");

            }

        }

        static void EditarP()
        {
            Console.Write("Insira o Nif:");
            int nif = int.Parse(Console.ReadLine());

            

            try
            {
                foreach (Proprietário p in r.GetProprietarios())
                {


                    if (p.Nif == nif)
                    {

                        Console.Write("Insira o nome:");
                        p.Nome = Console.ReadLine();

                        Console.Write("Insira o Nif:");
                        p.Nif = int.Parse(Console.ReadLine());

                        

                        Console.WriteLine($"Novos dados: {p.Nome} , {p.Nif}");
                        Console.WriteLine("\nProprietario editado com sucesso!");

                    }
                    else
                    {
                        continue;

                    }



                }
            }
            catch (Exception)
            {
                Console.WriteLine(" ");

            }
        }



        //------------------------- V1 COM O USO DE LISTAS -------------------------------------------------------

        /*

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



           */













    }
}
