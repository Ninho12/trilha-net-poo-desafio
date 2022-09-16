using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone OK

Console.WriteLine("Celular da Marca Nokia: ");
Smartphone nokia = new Nokia(numero: "9905-3322", modelo: "Nokia 11", imei: "44223", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n")

Console.WriteLine("Celular da Marca do Iphone: ");
Smartphone iphone = new Iphone(numero: "9905-3322", modelo: "Iphone 11", imei: "45433", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

