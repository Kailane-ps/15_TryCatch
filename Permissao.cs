namespace _15_TryCatch
{
    public class Permissao
    {
        public bool Permitir { get; set; }


        public void Autorizar() {
            System.Console.WriteLine("Deseja permitir o acesso? Digite true ou false");

            try
            {
                Permitir = System.Boolean.Parse( System.Console.ReadLine());  
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Erro Dados inválidos");
            }
        }
    }
}