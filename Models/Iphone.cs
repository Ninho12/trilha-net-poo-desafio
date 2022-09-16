using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" OK
        override
        public void InstalarAplicativo(string app){
            Console.WriteLine($"Instalando o Aplicativo: \"{app}\" no Iphone!");
        }
    }
}