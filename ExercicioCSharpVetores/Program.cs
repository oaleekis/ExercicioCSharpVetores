namespace ExercicioCSharpVetores
{
    class Program
    {
        public static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}: ");

                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{i}: {vetor[i]}");
                }
            }
        }
    }
}