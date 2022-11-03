using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Seguradora
    {
        static public Veiculo[] registos;
        static public Proprietário[] registos_prop;
        private int proxLivre;
        private int proxLivre2;

        // private List<string> nomes = new List<string>();
        // private static List<string> matriculas = new List<string>();
        // private static List<Veiculo> veiculos = new List<Veiculo>();

        public Seguradora(int numeroVeiculos)
        {
            registos = new Veiculo[numeroVeiculos];
            registos_prop = new Proprietário[numeroVeiculos];
            proxLivre = 0;
            proxLivre2 = 0;
        }


        //---------------------- Veiculo -------------------------
        public Array GetVeiculos()
        {
            return registos;
        }


        public void Registar(string nmatricula, string ncor, string nestado, string nseguro, string nnome_proprietario, int nnum_acidentes)
        {
            Veiculo novo_veiculo = new Veiculo(nmatricula, ncor, nestado, nseguro, nnome_proprietario, nnum_acidentes);


            if (!Existe(novo_veiculo))
            {
                registos[proxLivre] = novo_veiculo;
                proxLivre++;
            }
        }

        private bool Existe(Veiculo novoVeiculo)
        {
            for (int i = 0; i < proxLivre; i++)
            {
                if (registos[i].Matricula == novoVeiculo.Matricula)
                    return true;
            }
            return false;
        }

        public Veiculo Consulta(string matricula)
        {
            for (int i = 0; i < proxLivre; i++)
            {
                if (registos[i].Matricula == matricula)
                    return registos[i];
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < proxLivre; i++)
                res.AppendLine(registos[i].ToString());
            return res.ToString();
        }

        //------------------------- Proprietario ------------------------


        public Array GetProprietarios()
        {
            return registos_prop;
        }


        public void RegistarP(string nnome, int nnif)
        {
            Proprietário novo_prop = new Proprietário(nnome, nnif);


            if (!ExisteP(novo_prop))
            {
                registos_prop[proxLivre2] = novo_prop;
                proxLivre2++;
            }
        }

        private bool ExisteP(Proprietário novo_prop)
        {
            for (int i = 0; i < proxLivre2; i++)
            {
                if (registos_prop[i].Nome == novo_prop.Nome)
                    return true;
            }
            return false;
        }

        public Proprietário ConsultaP(int nif)
        {
            for (int i = 0; i < proxLivre2; i++)
            {
                if (registos_prop[i].Nif == nif)
                    return registos_prop[i];
            }
            return null;
        }

        













        //------------------------- V1 COM O USO DE LISTAS -------------------------------------------------------

        /*
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
        */


    }
}
