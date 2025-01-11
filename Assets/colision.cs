using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) //Metodo de colisao, retorna objeto "outro" 
   {
       Debug.Log("Crash!");
   }

   
}
