using UnityEngine;

public class TesteAula05 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Heroi", 100);
        Inimigo inimigo = new Inimigo("Monstro", 100, 10);

        player.gritar();
        inimigo.gritar();

        inimigo.Reclamar();
    }
}
