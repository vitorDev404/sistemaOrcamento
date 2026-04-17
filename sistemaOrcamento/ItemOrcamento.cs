using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaOrcamento
{
        public class ItemOrcamento
        {
            public string Material { get; set; }
            public string Maquina { get; set; }
            public double Largura { get; set; }
            public double Comprimento { get; set; }
            public double M2 { get; set; }
            public int Quantidade { get; set; }
            public double Valor { get; set; }
        }
    }
