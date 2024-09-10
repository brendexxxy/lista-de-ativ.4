/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
* Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
* Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
* Poção Pequena: 10 pontos de vida por poção.
* Poção Média: 20 pontos de vida por poção.
* Poção Grande: 30 pontos de vida por poção.
* Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
* Exiba o total de vida recuperada.
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
        string? tipoPocao;
        int nivelPersonagem = 0, quantidadePocoes = 0;
        Console.ReadLine();
        Console.WriteLine("Qual o tipo da poção?");
        tipoPocao = Console.ReadLine();
        Console.WriteLine("Qual o nível do seu personagem?");
        int.TryParse(Console.ReadLine(), out nivelPersonagem);
        Console.WriteLine("Quantidade de poções usadas?");
        int.TryParse(Console.ReadLine(), out quantidadePocoes);
        int vidaRecuperada = CalcularCura(nivelPersonagem, quantidadePocoes, tipoPocao);
        Console.WriteLine($"Você curou {vidaRecuperada} pontos de vida.");
    }

    static int CalcularCura(int nivelPersonagem, int quantidadePocoes, string? tipoPocao)
    {
        int bonusNivel, totalCura = 0;
        if (nivelPersonagem > 5)
        {
            bonusNivel = (nivelPersonagem - 5) * 5;

            if (tipoPocao == "pequena")
            {
                totalCura = (quantidadePocoes * 10) + bonusNivel;
            }
            else if (tipoPocao == "media")
            {
                totalCura = (quantidadePocoes * 20) + bonusNivel;
            }
            else if (tipoPocao == "grande")
            {
                totalCura = (quantidadePocoes * 30) + bonusNivel;
            }
        }
        return totalCura;
    }
}