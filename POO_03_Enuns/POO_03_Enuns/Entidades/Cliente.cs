using System;
using System.Collections.Generic;
using System.Text;

namespace POO_03_Enuns.Entidades.System {
    class Cliente {
        public Cliente(string nome, string email, DateTime dataNascimento) {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public Cliente() { }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nome);
            sb.Append(",");
            sb.AppendLine(DataNascimento.ToString("dd/MM/yyyy"));
            sb.AppendLine(" - ");
            sb.AppendLine("Email: ");
            return sb.ToString();
        }

    }
}
