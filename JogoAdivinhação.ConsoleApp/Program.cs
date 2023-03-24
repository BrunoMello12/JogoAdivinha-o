internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************");
        Console.WriteLine("* Bem-vindo(a) ao Jogo da Adivinhação *");
        Console.WriteLine("***************************************");
        Console.WriteLine();
        Console.WriteLine("Escolha o nível de dificuldade: ");
        Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
        Console.WriteLine("Escolha: ");
        int escolha = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random Aleatorio = new Random();
        int NumAleatorio = Aleatorio.Next(0, 20);
        int chute = 0;
        int pontuacao = 1000;
        int calculo = 0;

        switch (escolha)
        {
            case 1:
                for(int i = 1; i <= 15; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 15");
                    Console.WriteLine("-------------------");
                    Console.Write($"Qual o {i} chute: ");
                    chute = int.Parse(Console.ReadLine());
                    calculo = Math.Abs(chute - NumAleatorio); 
                    pontuacao = Math.Abs(pontuacao - (calculo / 2));


                    if (chute == NumAleatorio)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        break;
                    }
                    else if(chute < NumAleatorio)
                    {
                        
                        Console.WriteLine("Seu chute foi menor que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }
                    else if (chute > NumAleatorio)
                    {

                        Console.WriteLine("Seu chute foi maior que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }

                }
                break;
            case 2:
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 10");
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"Qual o {i} chute: ");
                    chute = int.Parse(Console.ReadLine());
                    calculo = Math.Abs(chute - NumAleatorio);
                    pontuacao = Math.Abs(pontuacao - (calculo / 2));

                    if (chute == NumAleatorio)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        break;
                    }
                    else if (chute < NumAleatorio)
                    {

                        Console.WriteLine("Seu chute foi menor que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }
                    else if (chute > NumAleatorio)
                    {

                        Console.WriteLine("Seu chute foi maior que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }

                }
                break;
            case 3:
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 5");
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"Qual o {i} chute: ");
                    chute = int.Parse(Console.ReadLine());
                    calculo = Math.Abs(chute - NumAleatorio);
                    pontuacao = Math.Abs(pontuacao - (calculo / 2));

                    if (chute == NumAleatorio)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        break;
                    }
                    else if (chute < NumAleatorio)
                    {

                        Console.WriteLine("Seu chute foi menor que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }
                    else if (chute > NumAleatorio)
                    {

                        Console.WriteLine("Seu chute foi maior que o número secreto!");
                        Console.WriteLine($"Você fez {pontuacao} pontos!");
                    }

                }
                break;
        }
    }
}