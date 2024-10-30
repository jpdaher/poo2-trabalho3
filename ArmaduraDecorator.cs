using System;

namespace BatalhaGuerreiros;

public class ArmaduraDecorator : GuerreiroDecorator {
    private int _incrementoDefesa = 30;

    public ArmaduraDecorator(IGuerreiro guerreiro, int incrementoDefesa) : base(guerreiro) {

    }

    public override int Defesa {
        get { return base.Defesa + _incrementoDefesa; }
    }
}
