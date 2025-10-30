using UnityEngine;

public class Arqueiro : Personagem
{
    int flechas;

    public Arqueiro(string nome, int vida, int flechas) : base(nome, vida)
    {
        this.flechas = flechas;
    }

    public void AtirarFlecha()
    {
        if (flechas > 0) {
            flechas--;
            Debug.Log($"Flecha Atirada, {flechas} flechas no inventário");
        }
        else
        {
            Debug.Log($"Não pode mais atirar, {flechas} flechas no inventário");
        }
    }
}
