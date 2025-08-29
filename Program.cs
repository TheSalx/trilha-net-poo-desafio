using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i1 = new Iphone("9999-9999", "Iphone Lá Ele Pró Máx", "QLQRIMEIIPHONE", 16);
{
    i1.Ligar();
    i1.ReceberLigacao();
    i1.InstalarAplicativo("Whatsapp");
}

Nokia n1 = new Nokia("8888-8888", "Nokia Azul Indestrutível", "QLQRIMEINOKIA", 128);
{
    n1.Ligar();
    n1.ReceberLigacao();
    n1.InstalarAplicativo("Windows Mobile");
}
