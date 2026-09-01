namespace aula054
{
    //clase abstrata, serve como molde base que não pode ser instanciada
    class Pessoa
    {
        //(campo) privado para armazenar o nome da forma protegida (encapsulamento)
        private string nome;

        //(propriedades) publica para acessar e modificar o campo privado de maneira controlada e segura
        public string Nome
        {
            //retorna o valor armazenado no campo privado
            get { return nome; }
            //define o novo valor para o campo privado
            set { nome = value; }
        }

        //Construtor da classe base para inicializar o atributo nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        //Método virtual (polimorfismo)
        //Define um comportamento padrão passível a sobrescrita
        public virtual void ExibirInfomacoes()
        {
            Console.WriteLine($"Nome: { Nome}");
        }
    }
}
