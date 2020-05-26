namespace CadastroAluno
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string rg;
        public string curso;
        public bool bolsista;
        /// <summary>
        /// Traduz boolean para sim ou nao, ao invés de true ou false.
        /// </summary>
        /// <param name="condicao">texto capturado pelo console</param>
        /// <returns>resposta em portugues</returns>
        public bool TraduzConsole(string condicao){
            if(condicao == "sim"){
                bolsista = true;
            }else {
                bolsista = false;
            }
            return bolsista;
        }
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