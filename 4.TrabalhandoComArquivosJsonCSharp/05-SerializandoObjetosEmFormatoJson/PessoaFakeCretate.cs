using _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson___Cópia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Bogus;

namespace _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson
{
    public class PessoaFakeCretate
    {
      public  void  fakePessoa()
        {
            var faker = new Faker<Pessoa>()
                .RuleFor(p => p.Nome, f => f.Name.FullName())
                .RuleFor(p => p.Idade, f => f.Random.Int(18, 65))
                .RuleFor(p => p.Casado, f => f.Random.Bool())
                .RuleFor(p => p.Hobbies, f => new List<string> { f.Random.Word(), f.Random.Word(), f.Random.Word() })
                .RuleFor(p => p.Endereco, f => new Endereco
                {
                    Rua = f.Address.StreetName(),
                    Cidade = f.Address.City(),
                    Estado = f.Address.State(),
                    Cep = f.Address.ZipCode()
                });

            var pessoa = faker.Generate();
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
