using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Proprietário
    {
        private string nome;
        private int nif;


        // contrutores:
        public Proprietário()
        {
            nome = "";
            nif = 0;
            
        }

        public Proprietário(string nnome, int nnif)
        {
            nome = nnome;
            nif = nnif;

        }



        protected string Nome { get => nome; set => nome = value; }
        protected int Nif { get => nif; set => nif = value; }
    }
}
