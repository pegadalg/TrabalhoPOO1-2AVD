using Instituicao;
using System;

            List<Aluno> alunos = new List<Aluno>();
            List<Disciplina> disciplinas = new List<Disciplina>();
            Nota nota = new Nota();

            while (true)
            {
                Console.WriteLine("\n1. Cadastrar aluno");
                Console.WriteLine("2. Cadastrar disciplina");
                Console.WriteLine("3. Adicionar aluno à disciplina");
                Console.WriteLine("4. Listar alunos de uma disciplina");
                Console.WriteLine("5. Listar disciplinas de um aluno");
                Console.WriteLine("6. Calcular média");
                Console.WriteLine("7. Aprovado/Reprovado");
                Console.WriteLine("8. Aprovado/Reprovado com média variável");
                Console.WriteLine("9. Exibir detalhes da disciplina");
                Console.WriteLine("0. Sair");
                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.Clear();
                        Console.Write("Digite o nome do aluno: ");
                        string nomeAluno = Console.ReadLine();
                        Console.Write("\nDigite a matrícula do aluno: ");
                        int matriculaAluno = int.Parse(Console.ReadLine());

                        if (alunos.Find(aluno => aluno.Matricula == matriculaAluno) != null)
                        {
                            Console.WriteLine("\nJá existe um aluno com essa matrícula.");
                        }
                        else
                        {
                             alunos.Add(new Aluno(nomeAluno, matriculaAluno));
                             Console.WriteLine("\nAluno cadastrado com sucesso!");
                        }
                                 
                        break;

                    case "2":

                        Console.Clear();
                        Console.Write("Digite o nome da disciplina: ");
                        string nomeDisciplina = Console.ReadLine();
                        Console.Write("\nDigite o código da disciplina: ");
                        int codigoDisciplina = int.Parse(Console.ReadLine());                        
                        Console.Write("\nDigite o nome do professor: ");
                        string professor1 = Console.ReadLine();

                            if (disciplinas.Find(disciplina => disciplina.CodigoDisciplina == codigoDisciplina) != null)
                            {
                                Console.WriteLine("\nJá existe uma disciplina com esse código.");
                            }
                            else if (disciplinas.Find(disciplina => disciplina.Nome == nomeDisciplina) != null)
                            {
                                Console.WriteLine("\nJá existe uma disciplina com esse nome.");
                            }
                            else
                            {
                                disciplinas.Add(new Disciplina(nomeDisciplina, codigoDisciplina, new Professor(professor1)));
                                Console.WriteLine("\nDisciplina cadastrada com sucesso!");
                            }

                        break;

                   case "3":

                        Console.Clear();
                        Console.Write("Digite a matrícula ou nome do aluno para adicionar à disciplina: ");
                        string userInput = Console.ReadLine();
                        Console.Write("\nDigite o nome da disciplina para adicionar o aluno: ");
                        string nomeDisciplinaParaAdicionar = Console.ReadLine();
                        int matricula;
                        string nome = null;

                            if (int.TryParse(userInput, out matricula))
                            {
                                matricula = int.Parse(userInput);
                            }
                            else
                            {
                                nome = userInput;
                            }

                        Aluno alunoParaAdicionar = alunos.Find(aluno => aluno.Matricula == matricula || aluno.Nome == nome);

                            if (alunoParaAdicionar != null)
                            {
                                if (matricula != 0)
                                {
                                    Aluno.AdicionarAlunoDisciplina(matricula, nomeDisciplinaParaAdicionar, alunos, disciplinas);
                                }
                                else
                                {
                                    Aluno.AdicionarAlunoDisciplina(nome, nomeDisciplinaParaAdicionar, alunos, disciplinas);
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nAluno não encontrado!");
                            }

                        break;

                    case "4":

                        Console.Clear();
                        Console.Write("Digite o nome da disciplina para listar os alunos: ");
                        string disciplinaParaListar = Console.ReadLine();
                        Disciplina disciplinaEncontrada = disciplinas.Find(d => d.Nome == disciplinaParaListar);

                            if (disciplinaEncontrada != null)
                            {
                                disciplinaEncontrada.ListarAlunos();
                            }
                            else
                            {
                                Console.WriteLine("\nDisciplina não encontrada!");
                            }

                        break;

                    case "5":

                        Console.Clear();
                        Console.Write("Digite a matrícula do aluno para listar disciplinas: ");
                        int matriculaAlunoListar = int.Parse(Console.ReadLine());
                        Aluno alunoListar = alunos.Find(aluno => aluno.Matricula == matriculaAlunoListar);
                        if (alunoListar != null)
                        {
                            Console.WriteLine($"\nDisciplinas do aluno {alunoListar.Nome}:");
                            foreach (var disciplina in alunoListar.Disciplinas)
                            {
                                Console.WriteLine(disciplina.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nAluno não encontrado!");
                        }

                        break;

                    case "6":

                        Console.Clear();
                        Console.WriteLine("Entre com nota 1");
                        float nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nEntre com nota 2");
                        float nota2 = float.Parse(Console.ReadLine());
                        nota.Nota1 = nota1;
                        nota.Nota2 = nota2;
                        nota.CalcularMedia();
                        nota.ExibirMedia();

                    break;

                    case "7":

                        Console.Clear();
                        Console.WriteLine("Entre com nota 1");
                        float nota3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nEntre com nota 2");
                        float nota4 = float.Parse(Console.ReadLine());
                        nota.Nota1 = nota3;
                        nota.Nota2 = nota4;
                        nota.CalcularMedia();

                        Console.WriteLine(nota.Situacao());

                    break;

                    case "8":
                        Console.Clear();        
                        Console.WriteLine("Entre com nota 1");
                        float nota5 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nEntre com nota 2");
                        float nota6 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme qual será média de comparação\n");
                        float valmedia = float.Parse(Console.ReadLine()); 
                        nota.Nota1 = nota5;
                        nota.Nota2 = nota6;
                        nota.CalcularMedia();
                        Console.WriteLine(nota.Situacao(valmedia));

                    break;

                    case "9":

                        Console.Clear();
                        Console.WriteLine("Digite o nome da disciplina que quer receber detalhes:");
                        string nomedisciplina = Console.ReadLine();
                        Disciplina listar = disciplinas.Find(d => d.Nome == nomedisciplina);
                        listar.ExibirDetalhes(nomedisciplina);

                    break;

                    case "0":

                        Console.Clear();    
                        Console.WriteLine("Encerrando o programa...");
                        return;

                    default:

                        Console.Clear();
                        Console.WriteLine("Opção inválida!");

                        break;
                }
            }
        
        
