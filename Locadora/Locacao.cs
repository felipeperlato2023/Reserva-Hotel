using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    internal class Locacao
    {
        public string Modelocarro { get; set; }

        public DateTime Datasaida { get; set; }

        public DateTime Dataretorno { get; set; }

        public double Valorhora { get; set; }

        public double Valordiario { get; set; }


        public Locacao()
        {

        }

        public Locacao(string modelocarro, DateTime datasaida, DateTime dataretorno, double valorhora, double valordiario)
        {
            Modelocarro = modelocarro;
            Datasaida = datasaida;
            Dataretorno = dataretorno;
            Valorhora = valorhora;
            Valordiario = valordiario;
        }

        public int Locar()
        {
            TimeSpan duracao = Dataretorno.Subtract(Datasaida);



            return (int)duracao.Hours;

        }


        public override string ToString()
        {
            return " modelo:"
                + Modelocarro
                 + " dataalugel:"
                  + Datasaida.ToString("dd/MM/yyyy ")
                   + " dataretorno:"
                    + Dataretorno.ToString("dd/MM/yyyy ")
                     + Locar()
                      + " horas";

        }
    }
}
