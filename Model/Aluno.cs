using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoTP9RodrigoMoro.Model
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; } = new List<Turma>();

        public string AddTurma(Turma turma)
        {
            if (Turmas.Contains(turma))
            {
                return "O aluno já está matriculado nesta turma.";
            }

            if (turma.AddAluno(this))
            {
                Turmas.Add(turma);
                return "Aluno matriculado na turma com sucesso.";
            }
            else
            {
                return "Não foi possível matricular o aluno na turma.";
            }
        }

        public string ExibirTurmas()
        {
            string turmas = "Turmas do aluno " + Nome + ":\n";
            foreach (Turma turma in Turmas)
            {
                turmas += turma.Codigo + " - " + turma.Disciplina.Nome + "\n";
            }
            return turmas;
        }
    }

}
