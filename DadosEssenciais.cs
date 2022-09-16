namespace TRABALHOANDER{

    public abstract class DadosEssenciais
    {
        private int codigo = 01;
         private string nome = "";
         private string cpf = "";
        private string rg = "";
         private string dataNascimento = "";
        private Endereco endereco;
        private static int codFinal;
        
        public DadosEssenciais(){
            codFinal++;
            this.codigo = codFinal;
            this.nome = "";
            this.cpf = "";
            this.rg = "";
            this.dataNascimento = "";
            this.endereco = new Endereco();
        }

        public int GetCodigo(){
            return codigo;
        }
        public void SetCodigo(int codigo){
            this.codigo = codigo;
        }

        public string GetNome(){
            return nome;
        }
        public void SetNome(string nome){
            this.nome = nome;
        }

        public string GetCpf(){
            return cpf;
        }
        public void Setcpf(string cpf){
            this.cpf = cpf;
        }

        public string GetRg(){
            return rg;
        }
        public void SetRg(string rg){
            this.rg = rg;
        }
         public string GetDataNascimento(){
            return dataNascimento;
        }
        public void SetDataNascimento(string dataNascimento){
            this.dataNascimento = dataNascimento;
        }
         public Endereco GetEndereco(){
            return endereco;
        }
        public void SetEndereco(Endereco endereco){
            this.endereco = endereco;
        }

        public void DadosEssenciaisBase(){
            Console.WriteLine("<--------------------->");
            Console.WriteLine("<--------------------->");
            Console.WriteLine("fazer cadastro cliente ");
            Console.WriteLine("<--------------------->");
            Console.WriteLine("<--------------------->");

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite seu RG: ");
            rg = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento: ");
            dataNascimento = Console.ReadLine();

            endereco.DadosEndereco();
            
    
            
        }    
    }
}