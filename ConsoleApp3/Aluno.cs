namespace Instituicao
{
    //exemplo de abstração
    public class Aluno : Pessoa
    {
        // Propriedades 
        public int Matricula { get; set; }
        // Lista de disciplinas
        public List<Disciplina> Disciplinas { get; set; }
        // Construtor
        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Disciplinas = new List<Disciplina>();
        }
        // Método para adicionar disciplina
        public static void AdicionarAlunoDisciplina(int matriculaAluno, string nomeDisciplina, List<Aluno> alunos, List<Disciplina> disciplinas)
        {
            Aluno alunoParaAdicionar = alunos.Find(aluno => aluno.Matricula == matriculaAluno);
            if (alunoParaAdicionar != null)
            {
                Disciplina disciplinaParaAdicionar = disciplinas.Find(disciplina => disciplina.Nome == nomeDisciplina);
                if (disciplinaParaAdicionar != null)
                {
                    disciplinaParaAdicionar.AdicionarAluno(alunoParaAdicionar);
                    Console.WriteLine($"Aluno '{alunoParaAdicionar.Nome}', de matricula '{alunoParaAdicionar.Matricula}' adicionado à disciplina '{disciplinaParaAdicionar.Nome}' com sucesso!");
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada!");
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }
        // Método para adicionar disciplina com sobrecarga
        public static void AdicionarAlunoDisciplina(string nomeAluno, string nomeDisciplina, List<Aluno> alunos, List<Disciplina> disciplinas)
        {
            Aluno alunoParaAdicionar = alunos.Find(aluno => aluno.Nome == nomeAluno);
            if (alunoParaAdicionar != null)
            {
                Disciplina disciplinaParaAdicionar = disciplinas.Find(disciplina => disciplina.Nome == nomeDisciplina);
                if (disciplinaParaAdicionar != null)
                {
                    disciplinaParaAdicionar.AdicionarAluno(alunoParaAdicionar);
                    Console.WriteLine($"Aluno '{alunoParaAdicionar.Nome}', de matricula '{alunoParaAdicionar.Matricula}' adicionado à disciplina '{disciplinaParaAdicionar.Nome}' com sucesso!");
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada!");
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

    }
}
