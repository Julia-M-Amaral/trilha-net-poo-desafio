using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone(numero: "(83) 99943-8379", modelo: "Iphone 15 Pro Max", imei: "874205136982047", memoria: 128);

Console.WriteLine($"Smartphone Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "(93) 97217-8152", modelo: "Nokia G11 Plus", imei: "879546201348725", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
