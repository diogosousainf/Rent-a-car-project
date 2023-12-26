﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5089
{
    internal class Veiculo
    {
        private static int ultimoId = 0;
        public static int UltimoId => ultimoId;
        public int Id { get; }
        public int NumeroPortas { get; set; }
        public string TipoCaixa { get; set; }
        public int Cilindrada { get; set; }
        public int NumeroEixos { get; set; }
        public int MaxPassageiros { get; set; }
        public int PesoMaximo { get; set; }
        public double ValorAluguerDiario { get; set; }
        public bool StatusAluguer { get; set; }
        public bool StatusManutencao { get; set; }

        public Veiculo(int numeroPortas, string tipoCaixa, int cilindrada, int numeroEixos, int maxPassageiros, int pesoMaximo, double valorAluguerDiario, bool statusAluguer, bool statusManutencao)
        {
            Id = ++ultimoId;
            NumeroPortas = numeroPortas;
            TipoCaixa = tipoCaixa;
            Cilindrada = cilindrada;
            NumeroEixos = numeroEixos;
            MaxPassageiros = maxPassageiros;
            PesoMaximo = pesoMaximo;
            ValorAluguerDiario = valorAluguerDiario;
            StatusAluguer = statusAluguer;
            StatusManutencao = statusManutencao;
        }

        public static void DefinirUltimoId(int id)
        {
            ultimoId = id;
        }

    }
}
