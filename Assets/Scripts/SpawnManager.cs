using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;// Da refereincia del obstaclePrefab
    private Vector3 spawPos = new Vector3(25,0,0);//posicion en la que se generan los objetos
    private float startDelay = 2;//{se encargan de crear obstaculos en intervalos 
    private float repeatRate = 2;//}
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //Parte encargada de que no se spawnien mas obstaculos despues de haber perdido
        playerControllerScript = GameObject.Find("inkyPaii").GetComponent<PlayerController>();
        //se encarga de llamar al SpaObstacle este proceso se llama cada 2 segundos
        InvokeRepeating("SpawObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            //se encarga de generar un obstaculo nuevo
             Instantiate(obstaclePrefab, spawPos, obstaclePrefab.transform.rotation);
        }
        }
}

