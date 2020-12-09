using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreation : MonoBehaviour
{

    //Variable que contendré el prefab con el obstáculo
    [SerializeField] GameObject Esfera;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Variables para generar esferas de forma random
    private float randomNumber;
    Vector3 RandomPosZ;
    Vector3 RandomPosY;
    Vector3 RandomPosX;

    // Start is called before the first frame update
    void Start()
    {

        //Bucle para crear las columnas iniciales
        for (int n = 1; n <= 21; n++)
        {
            CrearEsfera(-n);
        }
        //Lanzo la corrutina
        StartCoroutine("InstanciadorEsferas");



    }

    //Función que crea una columna en una posición Random
    void CrearEsfera(float posZ = 0f, float posY = 0f, float posX = 0f)
    {
        randomNumber = Random.Range(0f, 100f);
        RandomPosZ = new Vector3(randomNumber, posY, posZ);
        RandomPosY = new Vector3(posX, randomNumber, posZ);
        RandomPosX = new Vector3(posX, posY, randomNumber);
        //print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPosZ + RandomPosY + RandomPosX;
        Instantiate(Esfera, FinalPos, Quaternion.identity);
    }

    //Corrutina que se ejecuta cada segundo
    IEnumerator InstanciadorEsferas()
    {
        //Bucle infinito (poner esto es lo mismo que while(true){}
        for (; ; )
        {
            CrearEsfera();
            float interval = 1;
            yield return new WaitForSeconds(interval);
        }
    }
}
