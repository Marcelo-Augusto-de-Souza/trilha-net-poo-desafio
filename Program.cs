using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:\n");
Nokia nokia = new Nokia("5533988888888", "Nokia G400", "1212121212", 45);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tetris");

nokia.Numero = "5533977777777";
Console.WriteLine($"Numero do Nokia alterado: {nokia.Numero}\n");

Console.WriteLine("Smartphone iPhone:\n");
Iphone iphone = new Iphone("5521955555555", "iPhone 9", "6969696969", 84);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

iphone.Numero = "5521944444444";
Console.WriteLine($"Numero do iPhone alterado: {iphone.Numero}\n");