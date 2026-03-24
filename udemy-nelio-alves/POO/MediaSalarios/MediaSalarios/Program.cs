namespace Course
{
    class Funcionario()
    {
        public string nome;
        public double salario;

        static void Main(string[] args){

            Funcionario funcionario;
            funcionario = new Funcionario();

            Funcionario[] listaFuncionarios = new Funcionario[2];

            for (int i = 0; i<2; i++) {

                listaFuncionarios[i] = new Funcionario();

                Console.WriteLine("Registro de funcionários: " + (i + 1));

                Console.Write("Nome: ");
                funcionario.nome = Console.ReadLine();

                Console.Write("Salário: ");
                funcionario.salario = double.Parse(Console.ReadLine());

                listaFuncionarios[i].nome = funcionario.nome;
                listaFuncionarios[i].salario = funcionario.salario;
            }

            Console.WriteLine("Funcionários cadastrados: " + listaFuncionarios.Length);
            Console.WriteLine("Nome: " + listaFuncionarios[0].nome + " " + "Salário: " + "R$ "+  listaFuncionarios[0].salario);
            Console.WriteLine("Nome: " + listaFuncionarios[1].nome + " " + "Salário: " + "R$ " + listaFuncionarios[1].salario);

            double mediaSalario = ((listaFuncionarios[0].salario) + (listaFuncionarios[1].salario)) / 2;

            Console.WriteLine("Média Salarial: " + mediaSalario);


        }

    }

}