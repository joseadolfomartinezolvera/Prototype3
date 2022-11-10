using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroun : MonoBehaviour
{
    //parte de encaraga de hacer que nuestro fondo aparente ser infinito haciendolo repetirse hasta terminar el juego 
    private Vector3 startPos;
    private float reaptWidth;
    void Start()
    {
        startPos = transform.position;
        reaptWidth = GetComponent<BoxCollider>().size.x /2;
    }
    void Update()
    {
        if(transform.position.x < startPos.x - reaptWidth)
        {
            transform.position = startPos;
        }
    }
}
