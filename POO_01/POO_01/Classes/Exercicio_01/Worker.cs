using System;
using System.Collections.Generic;
using System.Text;
using POO_01.Classes.System;

namespace POO_01.Classes.Exercicio_01 {
    class Worker {
        public Worker(string nome, WorkerLevel level, double baseSalarial, Departamento depto) {
            Nome = nome;
            this.level = level;
            this.baseSalarial = baseSalarial;
            this.departament = depto;
        }

        public string Nome { get; set; }
        public WorkerLevel level { get; set; } //Enum para classificar o nivel do funcionario
        public double baseSalarial { get; set; }
        //Composicao:
        //Dentro da Classe Worker precisa declarar um tipo da classe Departamento
        public Departamento departament { get; set; }
        //Associacao: Um trabalhador pode ter vários contratos. 
        //Criar uma propriedade do tipo contrato e por ser vários contratos, deve-se criar
        // uma lista com vários contratos. Ou um vetor de contratos. Como o vetor tem tamanho fixo, a lista
        // se torna mais aceitável pelo seu tamanho variável. 
        public List<HourContract> contratos { get; set; } = new List<HourContract>();// aki é associada uma lista de 
        //contratos. Daí uma composicao.
        //Sempre com associação para muitos, não incluir no construtor.

            /// <summary>
            /// Recebe um contrato como paramentro e será adicionado a lista os contratos add
            /// </summary>
            /// <param name="contrato"></param>
        public void AdicionaContrato(HourContract contrato) {
            this.contratos.Add(contrato);
        }
        public void RemoveContrato(HourContract contrato) {
            this.contratos.Remove(contrato);
        }
        public double Income(int year, int month) {
            double soma = baseSalarial;
            // vai percorrer a lista de contratos e soma o mes e ano.
            foreach (HourContract contract in contratos) {
                if (contract.Date.Year.Equals(year)&& contract.Date.Month.Equals(month)) {
                    soma += contract.ValorTotal();
                }
            }
            return soma;
        }

        
    }
}
