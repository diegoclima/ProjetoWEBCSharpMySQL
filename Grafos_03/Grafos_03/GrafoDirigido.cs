using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_03 {
    class GrafoDirigido :Grafo {
        public GrafoDirigido(List<string> entrada) {
            foreach (String ent in entrada) {
                if (entrada.Contains("#")) {
                    this.totalVerticesGrafo = int.Parse(ent.Substring(1, ent.Length - 1));
                } else {
                    string[] vetor = ent.Split(';');

                    Vertice v1 = vetor[0].Equals("") ? null : new Vertice(vetor[0]);
                    Vertice v2 = vetor[1].Equals("") ? null : new Vertice(vetor[1]);
                    int peso = vetor[2].Equals("") ? 0 : int.Parse(vetor[2]);
                    int dir = vetor[3].Equals("") ? 0 : int.Parse(vetor[3]);

                    Aresta aresta = null;
                    aresta = new Aresta(v1, v2, peso, dir);
                    this.vertices.Add(aresta);
                }
            }
        }
        public int getGrauEntrada(string v1) {
            int grau = 0;
            foreach (Aresta aresta in vertices) {
                if ((aresta.V_final!=null) &&(aresta.V_incial.Nome.Equals(v1))) {
                    if (aresta.Direcao.Equals(1)) {
                        grau++;
                    }

                }
                if (aresta.V_final!=null&&(aresta.V_final.Nome.Equals(v1))) {
                    if (aresta.Direcao.Equals(-1)) {
                        grau++;
                    }
                }
            }
            return grau;
        }
        public int getGrauSaida(string v1) {
            int grau = 0;

            foreach (Aresta aresta in this.vertices) {
                if (aresta.V_final != null && (aresta.V_incial.Nome.Equals(v1))) {
                    if (aresta.Direcao.Equals(-1)) {
                        grau++;
                    }
                }
                if (aresta.V_final != null && (aresta.V_final.Nome.Equals(v1))) {
                    if (aresta.Direcao.Equals(1)) {
                        grau++;
                    }


                }
            }

            return grau;
        }
        public bool getHasCiclo() {
            /*
     #define marca u.I

   int temciclo (Graph* g) {
      Vertex* v0 = g–>vertices, * vn = g–>vertices+g–>n;
      for (v = v0; v < vn; v++)
         v–>marca = BRANCO;
      for (y = v0; y < vn; y++) {  /* não há vértices com marca CINZA *
               if (y–> marca == PRETO) continue;
               y–> marca = CINZA;
               if (dfs(y) == 1) return 1;
           }
      return 0;
   }
   */
            bool retorno = false;
            const int BRANCO = -1;
            const int CINZA = 0;
            const int PRETO = 1;



            return retorno;
        }

        public bool hasCiclo() {
            bool retorno = false;
            const int BRANCO = -1;
            const int CINZA = 0;
            const int PRETO = 1;
            return retorno;
        }

        public override string setResposta(string respString) {
            try {
                int resp = int.Parse(respString);
                switch (resp) {
                    case 1: return this.preGetGrauEntrada();
                    case 2: return this.preGetGrauSaida();
                    case 3: return this.preHasCiclo();
                    default: return "";
                }
            } catch (Exception e) {
                Console.WriteLine("Erro ao converter resposta" + e);
                return "0";
            }
        }

        private string preHasCiclo() {

            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Verifica se possui CICLO.                |");
            Console.WriteLine("+------------------------------------------------+");
            bool retorno = this.getHasCiclo();
            Console.WriteLine();
            if (retorno == true) {
                Console.WriteLine("O grafo possui ciclo");
                Console.WriteLine();
            } else {
                Console.WriteLine("O grafo é acíclico (Não possui ciclo)");
            }
            return Console.ReadLine();


        }

        private string preGetGrauSaida() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Quantidade de GRAU SAIDA do vértice.     |");
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("Digite o nome do Vértice: ");
            string v1 = Console.ReadLine();
            int retorno = this.getGrauSaida(v1);
            Console.WriteLine();
            Console.WriteLine("O vértice " + v1 + " possui " + retorno + " graus de Saída");
            Console.WriteLine();
            Console.WriteLine("Pressione 0 (zero) para sair ou qualquer tecla para voltar ao MENU");
            return Console.ReadLine();
        }

        private string preGetGrauEntrada() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Quantidade de GRAU ENTRADA do vértice.   |");
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("Digite o nome do Vértice: ");
            string v1 = Console.ReadLine();
            int retorno = this.getGrauEntrada(v1);
            Console.WriteLine();
            Console.WriteLine("O vértice " + v1 + " possui " + retorno + " graus de Entrada");
            Console.WriteLine();
            Console.WriteLine("Pressione 0 (zero) para sair ou qualquer tecla para voltar ao MENU");
            return Console.ReadLine();
        }
    }
}

