using System;

public interface IGuerreiro {
  void getDescricao();
}

public class GuerreiroBase:IGuerreiro {
  public void getDescricao() {
    Console.WriteLine("Eu sou o guerreiro");
  }
}

public abstract class GuerreiroDecorator:IGuerreiro {
  protected IGuerreiro _guerreiro;
  public GuerreiroDecorator(IGuerreiro guerreiro){
    _guerreiro = guerreiro;
  }
  public virtual void getDescricao(){
    _guerreiro.getDescricao();
  }
}

public class Armadura:GuerreiroDecorator {
  public Armadura(IGuerreiro guerreiro):base(guerreiro){}
  public override void getDescricao(){
    base.getDescricao();
    Console.WriteLine("Obteve Armadura de Ferro");
  }
}

public class Espada:GuerreiroDecorator {
  public Espada(IGuerreiro guerreiro):base(guerreiro){}
  public override void getDescricao(){
    base.getDescricao();
    Console.WriteLine("Obteve Espada Flamejante");
  }
}
