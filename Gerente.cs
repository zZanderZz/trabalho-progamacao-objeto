namespace TRABALHOANDER{

    public class Gerente:Funcionario{
        public Gerente(){

        }
        public Gerente(string cpf, string nome, string rg, string dataNascimento, Endereco endereco, double salario): base(cpf, nome, rg, dataNascimento, endereco, salario){   
        }
        public void CalculaSalarioGerente(){
            base.GetSalario();
            SetSalario(GetSalario() * 1.2);
        }
    
    
    
    }






}