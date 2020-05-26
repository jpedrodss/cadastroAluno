namespace CadastroAluno
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        /// <summary>
        /// Mostra média final do aluno.
        /// </summary>
        /// <returns>Valor da média final(float).</returns>
        public float VerMediaFinal(){
            return mediaFinal;
        }
        /// <summary>
        /// Calcula e mostra valor da mensalidade do aluno.
        /// </summary>
        /// <returns>Valor calculado da mensalidade(float)</returns>
        public float VerMensalidade(){
            
            float valorCalculado = valorMensalidade;
            if(bolsista == true){
                valorCalculado = valorMensalidade - (valorMensalidade * percentual / 100);
            }
            return valorCalculado;

        }
    }
}