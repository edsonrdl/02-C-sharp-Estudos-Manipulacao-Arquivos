using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _4.TrabalhandoComArquivosJsonCSharp._05_SerializandoObjetosEmFormatoJson___Cópia
{
    public class JsonDesserializador
    {
        public void Desserializar()
        {
            var json = File.ReadAllText("D:\\Edson\\Estudos\\Programação\\back-end\\02-C-sharp-Estudos-Manipulacao-Arquivos\\4.TrabalhandoComArquivosJsonCSharp\\05-SerializandoObjetosEmFormatoJson\\pessoa.json");
            var pessoaObjt = JsonSerializer.Deserialize<Pessoa>(json);
            Console.WriteLine($"Nome: {pessoaObjt.Nome}");
            Console.WriteLine($"Idade: {pessoaObjt.Idade}");
            Console.WriteLine($"Casado: {pessoaObjt.Casado}");
            Console.WriteLine($"Hobbies: {string.Join(", ", pessoaObjt.Hobbies)}");
            Console.WriteLine($"Rua: {pessoaObjt.Endereco.Rua}");
            Console.WriteLine($"Cidade: {pessoaObjt.Endereco.Cidade}");
            Console.WriteLine($"Estado: {pessoaObjt.Endereco.Estado}");
            Console.WriteLine($"CEP: {pessoaObjt.Endereco.Cep}");


        }
    }
}
