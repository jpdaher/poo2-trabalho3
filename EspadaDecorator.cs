using System;

namespace BatalhaGuerreiros;

public class EspadaDecorator : GuerreiroDecorator {
    private int _incrementoAtaque = 10;

    public EspadaDecorator(IGuerreiro guerreiro) : base(guerreiro) {

    }

    public override int Ataque {
        get { return base.Ataque + _incrementoAtaque; }
    }

    public override void Atacar(IGuerreiro alvo)
    {
        Console.WriteLine($"{_guerreiro.Nome} ataca {alvo.Nome} com {base.Ataque + _incrementoAtaque} de dano!");
        alvo.ReceberDano(base.Ataque + _incrementoAtaque, this);
    }
}
