using System;
   
    public class Endereco{
        public string rua = "";
        public string bairro = "";
        public string NumCasa = "";
        public string cep = "";
        public string cidade = "";
        private string estado = "";

        public string GetRua(){
            return rua;
        }
        public void SetCodigo(string rua){
            this.rua = rua;
        }

        public string GetBairro(){
            return bairro;
        }
        public void SetBairro(string bairro){
            this.bairro = bairro;
        }

        public string GetNumCasa(){
            return NumCasa;
        }
        public void SetNumCasa(string NumCasa){
            this.NumCasa = NumCasa;
        }

        public string GetCep(){
            return cep;
        }
        public void SetCep(string cep){
            this.cep = cep;
        }
         public string GetCidade(){
            return cidade;
        }
        public void SetCidade(string cidade){
            this.cidade = cidade;
        }
         public string GetEstado(){
            return estado;
        }
        public void SetEstado(string estado){
            this.estado = estado;
        }

    public void DadosEndereco(){
        Console.WriteLine("Digite sua Rua: ");
        rua = Console.ReadLine();
        Console.WriteLine("Digite seu Bairro: ");
        bairro = Console.ReadLine();
        Console.WriteLine("Digite o número da casa: ");
        NumCasa= Console.ReadLine();
        Console.WriteLine("Digite seu CEP: ");
        cep = Console.ReadLine();
        Console.WriteLine("Digite sua Cidade: ");
        cidade= Console.ReadLine();
        Console.WriteLine("Digite seu Estado: ");
        estado = Console.ReadLine();
       
    }
}
    