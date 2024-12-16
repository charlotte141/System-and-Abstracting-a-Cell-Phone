using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("12345", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("56789", "Modelo 2", "2222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");