using OrientacaoObjetos;

/*
//Instanciando objeto da classe Pessoa
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Telefone = "(64)9999-9999";
pessoa1.Idade = 35;

//Instanciar outro objeto da classe Pessoa
Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Telefone = "(64)8888-8888";
pessoa2.Idade = 28;

Console.WriteLine("Dados da Pessoa 1: ");
Console.WriteLine(pessoa1.ExibirInformacoes());

Console.WriteLine("Dados da Pessoa 2:");
Console.WriteLine(pessoa2.ExibirInformacoes());

Console.ReadLine();
//Neste exemplo, a classe Pessoa possui duas propriedades: Nome,
//Idade e Telefone.
//Além disso, ela tem um método chamado ExibirInformacoes() que
//imprime no console as informações da pessoa.
*/

Estudante estudante1 = new Estudante(
    nome: "Carlos",
    dataNascimento: new DateTime(1989, 01, 17),
    telefone: "(64)9999-9999",
    matricula: "0101");

Console.WriteLine("Informações do Estudante 1:");
Console.WriteLine(estudante1.ExibirInformacoes());

Professor professor1 = new Professor(nome: "Diana",
    dataNascimento: new DateTime(1970, 01, 01),
    telefone: "(64)1111-1111",
    cargo: "Professor",
    salario: 3000,
    disciplina: "Programação de sistemas");


Console.WriteLine("\n\nInformações do Professor 1:");
Console.WriteLine(professor1.ExibirInformacoes());

Funcionario funcionario1 = new Funcionario(
    nome: "José",
    dataNascimento: new DateTime(1996, 02, 02),
    telefone: "(64)2222-2222",
    cargo: "Desenvolvedor",
    salario: 5000);

Console.WriteLine("\n\nInformações do Funcionário 1:");
Console.WriteLine(funcionario1.ExibirInformacoes());

Console.ReadLine();

/*
 * Neste exemplo, a classe Pessoa serve como a classe 
 * base. As classes Estudante e Professor herdam da 
 * classe Pessoa e adicionam suas próprias propriedades 
 * específicas (Matricula e Disciplina, respectivamente).
 * Além disso, os métodos ExibirInformacoes() nas classes
 * derivadas foram sobrescritos para incluir informações 
 * específicas dessas classes.
 * 
 * 
 * Neste exemplo, as propriedades nas classes foram tornadas 
 * privadas, e os métodos de acesso (get e set) foram utilizados 
 * para controlar o acesso a essas propriedades. Os construtores 
 * também foram adicionados para facilitar a inicialização dos 
 * objetos. Isso melhora o encapsulamento e torna o código mais coeso,
 * seguindo as boas práticas de programação orientada a objetos.
*/
