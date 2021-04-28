using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{

    //Bueno, vamos a ver como hacemos este movimiento bien

    //vamos a declarar las velocidades y coso

    public float vel = 5f;
    public float rot = 100f;
    public float brake = 2f;

    //aca le damos la rotacion al canion, nosierto?
    public GameObject cannon;
    public Rigidbody rb;
    
    
    //no se si es mejor que usemos rigidbody o sin rigidbody, x las conexiones en internet nosierto, quizas es mejor sin, o con? UwU
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //las teclas que pongo aca son solo de testeo, nada es final, podriamos usar axis para hacerlo mejor, pero coso


        //esto esta pensado para no usar rigidbody, sino, seria algo tipo: rigidbody.addforce etc etc

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward*vel, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -vel, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rot, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rot, 0) * Time.deltaTime);
        }

        //por ahora voy a hacer que la rotacion del canion sea con Q y E, pa simplificar, mas adelante va a ser con el mouse supongo

       

        //ESTO ES SOLO UNA IDEA
/*
if (Input.GetKey(KeyCode.W)){
    transform.Translate(new Vector3(vel, 0, 0) * Time.deltaTime);
}
if (Input.GetKey(KeyCode.S)){
    transform.Translate(new Vector3(-vel, 0, 0) * Time.deltaTime);
}
if (Input.GetKey(KeyCode.A)){
    transform.Translate(new Vector3(0, 0, vel) * Time.deltaTime);
}
if (Input.GetKey(KeyCode.D)){
    transform.Translate(new Vector3(0, 0, -vel) * Time.deltaTime);
}

//por ahora voy a hacer que la rotacion del canion sea con Q y E, pa simplificar, mas adelante va a ser con el mouse supongo

if (Input.GetKey(KeyCode.E))
{
    cannon.transform.Rotate(new Vector3(0, rot, 0) * Time.deltaTime);
}
if (Input.GetKey(KeyCode.Q))
{
    cannon.transform.Rotate(new Vector3(0, -rot, 0) * Time.deltaTime);
}
*/  

}
}
