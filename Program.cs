using System;

namespace BatalhaGuerreiros;

public class Program(){
    public static void Main(){
        IGuerreiro arthur = new AnelDecorator(new EspadaDecorator(new GuerreiroBase("Arthur", 30, 20)));
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        arthur.ColetarEsfera();
        IGuerreiro roberto = new EspadaDecorator(new GuerreiroBase("Roberto", 30, 20));

        while(arthur.Vida > 0 && roberto.Vida > 0) {
            if (arthur.Vida > 0) {
                arthur.Atacar(roberto);
            } else {
                Console.WriteLine("Arthur Morreu!");
            }
            Thread.Sleep(500);
            if (roberto.Vida > 0) {
                roberto.Atacar(arthur);
            } else {
                Console.WriteLine("Roberto Morreu!");
            }
            Thread.Sleep(500);
        }
    }
}