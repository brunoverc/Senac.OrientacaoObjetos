using System;
namespace OrientacaoObjetos
{
	public class Funcionario : Pessoa
	{
        // Propriedades adicionais da classe Funcionario
        //(PRIVADO)
        private string _cargo;
        private decimal _salario;

        //Propriedades públicas
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public decimal Salario
        {
            //Exemplo sempre mostro o salário - 10%
            get { return _salario - (_salario * 0.1M); }
            set { _salario = value; }
        }

        //Construtor
        public Funcionario(string nome,
            DateTime dataNascimento,
            string telefone,
            string cargo,
            decimal salario) : base(nome, dataNascimento, telefone)
        {
            _cargo = cargo;
            _salario = salario;
        }

        // Sobrescrevendo o método para exibir informações do funcionário
        public override string ExibirInformacoes()
        {
            string mensagem = base.ExibirInformacoes();
            mensagem += $"\nCargo: {Cargo}, Salário: {Salario}";
            return mensagem;
        }
    }
}

