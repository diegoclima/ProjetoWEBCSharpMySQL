using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_04.MODEL;

namespace CRUD_04.MODEL {
    /// <summary>
    /// Classe Model vai receber aluno e orientador.
    /// </summary>
   public class Pessoa {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string  Telefone { get; set; }
        public string Celular { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Sexo { get; set; }
        public string UF { get; set; }
        public string Endereco { get; set; }
        public Pessoa() { }

        public Pessoa(string nome, int id, string telefone, string celular, string bairro, 
            string cidade, string sexo, string uF, string endereco) {
            Nome = nome;
            Id = id;
            Telefone = telefone;
            Celular = celular;
            Bairro = bairro;
            Cidade = cidade;
            Sexo = sexo;
            UF = uF;
            Endereco = endereco;
        }

    }
}
