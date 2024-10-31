using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome:"Lucas",sobrenome: "Balduino");
Pessoa p2 = new Pessoa(nome: "Rogerio",sobrenome: "Fernandes");



Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();

 


























// Pessoa p1 = new Pessoa();

// p1.Nome = "Lucas";
// p1.Sobrenome = "Balduino";
// p1.Idade = 20;

// p1.Apresentar();