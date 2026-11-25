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
        public static bool ConquistaColecionador { get; set; } = false;
        // Dinheiro do jogador
        public static decimal Dinheiro { get; set; } = 0;

        // Recompensa fixa por questão
        public const decimal RecompensaPorQuestao = 13;

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
            new Equacao { Enunciado = "8 + 4 = ?", Resposta = 12 },
            new Equacao { Enunciado = "40 - 15 = ?", Resposta = 25 },
            new Equacao { Enunciado = "8 + 7 = ?", Resposta = 15 },
            new Equacao { Enunciado = "30 + 37 = ?", Resposta = 67 }
        }
    },

    // ETAPA 2 - MÉDIO
    new Etapa
    {
        Nome = "Médio",
        Equacoes = new List<Equacao>
        {
            new Equacao { Enunciado = "6 × 7 = ?", Resposta = 42 },
            new Equacao { Enunciado = "6 × 8 = ?", Resposta = 48 },
            new Equacao { Enunciado = "8 × 10 = ?", Resposta = 80 },
            new Equacao { Enunciado = "9 × 10 = ?", Resposta = 90 }
        }
    },

    // ETAPA 3 - DIFÍCIL
    new Etapa
    {
        Nome = "Difícil",
        Equacoes = new List<Equacao>
        {
            new Equacao { Enunciado = "9 × 9 = ?", Resposta = 81 },
            new Equacao { Enunciado = "48 + 17 = ?", Resposta = 65 },
            new Equacao { Enunciado = "8 × 9 = ?", Resposta = 72 },
            new Equacao { Enunciado = "25 ÷ 2 = ?", Resposta = 12.5m },
            new Equacao { Enunciado = "144 ÷ 8 = ?", Resposta = 18 },
            new Equacao { Enunciado = "125 - 37 = ?", Resposta = 88 }
        }
    }
        };
    }
}
