using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson___Cópia
{
    public class JsonSerializador
    {
        public void Serializar()
        {
            var pessoa = new Pessoa
            {
                Nome = "João",
                Idade = 30,
                Casado = true,
                Hobbies = new List<string> { "ler", "cozinhar", "nadar" },
                Endereco = new Endereco
                {
                    Rua = "Rua Principal, 123",
                    Cidade = "Qualquer Cidade",
                    Estado = "SP",
                    Cep = "12345-678"
                }
            };
            Console.WriteLine(pessoa);
            var pesssoaJson = JsonSerializer.Serialize(pessoa);
            Console.WriteLine(pesssoaJson);

        }
    }

 

}
