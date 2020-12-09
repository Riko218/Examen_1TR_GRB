using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipmove : MonoBehaviour
{
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoNave();
        AlturaNave();
    }
    void MovimientoNave()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //Movimiento de la nave en X
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * desplX);
            //print (desplX);
        }

        //Movimiento de la nave en Z con la limitacion de ir hacia atras.
        if (desplZ >= 0)
        {
                transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);
            //print (desplZ);        
        }

    }

    void AlturaNave() //Metodo para aumentar la altura de la nave.
    {
        float posY = transform.position.y;

        //Si apretamos boton 5 del joystick la nave subira
        bool desplYUp = Input.GetKey("joystick button 5");
        if (desplYUp == true)
            transform.Translate(Vector3.up * Time.deltaTime * speed);

        //Si apretamos boton 4 del joystick la nave bajara
        bool desplYDown = Input.GetKey("joystick button 4");
        if (desplYDown == true)
            transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
