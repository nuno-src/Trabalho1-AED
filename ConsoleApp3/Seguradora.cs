﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Seguradora
    {
        static public Veiculo[] registos;
        private int proxLivre;

        // private List<string> nomes = new List<string>();
        // private static List<string> matriculas = new List<string>();
        // private static List<Veiculo> veiculos = new List<Veiculo>();

        public Seguradora(int numeroVeiculos)
        {
            registos = new Veiculo[numeroVeiculos];
            proxLivre = 0;
        }

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
