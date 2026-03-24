namespace Course
{

    class Pessoa()
    {
        public string nome;
        public int idade;

        static void Main(string[] args)
        {
            Pessoa p;
            p = new Pessoa();

            Pessoa[] pessoas = new Pessoa[2];

            for (int i = 0; i < 2; i++) { 

                pessoas[i] = new Pessoa();
            
                Console.WriteLine("Registro: " + (i +1) + " ");

                Console.Write("Digite o nome da pessoa: ");
                p.nome = Console.ReadLine();

                Console.Write("Digite a idade da pessoa:");
                p.idade = int.Parse(Console.ReadLine());

                pessoas[i].nome = p.nome;
                pessoas[i].idade = p.idade;
                         
            }

            Console.WriteLine("Pessoas cadastradas: " + pessoas.Length);
            Console.WriteLine("Nome: " + pessoas[0].nome + " " + "Idade: " + pessoas[0].idade);
            Console.WriteLine("Nome: " + pessoas[1].nome + " " + "Idade: " + pessoas[1].idade);

            if (pessoas[0].idade > pessoas[1].idade)
            {
                Console.WriteLine(pessoas[0].nome + " é mais velho que " + pessoas[1].nome);
            }
            else
            {
                Console.WriteLine(pessoas[1].nome + " é mais velho que " + pessoas[0].nome);

            }
        }
    } 

}