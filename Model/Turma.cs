using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoTP9RodrigoMoro.Model
{
    public class Turma
    {
        public int Codigo { get; set; }
        public List<Aluno> Alunos { get; } = new List<Aluno>();
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
        public bool Aberta { get; set; }

        public bool AddAluno(Aluno aluno)
        {
            if (Alunos.Count >= 10)
            {
                return false;
            }
            Alunos.Add(aluno);
            return true;
        }

        public bool AbrirTurma()
        {
            if (Alunos.Count >= 2 && Alunos.Count <= 10 && Professor != null && Disciplina != null)
            {
                Aberta = true;
                return true;
            }
            return false;
        }

        public string GerarPauta()
        {
            // Implementação para gerar pauta da turma
            return "Pauta gerada.";
        }
    }
}
