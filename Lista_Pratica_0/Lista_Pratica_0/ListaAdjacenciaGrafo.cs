using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class ListaAdjacenciaGrafo<T>:IGrafo<T> {
        protected bool dirigido;
        protected int nVertices;
        protected int nArestas;
        protected ListaAdjacencia<T>[] adj;

        public ListaAdjacenciaGrafo(int maxVertices, bool dirigido) {
            this.dirigido = dirigido;
            this.nArestas = 0;
            this.nVertices = 0;
            this.adj = new ListaAdjacencia<T>[maxVertices];
        }

        public Vertice<T> adicionaVertice(string nome, T elemento) {
            IndiceVertice<T> v = new IndiceVertice<T>(nome, elemento, nVertices);
            adj[v.Index()] = new ListaAdjacencia<T>(v);
            return v;
        }

        public Vertice<T> GetVertice(int indice) {
            return adj[indice].Vertices();
        }

        private int indice_vertice(Vertice<T> u) {
            return ((IndiceVertice<T>)u).Index();
        }

        public void adicionaAresta(int u, int v) {
            Aresta<T> a = new Aresta<T>(GetVertice(u), GetVertice(v));
            adj[u].adicionaAresta(a);
            if (!dirigido) {
                a = new Aresta<T>(GetVertice(v), GetVertice(u));
            }
            this.nArestas++;
        }
        public void adicionaAresta(Vertice<T> u, Vertice<T> v) {
            adicionaAresta(indice_vertice(u), indice_vertice(v));
        }
        public int numeroVertices() {
            return nVertices;
        }
        public int numeroArestas() {
            return nArestas;
        }

        public bool isDirigido() {
            return dirigido;
        }

        //public Iterable<Vertice<T>> Vertices() {
        //    return new VerticeIteracao();
        //}

        //public Iterable<Vertice<T>> adjacentVertices(int indice) {
        //    return new VerticeAdjacente(indice);
        //}

        //public Iterable<Vertex<T>> adjacentVertices(Vertex<T> v) {
        //    return adjacentVertices(vertexIndex(v));
        //}
    }
}
