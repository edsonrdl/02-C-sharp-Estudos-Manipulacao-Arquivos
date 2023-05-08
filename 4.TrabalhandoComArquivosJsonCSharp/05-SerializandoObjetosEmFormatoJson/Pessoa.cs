using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson___Cópia
{

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Casado { get; set; }
        public List<string> Hobbies { get; set; }
        public Endereco Endereco { get; set; }
    }
}
