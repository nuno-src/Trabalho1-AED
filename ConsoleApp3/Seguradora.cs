using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Seguradora
    {

        private List<string> nomes = new List<string>();
        private static List<string> matriculas = new List<string>();

        private static List<Veiculo> veiculos = new List<Veiculo>();


        public Seguradora()
        { 
        
        
        }

        public static List<Veiculo> GetVeiculos()
        {
            return veiculos;
        }


        public static void GuardarVeiculo(Veiculo nveiculo)
        {
            veiculos.Add(nveiculo);
        }
        

        public void GuardarNome(string nnome)
        {
            nomes.Add(nnome);
        }


        public static List<string> GetMatriculas()
        { 
            return matriculas;
        }

        public static void GuardarMatricula(string nmatricula)
        {
            matriculas.Add(nmatricula);
        }



    }
}
