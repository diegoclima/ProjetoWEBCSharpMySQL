namespace Grafos_01 {
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;
    
    public class PairValueImplementaion<T>: IValues<T> {
        // readonly significa que o valor não poder ser alterado. 
        private T _t1; // valores não podem ser alterados;
        private T _t2;
        /// <summary>
        /// Construtor recebe dois argumentos de algum tipo
        /// Não podem ser nulos e deverá ter algum tipo de valor.
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public PairValueImplementaion(T t1, T t2) {
            if (t1 == null|| t2 == null) {
                throw new ArgumentNullException();
               
            }else if(t1.GetType() != t2.GetType()) {
                throw new ArgumentNullException();
            }
            this._t1 = t1;
            this._t2 = t2;
                
        }
        
        public bool Contains(T valor) {
            return valor.Equals(_t1) || valor.Equals(_t2);
        }
        /// <summary>
        /// Retorna o V1
        /// </summary>
        /// <returns></returns>
        public T getPrimeiro() {
            return _t1;
        }
        /// <summary>
        /// Retorna v2
        /// </summary>
        /// <returns></returns>
        public T getSegundo() {
            return _t2;
        }
        /// <summary>
        /// Método retorna true se passou outro obj, se ele tem o mesmo tipo
        /// e seus membros da esquerda-dir ão iguais para aqueles objts
        /// em consideracao.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(object o) {
            if (o == null || o.GetType() != typeof(PairValueImplementaion<T>))
            {
                return false;
            }
            PairValueImplementaion<T> vlrImp =  (PairValueImplementaion<T>) o;
            return vlrImp._t1.Equals(_t1) && vlrImp._t2.Equals(_t2);
        }
        /// <summary>
        /// Retorna a soma de _t1 e _t2;
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() {
            return _t1.GetHashCode() + _t2.GetHashCode();
        }
    }
}
