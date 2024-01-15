using System;
namespace OrientacaoObjetos
{
	public class Pessoa
	{
		//Propriedades Privadas
		private string _nome;
		private DateTime _dataNascimento;
		private string _telefone;

		//Propriedades públicas para acesso externo
		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

        public DateTime DataNascimento
        {
            set { _dataNascimento = value; }
        }

        public int Idade
		{
			get { return (DateTime.Now.Year - _dataNascimento.Year); }
		}

		public string Telefone
		{
			get { return _telefone; }
			set { _telefone = value; }
		}

        //Construtor que exige o envio de 3 argumentos(parâmetro)
        public Pessoa(string nome,
            DateTime dataNascimento,
            string telefone)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _telefone = telefone;
        }

        //Construtor padrão que não recebe nenhum parâmetro
        public Pessoa() { }
		

		

		//Método para exibir informações da pessoa
		public virtual string ExibirInformacoes()
		{
			string mensagem = "Nome: " + Nome + " sua idade é: " + Idade +
				" seu telefone é: " + Telefone;

			return mensagem;
		}
	}
}

