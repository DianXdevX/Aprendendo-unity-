using UnityEditor.ShaderGraph;
using UnityEngine;

public class sing : MonoBehaviour
{
    public GameObject jogadorfo;
    private Vector3 distancia = new Vector3(5,  0, 10);
    private float andar ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        andar = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  Time.deltaTime * 10* andar  );
    }
}
