using System;
namespace OrientacaoObjetos
{
	public class Professor : Funcionario
	{
        //Propriedade privada
        private string _disciplina;

        //Propriedade pública
        public String Disciplina
        {
            get { return _disciplina; }
            set { _disciplina = value; }
        }

        //Construtor
        public Professor(string nome,
            DateTime dataNascimento,
            string telefone,
            string cargo,
            decimal salario,
            string disciplina) : base(nome,
                                    dataNascimento,
                                    telefone,
                                    cargo,
                                    salario)
        {
            _disciplina = disciplina;
        }

        public override string ExibirInformacoes()
        {
            string mensagem = base.ExibirInformacoes();
            mensagem = mensagem + "\nDisciplina: " + Disciplina;

            return mensagem;
        }
    }
}

