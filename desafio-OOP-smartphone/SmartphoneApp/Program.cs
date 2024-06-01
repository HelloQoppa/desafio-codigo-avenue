using SmartphoneApp.models;

Nokia nokia = new Nokia("123456789", "windows phone", "000000000000000", 64);
Iphone iphone = new Iphone("987654321", "iPhone 13", "111111111111111", 128);

Console.WriteLine(nokia.InstalarAplicativo("WhatsApp"));
Console.WriteLine(iphone.InstalarAplicativo("Instagram"));

nokia.Ligar();

iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();