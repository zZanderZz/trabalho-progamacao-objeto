using System;
using System.Collections.Generic;
using TRABALHOANDER;
class Program
{
    static List<Cliente> clientesCadastrados = new List<Cliente>();
    static List<Vendedor> vendedoresCadastrados = new List<Vendedor>();
    static List<Gerente> gerentesCadastrados = new List<Gerente>();
    static List<Produto> produtosCadastrados = new List<Produto>();
    static List<Venda> vendasCadastradas = new List<Venda>();

    static void Main(string[] args)

    //==============================================================================================
    {
        int selectedOption;

        Console.Clear();
        Console.WriteLine("                 Inicio!               ");
        Console.Write("\n\n");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("         Iniciando Sistema!!           ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n\n");
        Console.WriteLine("      Aperte enter para continuar     ");
        Console.ReadLine();

        do{

            Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("           Menu Principal!!            ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("1 - Cadastros");
        Console.WriteLine("2 - Vendas");
        Console.WriteLine("3 - Relatorios");
        Console.WriteLine("0 - Sair");

//=========================================================================================================   

            selectedOption = int.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    TelaCadastros();
                    break;
                case 2:
                    Venda();
                    break;
                case 3:
                    TelaRelatorios();
                    break;
                default:
                    break;
            }
        } while (selectedOption != 0);
    }
//=========================================================================================================
    public static void TelaCadastros(){
        int cadselectedOption;

        do
        {

        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("              CADASTRO                 ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("1 - Exibir cadastro do Cliente");
        Console.WriteLine("2 - Exibir Cadastro do Vendedor");
        Console.WriteLine("3 - Exibir Cadastro do Gerente");
        Console.WriteLine("4 - Exibir Cadastro do Produto");
        Console.WriteLine("0 - Voltar");

        cadselectedOption = int.Parse(Console.ReadLine());

        switch (cadselectedOption)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    CadastrarFuncionario(1);
                    break;
                case 3:
                    CadastrarFuncionario(2);
                    break;
                case 4:
                    CadastrarProduto();
                    break;
                default:
                    break;
            }
        } while (cadselectedOption != 0);
        
    }
//=========================================================================================================

