using ExemploExplorando.Models;


// UTILIZANDO O CONSTRUTOR PARA INFORMAR NOME E SOBRENOME LOGO NA INSTANCIAÇÃO
Pessoa p1 = new Pessoa(nome: "Matheus" ,sobrenome: "Chiarello");

// UTILIZANDO O CONSTRUTOR PADRÃO E PASSANDO OS VALORES APENAS DEPOIS...
Pessoa p2 = new Pessoa();
p2.Nome = "leonardo";
p2.Sobrenome = "ramos";

Curso CursoDeIngles = new Curso();
CursoDeIngles.NomeCurso = "Inglês Básico";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();
