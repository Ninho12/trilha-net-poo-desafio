namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" Ok
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" Ok
        override
        public void InstalarAplicativo(string app){
            Console.WriteLine($"Instalando o Aplicativo: \"{app}\" no Nokia!");
        }
    }
}