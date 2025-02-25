using UnityEngine;

public class Camv : MonoBehaviour
{
    public GameObject jogador;
    private Vector3 dcam = new Vector3(0, 6, -9);  // isso realoca a camera com base no vsctor 3  x y z 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //  isso joga a camera na posçao do jogador 
        transform.position = jogador.transform.position + dcam ; 
    }
}
