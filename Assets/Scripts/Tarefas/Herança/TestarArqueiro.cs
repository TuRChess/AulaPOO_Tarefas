using UnityEngine;

public class TestarArqueiro : MonoBehaviour
{
    Arqueiro arqueiro = new Arqueiro("Gavião Arqueiro", 100, 50);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            arqueiro.AtirarFlecha();
        }
    }
}
