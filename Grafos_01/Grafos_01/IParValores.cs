namespace Grafos_01 {
    public interface IValues<T> {
        /// <summary>
        /// Retorna o V1;
        /// </summary>
        /// <returns></returns>
        T getPrimeiro(); 
        /// <summary>
        /// Retorna V2
        /// </summary>
        /// <returns></returns>
        T getSegundo(); // retorna o segundo vertice;
        /// <summary>
        /// Retorna o valor 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        bool Contains(T valor); // retorna se verdadeior o valor armazenado na estrutura;

    }
}
