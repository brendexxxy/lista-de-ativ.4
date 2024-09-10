/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
•
Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da distância até o aliado e do nível de ameaça no caminho.
•
Comando: Crie um programa que receba a energia do jogador, a distância até o aliado (em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine se o resgate é possível com base nas seguintes condições:
•
Energia maior que 50: Resgate bem-sucedido.
•
Distância menor que 20 metros: +10 de energia.
•
Nível de ameaça:
o
Baixo: Sem penalidade.
o
Médio: -10 de energia.
o
Alto: -20 de energia.
•
Exiba se o resgate foi bem-sucedido ou falhou.
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
        string? nivelAmeaca;
        double energiaJogador, distanciaAliado;

        Console.WriteLine("Qual a sua energia inicial? ");
        double.TryParse(Console.ReadLine(), out energiaJogador);

        Console.WriteLine("Qual a distância até o aliado (em metros)?");
        double.TryParse(Console.ReadLine(), out distanciaAliado);

        Console.WriteLine("Qual o nível de ameaça (baixo, médio ou alto)?");
        nivelAmeaca = Console.ReadLine();

        double energiaRestante = CalcularEnergiaRestante(distanciaAliado, energiaJogador, nivelAmeaca);
        Console.ReadLine();

        if (energiaRestante > 50)
        {
            Console.WriteLine("Resgate bem-sucedido.");
        }
        else
        {
            Console.WriteLine("Resgate falhou.");
        }
    }

    static double CalcularEnergiaRestante(double distanciaAliado, double energiaJogador, string? nivelAmeaca)
    {
        double energiaFinal = energiaJogador;

        if (nivelAmeaca == "baixo")
        {
            if (distanciaAliado < 20)
            {
                energiaFinal += 10;
            }
        }
        else if (nivelAmeaca == "medio")
        {
            energiaFinal -= 10;
            if (distanciaAliado < 20)
            {
                energiaFinal += 10;
            }
        }
        else if (nivelAmeaca == "alto")
        {
            energiaFinal -= 20;
            if (distanciaAliado < 20)
            {
                energiaFinal += 10;
            }
        }

        return energiaFinal;
    }
}