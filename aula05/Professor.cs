namespace aula05
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor(string nome, string disciplina) : base(nome)
        {
            Disciplina = disciplina;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[PROFESSOR]: {Nome}, Disciplina: {Disciplina}");
        }
    }
}
