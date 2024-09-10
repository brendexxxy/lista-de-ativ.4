/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
•
Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar missões. A pontuação é calculada com base na dificuldade da missão, na quantidade de inimigos derrotados e no tempo gasto para completar.
•
Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para calcular a pontuação da missão usando os seguintes critérios:
•
Fácil: 5 pontos por inimigo, sem penalidade de tempo.
•
Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
•
Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
•
Exiba a pontuação final do jogador.
@Lista: 04 - Função
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

        string? dificuldadeMissao;
        int numeroInimigosDerrotados, tempoGasto;

        Console.WriteLine("Escreva o nível de dificuldade (facil, media ou dificil): ");
        dificuldadeMissao = Console.ReadLine();

        Console.WriteLine("Qual o número de inimigos derrotados? ");
        int.TryParse(Console.ReadLine(), out numeroInimigosDerrotados);

        Console.WriteLine("Qual foi o tempo gasto?");
        int.TryParse(Console.ReadLine(), out tempoGasto);

        int pontuacaoFinal = CalcularPontuacao(numeroInimigosDerrotados, tempoGasto, dificuldadeMissao);

        Console.WriteLine("A sua pontuação final é: " + pontuacaoFinal);
    }
    static int CalcularPontuacao(int numeroInimigosDerrotados, int tempoGasto, string? dificuldadeMissao)
    {
        int pontuacao = 0;

        if (dificuldadeMissao == "facil")
        {
            pontuacao = (5 * numeroInimigosDerrotados);
            Console.WriteLine($"Você ganhou {pontuacao} pontos.");
        }

        if (dificuldadeMissao == "media")
        {
            int penalidadeTempo = (tempoGasto - 10) * 2;

            pontuacao = (10 * numeroInimigosDerrotados) - penalidadeTempo;
            Console.WriteLine($"Você ganhou {pontuacao} pontos.");
        }

        if (dificuldadeMissao == "dificil")
        {
            int penalidadeTempo = (tempoGasto - 15) * 5;

            pontuacao = (15 * numeroInimigosDerrotados) - penalidadeTempo;
            Console.WriteLine($"Você ganhou {pontuacao} pontos.");
        }

        return pontuacao;
    }
}