using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia= new (numero: "1326487", modelo: "Modelo 2", imei: "23131321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Pou");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone= new (numero: "2015307", modelo: "Modelo Xs", imei: "458213321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");