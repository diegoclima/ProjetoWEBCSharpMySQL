using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    interface IGrafo<T> {
        Vertice<T> adicionaVertice(string nome, T elemento);;
        Vertice<T> GetVertice(int indice);
        void adicionaAresta(int u, int v);
        void adicionaAresta(Vertice<T> u, Vertice<T> v);
        int numeroVertices();
        int numeroArestas();
        bool isDirigido();
    }
}
