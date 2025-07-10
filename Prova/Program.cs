
using Prova;





do
{
    Console.WriteLine("----------------MENU------------------");
    Console.WriteLine("1. Cadastrar Voo");
    Console.WriteLine("2. Cadastrar Passageiro");
    Console.WriteLine("3. Cadastrar Reserva");
    Console.WriteLine("4. Sair");
    Console.Write("5. Escolha uma Opção:");
    int escolha = Convert.ToInt32(Console.ReadLine());
    if (escolha == 1)
    {
        VooDomestico voo = new VooDomestico();

        int numeroVoo;
        string cidadeOrigem;
        string cidadeDestino;
        string data;
        string horario;
        int totalAssentos;
        int portaoEmbarque;
        double taxaEmbarque;
        Console.Clear();
        Console.WriteLine("----------------Cadastrar Voo------------------");
        Console.Write("Numero do Voo:");
        numeroVoo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nome do Cidade de Origem:");
        cidadeOrigem = Console.ReadLine();
        Console.Write("Nome do Cidade de Destino:");
        cidadeDestino = Console.ReadLine();
        Console.Write("Data do Voo:");
        data = Console.ReadLine();
        Console.Write("Horario do Voo:");
        horario = Console.ReadLine();
        Console.Write("Quantidade de Assentos:");
        totalAssentos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Portão de Emabarque:");
        portaoEmbarque = Convert.ToInt32(Console.ReadLine());
        Console.Write("Taxa de Emabarque:");
        taxaEmbarque = Convert.ToInt32(Console.ReadLine());


    }
    else if (escolha == 2)
    {

        Console.Clear();
        Console.WriteLine("----------------Cadastrar Passageiro------------------");
        Console.WriteLine("Nome Passageiro:");
        string nome = Console.ReadLine();
        Console.WriteLine("CPF Passageiro:");
        string cpf = Console.ReadLine();
        Console.WriteLine("Data Nascimento Passageiro:");
        string datanasicmento = Console.ReadLine();
        Console.WriteLine("Email Passageiro:");
        string email = Console.ReadLine();
        Console.WriteLine("Telefone Passageiro:");
        string telefone = Console.ReadLine();
        Passageiro passageiro = new Passageiro(nome, cpf, datanasicmento, email, telefone);


    }
    else if (escolha == 3)
    {



        Console.Clear();
        Console.WriteLine("----------------Cadastrar Reserva------------------");
        Console.WriteLine("Nome Passageiro:");
        string nome = Console.ReadLine();
        Console.WriteLine("Numero Voo:");
        string voo = Console.ReadLine();
        Console.WriteLine("Numero Assento:");
        int numeroAssento = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor Passagem:");
        double valorPassagem = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Status Reserva:");
        string status = Console.ReadLine();
        Console.WriteLine("Classe Reserva:");
        string classe = Console.ReadLine();
        Reserva reserva = new Reserva(nome, voo, numeroAssento, valorPassagem, status, classe);

    }
    else
    {
        break;
    }

} while(true);