using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    [SerializeField] Transform nave; //Buscamos el target de la nave.

    //Le añadimos variables para el suavizado de la camara.
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Creamos un vector 3 que coja la posicion de la nave y le reste su posicion le hacemos que mira a la posicion en y a -50 para darle el contrapicado
        le añadimos un cuaternion que mire en la posicion -50 y le damos los valores de la nave en la posicion x con la distancia a -160, la nave en Y a +50 para que este alta y la posicion Z a -4
        para que vaya por delante de la nave un poquito. (Este codigo lo he sacado de internet)
        */

        Vector3 lookPos = nave.position - transform.position;
        lookPos.y = -50;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);

        transform.position = new Vector3(nave.position.x -160, nave.position.y +50, nave.position.z -4);

    }
}
