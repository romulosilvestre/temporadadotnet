/* Iniciamos o código chamando um namespace*/
using System;
/*Na sequência declaramos uma classe pública*/
class Program
{
    /*Dentro da classe declaramos um método estático*/
    /*O método Main é o ponto de entrada do programa*/
    static void Main()
    {
        /*Aqui chamamos o método DesenharArvore*/
        DesenharArvore();
    }
    /*Aqui declaramos um método estático que não retorna nada*/
    /*O método DesenharArvore desenha uma árvore de Natal*/
    static void DesenharArvore()
    {
        /*Aqui chamamos o método WriteLine da classe Console*/
        /*O método WriteLine escreve uma linha no console*/
        Console.WriteLine("Vamos desenhar uma árvore de Natal!");
        // Desenhando a árvore    
        /*Aqui chamamos o método ForegroundColor da classe Console*/
        /*O método ForegroundColor define a cor do texto no console*/
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("     *");   
        /*Aqui chamamos o método ForegroundColor da classe Console*/
        /*O método ForegroundColor define a cor do texto no console*/    
        Console.ForegroundColor = ConsoleColor.Green;
        /*Aqui chamamos o método Write da classe Console*/
        /*O método Write escreve um texto no console*/
        /*A diferença entre o método Write e o método WriteLine é que o método Write não pula linha*/
        Console.Write("    *");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*");
        /*Aqui chamamos o método ResetColor da classe Console*/
        /*O método ResetColor reseta a cor do texto no console para a cor padrão*/
        Console.ResetColor();
        Console.WriteLine("   *****");
        Console.WriteLine("  *******");   
        Console.WriteLine("    ***");
    
    }
}

