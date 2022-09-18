using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) 
        :  base(numero, modelo, imei, memoria){

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" OK
        override
        public void InstalarAplicativo(string app){
            Console.WriteLine($"Instalando o Aplicativo: \"{app}\" no Iphone!");
        }
    }
}