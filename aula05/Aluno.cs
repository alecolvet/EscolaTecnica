namespace aula05
{
    class Aluno : Pessoa
    {
        public string Curso { get; set; }

        //Construtor de aluno que repassa o nome para o construtor da classe pai usando a palavra 
        public Aluno(string nome, string curso): base(nome)
        {
            Curso = curso;
        }

        //Método que sobreescreve o metodo herdado da classe base para fornecer uma implementação especifica (polimorfismo)
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[ALUNO]: {Nome}, Curso: {Curso}");
        }
    }
}
