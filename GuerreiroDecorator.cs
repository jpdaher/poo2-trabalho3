using System;
using System.Runtime.InteropServices.Marshalling;

namespace BatalhaGuerreiros;

public abstract class GuerreiroDecorator : IGuerreiro {
    protected IGuerreiro _guerreiro;

    public GuerreiroDecorator(IGuerreiro guerreiro) {
        _guerreiro = guerreiro;
    }

    public virtual string Nome {
        get { return _guerreiro.Nome; }
    }
    public virtual int Ataque {
        get { return _guerreiro.Ataque; }
    }
    public virtual int Defesa {
        get { return _guerreiro.Defesa; }
    }
    public virtual int Vida {
        get { return _guerreiro.Vida; }
    }
    public virtual int EsferasDoPoder {
        get { return _guerreiro.EsferasDoPoder; }
        set { _guerreiro.EsferasDoPoder = value; }
    }


    public virtual void ReceberDano(int dano, IGuerreiro atacante) {
        _guerreiro.ReceberDano(dano, atacante);
    }

    public virtual void Atacar(IGuerreiro alvo) {
        _guerreiro.Atacar(alvo);
    }   

    public virtual void ColetarEsfera() {
        _guerreiro.ColetarEsfera();
    }
}
