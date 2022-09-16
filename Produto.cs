namespace TRABALHOANDER{
   
    public class Produto{
        private string codigo = "";
        public string marca = "";
        public string descricao = "";
        public double valorUnitario;
        public string produto = "";
    
       

        public Produto(){
        }
         public Produto(string codigo, string marca, string descricao, double valorUnitario){
            this.codigo = codigo;
            this.marca = marca;
            this.descricao = descricao;
            this.valorUnitario = valorUnitario;
        }
        public string GetCodigo(){
            return codigo;
        }
        public void SetCodigo(string codigo){
            this.codigo = codigo;
            
        }
        public string GetProduto(){
            return produto;
        }
        public void SetProduto(string produto){
            this.produto = produto;
        }
        public string GetMarca(){
            return marca;
        }
        public void SetMarca(string marca){
            this.marca = marca;
        }
        public string GetDescricao(){
            return descricao;
        }
        public void SetDescricao(string descricao){
            this.descricao = descricao;
        }
        public double GetValorUnitario(){
            return valorUnitario;
        }
        public void SetValorUnitario(double valorUnitario){
            this.valorUnitario = valorUnitario;
        }
        public void DadosProdutos(){
            Console.WriteLine("<--------------------->");
            Console.WriteLine("<--------------------->");
            Console.WriteLine("Informações do Produto ");
            Console.WriteLine("<--------------------->");
            Console.WriteLine("<--------------------->");

            Console.WriteLine("Digite o número do código: ");
            codigo = Console.ReadLine();
            Console.WriteLine("Digite a marca do produto: ");
            marca = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto: ");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            valorUnitario = double.Parse(Console.ReadLine());
        
        
        }
    }
}
