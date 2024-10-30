using System;

namespace BatalhaGuerreiros;

public interface IGuerreiro {
    string Nome { get; }
    int Ataque { get; }
    int Defesa { get; }
    int Vida { get; }
    int EsferasDoPoder { get; set; } 
    void ColetarEsfera();
    void ReceberDano(int dano, IGuerreiro atacante);
    void Atacar(IGuerreiro alvo);
}

