using aula05;

try
{
    List<Pessoa> listaPessoas = new List<Pessoa>();
    int opcao = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("=== SISTEMA DE CADASTRO ===");
        Console.WriteLine("=== 1 - Cadastrar Aluno ===");
        Console.WriteLine("=== 2 - Cadastrar Professor ===");
        Console.WriteLine("=== 3 - Exibir todos os cadastros ===");
        Console.WriteLine("=== 0 - Sair ===");
        Console.WriteLine("Escolha uma opção: ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out opcao))
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cadastro de Aluno");
                    Console.WriteLine("Digite o nome do aluno:");
                    string nomeAluno = Console.ReadLine();

                    Console.WriteLine("Digite o curso:");
                    string curso = Console.ReadLine();

                    listaPessoas.Add(new Aluno(nomeAluno, curso));

                    Console.WriteLine("\nAluno cadastrado com sucesso!");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Cadastro de Professor");
                    Console.WriteLine("Digite o nome do professor:");
                    string nomeProfessor = Console.ReadLine();

                    Console.WriteLine("Digite a disciplina:");
                    string disciplina = Console.ReadLine();

                    listaPessoas.Add(new Aluno(nomeProfessor, disciplina));

                    Console.WriteLine("\nProfessor cadastrado com sucesso!");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Lista de Cadastros");

                    if (listaPessoas.Count = 0)
                    {
                        Console.WriteLine("\nNenhum cadastro encontrado");
                    }
                    else
                    {
                        foreach (var pessoa in listaPessoas)
                        {
                            pessoa.ExibirInformacoes();
                        }
                    }
                    Console.WriteLine("\nPressione qualquer tecla para sair");
                    Console.ReadKey();
                    break;

            }
        }
    } while (opcao != 0);
}
catch (Exception ex)
{
    Console.Write($"\nErro {ex.Message}");
    Console.ReadKey();
}
