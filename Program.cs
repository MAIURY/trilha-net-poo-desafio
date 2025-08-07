using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("987654321", "Modelo 2", "222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();