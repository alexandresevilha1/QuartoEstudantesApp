

using QuartoEstudantesApp;

Console.WriteLine("Quantos quartos vão ser alugados?");
int n = int.Parse(Console.ReadLine());

Estudante[] estudantes = new Estudante[n];
Quarto[] quartos = new Quarto[10];

for (int i = 0; i < n; i++)
{
    Console.WriteLine(i+1 + "° Quarto:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Numero do quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    estudantes[i] = new Estudante( nome, email );
    quartos[quarto] = new Quarto(quarto, nome, email);
}

for (int i = 0;i < 10;i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine(quartos[i]);
    }
}
