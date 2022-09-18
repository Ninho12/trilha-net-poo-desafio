namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" Ok
    public class Nokia : Smartphone
    {

         public Nokia(string numero, string modelo, string imei, int memoria) 
        :  base(numero, modelo, imei, memoria){

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" Ok
        override
        public void InstalarAplicativo(string app){
            Console.WriteLine($"Instalando o Aplicativo: \"{app}\" no Nokia!");
        }
    }
}