using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson___Cópia
{
    public class CreatePessoa
    {
        public  void NovaPessoa()
        {
            var pessoa = new Pessoa
            {
                Nome = "Lucas",
                Idade = 27,
                Casado = true,
                Hobbies = new List<string> { "Jogar", "Caminhar", "Academia" },
                Endereco = new Endereco
                {
                    Rua = "Rua Principal, 345",
                    Cidade = "Qualquer Cidade",
                    Estado = "RJ",
                    Cep = "12655-678"
                }
            };
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Casado: {pessoa.Casado}");
            Console.WriteLine($"Hobbies: {string.Join(", ", pessoa.Hobbies)}");
            Console.WriteLine($"Rua: {pessoa.Endereco.Rua}");
            Console.WriteLine($"Cidade: {pessoa.Endereco.Cidade}");
            Console.WriteLine($"Estado: {pessoa.Endereco.Estado}");
            Console.WriteLine($"CEP: {pessoa.Endereco.Cep}");

        }
    }
}
