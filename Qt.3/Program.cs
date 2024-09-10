/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
* Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
* Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
* Espada: +10 pontos ao dano total.
* Arco: +5 pontos ao dano total.
* Cajado: +15 pontos ao dano total.
* Exiba o dano total causado pelo ataque crítico.
@Lista: 04 - Funções
@Autor: Brenda Kelly Tavares 
@Data: 09/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tipoArma;
        double ataqueBase, multiplicadorCritico;

        Console.WriteLine("Qual foi o ataque base? ");
        double.TryParse(Console.ReadLine(), out ataqueBase);

        Console.WriteLine("Qual o multiplicador crítico?");
        double.TryParse(Console.ReadLine(), out multiplicadorCritico);

        Console.WriteLine("Qual o tipo de arma (espada, arco ou cajado)? ");
        tipoArma = Console.ReadLine();

        double danoTotal = CalcularDanoCritico(ataqueBase, multiplicadorCritico, tipoArma);
        Console.ReadLine();

        Console.WriteLine("O seu dano crítico foi de: " + danoTotal);
    }

    static double CalcularDanoCritico(double ataqueBase, double multiplicadorCritico, string? tipoArma)
    {
        double danoTotal = 0;

        if (tipoArma == "espada")
        {
            danoTotal = (multiplicadorCritico * ataqueBase) + 10;
            Console.WriteLine($"O dano crítico foi de {danoTotal}");
        }

        else if (tipoArma == "arco")
        {
            danoTotal = (multiplicadorCritico * ataqueBase) + 5;
            Console.WriteLine($"O dano crítico foi de {danoTotal}");
        }

        else if (tipoArma == "cajado")
        {
            danoTotal = (multiplicadorCritico * ataqueBase) + 15;
            Console.WriteLine($"O dano crítico foi de {danoTotal}");
        }

        return danoTotal;
    }
}