    public static void TelaRelatorios(){
        int relatselectedOption;

        do
        {

        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("              RELATORIOS               ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("1 - Exibir a lista de Clientes");
        Console.WriteLine("2 - Exibir a Lista de produtos");
        Console.WriteLine("3 - Exibir a Lista de vendas");
        Console.WriteLine("4 - Exibir a Lista de vendedores");
        Console.WriteLine("5 - Exibir gerentes cadastrados");
        Console.WriteLine("0 - Retornar");

        relatselectedOption = int.Parse(Console.ReadLine());

        switch (relatselectedOption)
            {
                case 1:
                    ListaClientes();
                    break;
                case 2:
                    ListaProdutos();
                    break;
                case 3:
                    ListaVendas();
                    break;
                case 4:
                    ListaVendedores();
                    break;
                case 5:
                    ListaGerentes();
                    break;
                default:
                    break;
            }
        } while (relatselectedOption != 0);
        
    }
//=========================================================================================================
    public static void CadastrarCliente(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          CADASTRO CLIENTE             ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");

        Cliente cliente = new Cliente();
        cliente.DadosEssenciaisBase();
        clientesCadastrados.Add(cliente);
        Console.Write("Cadastro concluido!!");
    }
//=========================================================================================================
    public static void CadastrarFuncionario(int operacao){
        Console.Clear();
        if(operacao == 2){
            Gerente gerente = new Gerente();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          CADASTRO GERENTE             ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
            Console.Write("\n\n");
            gerente.DadosSalario();
            gerente.CalculaSalarioGerente();
            gerentesCadastrados.Add(gerente);
            Console.Write("Vendedor foi cadastrado!");
        } else {
            Vendedor vendedor = new Vendedor();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          CADASTRAR VENDEDOR           ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
            Console.Write("\n\n");
            vendedor.DadosSalario();
            vendedor.CalculaSalarioVendedor();
            vendedoresCadastrados.Add(vendedor);
            Console.Write("Gerente cadastrado com sucesso!");
        }
    }
//===========================================================================================================
    public static void CadastrarProduto(){
        Console.Clear();
        Produto produto = new Produto();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          CADASTRAR PRODUTO            ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        produto.DadosProdutos();
        produtosCadastrados.Add(produto);
        Console.Write("Produto Cadastrado!!");
        Console.ReadKey();
    }
//=========================================================================================================
    public static void Venda(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("                 VENDA                 ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");

        string cpf;
        string nomeVendedor;
        string codProduto;
        int quantidade;

        Venda venda = new Venda();

        Console.WriteLine("Digite o CPF do cliente: ");
        cpf = Console.ReadLine();
        Cliente a = new Cliente();
        foreach (Cliente cliente in clientesCadastrados)
        {
            if(cliente.GetCpf() == cpf){
                a = cliente;
                break;
            }
        }
        venda.SetCliente(a);

        Console.WriteLine("Digite o nome do vendedor: ");
        nomeVendedor = Console.ReadLine();
        Vendedor b = new Vendedor();
        foreach (Vendedor vendedor in vendedoresCadastrados)
        {
            if(vendedor.GetNome() == nomeVendedor){
                b = vendedor;
                break;
            }
        }
        venda.SetVendedor(b);

        Console.WriteLine("Digite o codigo do produto: ");
        codProduto = Console.ReadLine();
        Produto c = new Produto();
        foreach (Produto produto in produtosCadastrados)
        {
            if(produto.GetCodigo() == codProduto){
                c = produto;
                break;
            }
        }
        venda.SetProduto(c);

        Console.WriteLine("Digite a quantidade: ");
        quantidade = int.Parse(Console.ReadLine());

        double valorUnitario = c.GetValorUnitario();
        double valorTotal = ((c.GetValorUnitario()) * quantidade);

        Console.WriteLine("Valor Unitario: R$ " + valorUnitario);
        Console.WriteLine("Valor Total: R$ " + valorTotal);

        Console.Write("Aperte enter para confirmar a venda!");
        Console.ReadLine();
        vendasCadastradas.Add(venda);
        Console.Write("Venda Concluida!");
        Console.ReadLine();

    }
//=========================================================================================================
    public static void ListaClientes(){

        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          LISTA DE CLIENTES            ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("|    Código     |     Nome      |     CPF      |  Nascimento  |");
        Console.Write("\n\n");

        foreach (Cliente cliente in clientesCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", cliente.GetCodigo(), cliente.GetNome(), cliente.GetCpf(), cliente.GetDataNascimento()));
        }

        Console.ReadLine();

    }
//=========================================================================================================
    public static void ListaVendedores(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          LISTA DE VENDEDORES          ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("|     Nome     |     CPF      |  Nascimento  |   Salário   |");
        Console.Write("\n\n");

        foreach (Vendedor vendedor in vendedoresCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", vendedor.GetNome(), vendedor.GetCpf(), vendedor.GetDataNascimento(), vendedor.GetSalario()));
        }

        Console.ReadLine();
        
    }
//=========================================================================================================
    public static void ListaVendas(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("            LISTA DE VENDAS            ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("|   Cliente   |    Vendedor    |   Produto   |");
        Console.Write("\n\n");

        foreach (Venda venda in vendasCadastradas)
        {
            Console.WriteLine(String.Format("{0} {1} {2}", venda.GetCliente().GetNome(), venda.GetVendedor().GetNome(), venda.GetProduto().GetDescricao()));
        }

        Console.ReadLine();
        
    }
//=========================================================================================================
    public static void ListaGerentes(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("          LISTA DE GERENTES            ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("|     Nome     |     CPF      |  Nascimento  |   Salário   |");
        Console.Write("\n\n");

        foreach (Gerente gerente in gerentesCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", gerente.GetNome(), gerente.GetCpf(), gerente.GetDataNascimento(), gerente.GetSalario()));
        }

        Console.ReadLine();
        
    }
//=========================================================================================================
    public static void ListaProdutos(){
        Console.Clear();
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("           LISTA DE PRODUTOS           ");
        Console.WriteLine("<------------------------------------->");
        Console.WriteLine("<------------------------------------->");
        Console.Write("\n\n");
        Console.WriteLine("|    Código     |   Fabricante   |     Descricao     |  Valor Unitário  |");
        Console.Write("\n\n");

        foreach (Produto produto in produtosCadastrados)
        {
            Console.WriteLine(String.Format("{0} {1} {2} {3}", produto.GetCodigo(), produto.GetMarca(), produto.GetDescricao(), produto.GetValorUnitario()));
        }

        Console.ReadLine();
    }
}



























//ANDER E JHONY