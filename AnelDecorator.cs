using System;

namespace BatalhaGuerreiros;

public class AnelDecorator : GuerreiroDecorator {

    public AnelDecorator(IGuerreiro guerreiro) : base(guerreiro) {}

    public void Refletir(int dano, IGuerreiro atacante) {
        int danoRefletido = (int)(dano * (EsferasDoPoder * 10.0 / 100));
        Console.WriteLine($"{Nome} refletiu {danoRefletido} de dano de volta ao atacante!");
        atacante.ReceberDano(danoRefletido, this);
    }

    public override void ReceberDano(int dano, IGuerreiro atacante) {
        base.ReceberDano(dano, atacante);
        Refletir(dano - Defesa, atacante);
    }
}
