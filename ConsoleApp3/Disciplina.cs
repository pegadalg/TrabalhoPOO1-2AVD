namespace Instituicao
{
    public class Disciplina
    {
        // Propriedades
        public string Nome { get; set; }

        public int CodigoDisciplina { get; set; }
        
        public Professor ProfessorResponsavel { get; set; }
        // Lista de alunos
        public List<Aluno> Alunos { get; set; }
        // Construtor
        public Disciplina(string nome, int codigoDisciplina, Professor professor )
        {
            Nome = nome;
            Alunos = new List<Aluno>();
            CodigoDisciplina = codigoDisciplina;
            ProfessorResponsavel = professor;
        }
        // Método para adicionar aluno
        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.Disciplinas.Add(this);
        }
        // Método para listar alunos
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos da Disciplina {Nome}:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(" - " + aluno.Nome);
            }
        }
        // Método para exibir detalhes da disciplina
        public void ExibirDetalhes(string nomeDisciplina)
        {

            if (Nome.ToLower() == nomeDisciplina.ToLower())
            {
                Console.WriteLine($"\nNome da Disciplina {Nome}");
                Console.WriteLine($"Código da Disciplina: {CodigoDisciplina}");
                Console.WriteLine($"Professor Responsável: {ProfessorResponsavel.Nome}\n");
                ListarAlunos();
            }
            else
            {
                Console.WriteLine($"A disciplina {nomeDisciplina} não foi encontrada.");
            }
        }
       


    }
}


