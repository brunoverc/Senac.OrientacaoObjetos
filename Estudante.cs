using System;
namespace OrientacaoObjetos
{
	// Classe derivada Estudante que herda de Pessoa
    public class Estudante : Pessoa
    {
        // Propriedade privada
        private string _matricula;

        //Propriedade pública
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = DateTime.Now.Year + value; }
        }

        //Construtor
        public Estudante(string nome,
            DateTime dataNascimento,
            string telefone,
            string matricula) : base(nome, dataNascimento, telefone)
        {
            Matricula = matricula;
        }

        // Sobrescrevendo o método para exibir informações do estudante
        public override string ExibirInformacoes()
        {
            string mensagem = "Nome: " + Nome + " sua idade é: " + Idade +
                " seu telefone é: " + Telefone + "\nMatrícula: " + Matricula;

            return mensagem;
        }

    }
}

