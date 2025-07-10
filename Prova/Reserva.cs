using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Reserva
    {
        string passageiro;
        string voo;
        int numeroAssento;
        double valorDaPassagem;
        string status;
        string classe;


        public Reserva(string passageiro, string voo, int numeroAssento, double valorPassagem, string status, string classe)
        {
            this.passageiro = passageiro;
            this.voo = voo;
            this.numeroAssento = numeroAssento;
            if (valorDaPassagem < 1)
            {
                throw new Exception("Valor da passagem Invalido");
            }
            else
            {
                this.valorDaPassagem = valorDaPassagem;
            }
            this.status = status;
            this.classe = classe;

        }

    }
}
