
//Recuperação BACKEND com Gustavo Lima
//Aluno Fernando Fujisawa

using Classes;
string? opcao;
PessoaJuridica metodosPJ = new PessoaJuridica();

do{
    Console.Clear(); //limpa o console

    //exibe o menu
    Console.WriteLine(@" 
    
    1 - CADASTRAR PJ
    2 - LISTAR PJ
    0 - SAIR
    ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": //cadastra pj
            PessoaJuridica pj = new PessoaJuridica();

            Console.WriteLine("Informe o nome da PJ: ");
            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento da PJ: ");
            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o CNPJ da PJ: ");
            pj.CNPJ = Console.ReadLine();

            metodosPJ.Inserir(pj);

            Console.WriteLine("pessoa juridica cadastrada com sucesso!");
            Console.ReadLine();

            break;

        case "2": //lista pessoa juridica
            //pede o nome da PJ
            Console.WriteLine("Digite o nome da PJ: ");
            //salva o nome da PJ que o usuario digitou
            string? nomePJ = Console.ReadLine();
            //usa o metodo ler para obter os dados do arquivo
            PessoaJuridica pjLida = metodosPJ.Ler(nomePJ!); 

            Console.WriteLine($@"
                Nome:{pjLida.Nome}
                Rendimento: R${pjLida.Rendimento},00
                CNPJ: {pjLida.CNPJ}
            ");
            //espera que o usuario digite algum caracter para proseguir
            Console.Read();
            break;
        default:
            break;
    }
    
} while(opcao !="0");
