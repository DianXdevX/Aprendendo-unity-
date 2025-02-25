using UnityEngine;
using UnityEngine.Rendering;

public class NewMonoBehaviourScript : MonoBehaviour
{ //variaves
    private float vel = 15f;
    private float speed = 25f;
    private float controlho;
    private float controlv;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controlho = Input.GetAxis("Horizontal"); // a var  recee  input horizontal 
        controlv = Input.GetAxis("Vertical"); //   a var recebe  verical 
        // mova o carro para  frente 
        transform.Translate(Vector3.forward *Time.deltaTime * vel * controlv);
        //  transform.Translate(Vector3.right * Time.deltaTime *speed * controlho);   // spedd precisa ser pelo menos 1
        //   abaixo a rotalao do carro 
        transform.Rotate(Vector3.up, speed * controlho * Time.deltaTime);   // rotate acesa a rotaçao , up acesa o eixo t do objeto  
    }
}
