using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Veiculo
    {
        private string matricula;
        private string cor;
        private string estado;
        private string seguro;
        private string nome_proprietario;
        private int num_acidentes;




        // contrutores:
        public Veiculo()
        {
            Matricula = "";
            Cor = "";
            Estado = "";
            Seguro = "";
            Nome_proprietario = "";
            Num_acidentes = 0;
        }

        public Veiculo(string nmatricula, string ncor, string nestado, string nseguro, string nnome_proprietario, int nnum_acidentes)
        {
            Matricula = nmatricula;
            Cor = ncor;
            Estado = nestado;
            Seguro = nseguro;
            Nome_proprietario = nnome_proprietario;
            Num_acidentes = nnum_acidentes;
        }



        public string Matricula { get => matricula; set => matricula = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Nome_proprietario { get => nome_proprietario; set => nome_proprietario = value; }
        public int Num_acidentes { get => num_acidentes; set => num_acidentes = value; }
    }
}
