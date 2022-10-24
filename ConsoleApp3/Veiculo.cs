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




        // contrutores:
        public Veiculo()
        {
            Matricula = "";
            Cor = "";
            Estado = "";
            Seguro = "";
            Nome_proprietario = "";
        }

        public Veiculo(string nmatricula, string ncor, string nestado, string nseguro, string nnome_proprietario)
        {
            Matricula = nmatricula;
            Cor = ncor;
            Estado = nestado;
            Seguro = nseguro;
            Nome_proprietario = nnome_proprietario;
        }



        public string Matricula { get => matricula; set => matricula = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Nome_proprietario { get => nome_proprietario; set => nome_proprietario = value; }
    }
}
