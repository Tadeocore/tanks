using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCrontroller : MonoBehaviour
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

        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(transform.forward * vel, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(transform.forward * -vel, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(new Vector3(0, -rot, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(new Vector3(0, rot, 0) * Time.deltaTime);
        }

        // Start is called before the first frame update

    }
}
