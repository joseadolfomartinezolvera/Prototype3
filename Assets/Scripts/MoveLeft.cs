using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30; //velocidad con la que se mueve nuestro fondo
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    //parte encargada de que el jugador pare su camino una vez que choco con un obstaculo
    void Start()
    {

        playerControllerScript = GameObject.Find("inkyPaii").GetComponent<PlayerController>();

    }

    // Este apartado es el que se encarga de el fondo de la ilucion de que el juagador es quien se mueve 
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }    
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
