using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSpaceship : MonoBehaviour
{
    [SerializeField] Transform nave;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //llamamos a el metodo.
       Rotacion();
    }

    void Rotacion()
    {
        //le decimos que coja el imput del axis RS que es el axis derecho y lo multiplicamos por la variable publica rotation speed (que se puede poner a voluntad en unity)
        //transformamos la rotacion y multipicamos por Time Delta time para que no se dispare.

        float rotation = Input.GetAxis("RS") * rotationSpeed;
        nave.Rotate(0, rotation, 0 * Time.deltaTime * rotationSpeed);
    }
}
