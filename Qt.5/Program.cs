/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
•
Contextualização: No jogo, o jogador pode usar habilidades especiais durante a batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de inimigo e da distância do alvo.
•
Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo (Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira qual habilidade usar com base nos seguintes critérios:
•
Mana maior que 50: Use Habilidade Poderosa.
•
Inimigo Forte ou Boss: +10 mana necessária.
•
Distância menor que 10 metros: Reduz a mana necessária em 5.
•
Exiba a habilidade sugerida.
@Lista: 04 - Função
@Autor: Brenda Kelly Tavares 
@Data: 09/09/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipoInimigo;
        double quantidadeMana, distanciaAlvo;

        Console.WriteLine("Qual a sua quantidade de mana? ");
        double.TryParse(Console.ReadLine(), out quantidadeMana);

        Console.WriteLine("Qual a distância até o alvo (em metros)?");
        double.TryParse(Console.ReadLine(), out distanciaAlvo);

        Console.WriteLine("Qual o tipo de inimigo (normal, forte ou boss)?");
        tipoInimigo = Console.ReadLine();

        string habilidadeSugerida = EscolherHabilidade(quantidadeMana, distanciaAlvo, tipoInimigo);
        Console.ReadLine();

        Console.WriteLine("Habilidade sugerida: " + habilidadeSugerida);
    }

    static string EscolherHabilidade(double quantidadeMana, double distanciaAlvo, string? tipoInimigo)
    {
        double manaNecessaria = 50;

        if (tipoInimigo == "forte" || tipoInimigo == "boss")
        {
            manaNecessaria += 10;
        }

        if (distanciaAlvo < 10)
        {
            manaNecessaria -= 5;
        }

        if (quantidadeMana >= manaNecessaria)
        {
            return "Use Habilidade Poderosa";
        }
        else
        {
            return "Use Habilidade Básica";
        }
    }
}