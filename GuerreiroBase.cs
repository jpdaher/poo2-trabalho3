using System;
using System.Collections.Specialized;

namespace BatalhaGuerreiros;

public class GuerreiroBase : IGuerreiro
{
    public string Nome { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public int Vida { get; set; } = 100;
    public int EsferasDoPoder { get; set; }

    public GuerreiroBase(string nome, int ataque, int defesa)
    {
        Nome = nome;
        Ataque = ataque;
        Defesa = defesa;
    }

    public void ColetarEsfera() {
        if (EsferasDoPoder < 10) {
            EsferasDoPoder++;
            Console.WriteLine($"{Nome} está com {EsferasDoPoder} esfera(s) de poder!");
        } else Console.WriteLine($"{Nome} tentou coletar mais esferas, mas já atingiu o número máximo.");
    }
    public virtual void ReceberDano(int dano, IGuerreiro atacante)
    {
        int danoRecebido = Math.Max(dano - Defesa, 0);
        Vida -= danoRecebido;
        if (Vida < 0) Vida = 0;
        Console.WriteLine($"{Nome} recebeu {danoRecebido} de dano e está com {Vida} de vida.");
    }

    public virtual void Atacar(IGuerreiro inimigo)
    {
        Console.WriteLine($"{Nome} ataca {inimigo.Nome} com {Ataque} de ataque!");
        inimigo.ReceberDano(Ataque, this);
    }
}
