using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoJogoCalc.ProjetoJogoCalc;

namespace ProjetoJogoCalc
{
    public static class EstadoJogo
    {
        // Dinheiro do jogador
        public static decimal Dinheiro { get; set; } = 0;

        // Recompensa fixa por questão
        public const decimal RecompensaPorQuestao = 10;

        // Controle de progressão
        public static int EtapaAtual = 0;
        public static int EquacaoAtual = 0;

        // Teclas inicialmente desbloqueadas
        public static HashSet<string> TeclasDesbloqueadas =
            new HashSet<string>
            {
            "4", "3", "2", "1", "DEL", "AC", "="
            };

        // Questões organizadas por etapa
        public static List<Etapa> Etapas = new List<Etapa>
        {
        // ETAPA 1 - FÁCIL
        new Etapa
         {
            Nome = "Fácil",
            Equacoes = new List<Equacao>
            {
                new Equacao { Enunciado = "15 + 20 = ?", Resposta = 35 },
                new Equacao { Enunciado = "50 - 18 = ?", Resposta = 32 },
                new Equacao { Enunciado = "27 + 42 = ?", Resposta = 69 },
                new Equacao { Enunciado = "80 - 35 = ?", Resposta = 45 }
            }
         },

        // ETAPA 2 - MÉDIO
        new Etapa
            {
            Nome = "Médio",
            Equacoes = new List<Equacao>
                {
                new Equacao { Enunciado = "5 × 6 = ?", Resposta = 30 },
                new Equacao { Enunciado = "72 ÷ 8 = ?", Resposta = 9 },
                new Equacao { Enunciado = "12 × 7 = ?", Resposta = 84 },
                new Equacao { Enunciado = "144 ÷ 12 = ?", Resposta = 12 }
                }
            },

        // ETAPA 3 - DIFÍCIL
        new Etapa
            {
            Nome = "Difícil",
            Equacoes = new List<Equacao>
                {
                new Equacao { Enunciado = "15 + 8 × 3 = ?", Resposta = 39 },
                new Equacao { Enunciado = "(120 - 40) ÷ 4 = ?", Resposta = 20 },
                new Equacao { Enunciado = "25,5 + 14,5 × 2 = ?", Resposta = 54 },
                new Equacao { Enunciado = "100 - (12 × 5) = ?", Resposta = 40 },
                new Equacao { Enunciado = "(48 ÷ 6) + 37 = ?", Resposta = 45 },
                new Equacao { Enunciado = "200 ÷ (5 × 4) = ?", Resposta = 10 }
                }
            }
        };
    }
}
