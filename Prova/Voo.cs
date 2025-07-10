using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public abstract class Voo
    {
        int numeroVoo;
        string cidadeOrigem;
        string cidadeDestino;
        string data;
        string horario;
        int totalAssentos;
        int portaoEmbarque;
        double taxaEmbarque;

        public void setTotalAssentos(int totalAssentos)
        {
            if(totalAssentos < 0)
            {
                throw new Exception("O total de assentos informado deve ser maior que zero!");
            }
            else
            {
                this.totalAssentos = totalAssentos;
            }
        }


        public virtual double CalcularTaxa(double taxaEmbarque)
        {
            if (taxaEmbarque < 0)
            {
                throw new Exception("Valor da taxa de embarque invalido");

            }
            else
            {
                return taxaEmbarque;
            }
        }


    }
    public class VooDomestico : Voo
    {

    }
    public class VooInternacional: Voo
    {
       
        public VooInternacional(double taxaEmbarque)
        {
            if (taxaEmbarque < 0)
            {
                throw new Exception("Valor da taxa de embarque invalido");
            }
            else
            {
                CalcularTaxa(taxaEmbarque);
            }
        }
        public override double CalcularTaxa(double taxaEmbarque)
        {
            return Convert.ToDouble(taxaEmbarque * 1.5);
        }

    }
}
