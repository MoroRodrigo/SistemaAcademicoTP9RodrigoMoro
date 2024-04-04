using SistemaAcademicoTP9RodrigoMoro.Model;

class Program
{
    static void Main(string[] args)
    {
        // Criando objetos
        List<Aluno> alunos = new List<Aluno>();
        List<Turma> turmas = new List<Turma>();
        List<Professor> professores = new List<Professor>();
        List<Disciplina> disciplinas = new List<Disciplina>();

        Aluno aluno1 = new Aluno { Matricula = 1, Nome = "João" };
        Aluno aluno2 = new Aluno { Matricula = 2, Nome = "Maria" };

        Professor professor = new Professor { Matricula = 101, Nome = "Prof. Silva" };

        Disciplina disciplina = new Disciplina { Codigo = 1001, Nome = "Matemática" };

        Turma turma = new Turma
        {
            Codigo = 5001,
            Professor = professor,
            Disciplina = disciplina
        };

        // Adicionando objetos às listas
        alunos.Add(aluno1);
        alunos.Add(aluno2);
        professores.Add(professor);
        disciplinas.Add(disciplina);
        turmas.Add(turma);

        // Matriculando alunos na turma
        Console.WriteLine(aluno1.AddTurma(turma)); // Deve exibir "Aluno matriculado na turma com sucesso."
        Console.WriteLine(aluno2.AddTurma(turma)); // Deve exibir "Aluno matriculado na turma com sucesso."

        // Exibindo turmas dos alunos
        Console.WriteLine(aluno1.ExibirTurmas()); // Deve exibir "Turmas do aluno João:\n5001 - Matemática"
        Console.WriteLine(aluno2.ExibirTurmas()); // Deve exibir "Turmas do aluno Maria:\n5001 - Matemática"
    }
}