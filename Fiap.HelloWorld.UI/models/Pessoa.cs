namespace Fiap.HelloWorld.UI.models
{
    public class Pessoa
    {
        //Atributos

        private string _nome;
        private int _idade;
        public string Cpf { get; set; }

        //Propriedades Getters e Setters
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; } 
        }

        public int Idade { get; set; }

    }

}
