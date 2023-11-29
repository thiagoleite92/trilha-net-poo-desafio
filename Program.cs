using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("81-987456321", "Modelo 1", "1223334444", "64gb");
nokia.Ligar("0800141516");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("81-987456321", "Modelo 1", "1223334444", "64gb");
iphone.Ligar("0800141516");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tinder");
