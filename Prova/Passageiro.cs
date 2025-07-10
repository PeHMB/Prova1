using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Passageiro
    {
        int id;
        string nome;
        string cpf;
        string dataNascimento;
        string email;
        string telefone;

        public Passageiro(string nome, string cpf, string dataNascimento, string email, string telefone)
        {
            this.nome = nome;
            if(cpf.Length<=11)
            {
                this.cpf = cpf;

            }
            else
            {
                throw new Exception("Cpf Invalido");
            }
                this.telefone = telefone;
            this.email = email;
            this.dataNascimento = dataNascimento;


        }

        public Passageiro()
        {

        }
    }

        


    }




