using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     bool hasPackage;
     [SerializeField] float destroyDelay = 1f;
     [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
     [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
     SpriteRenderer spriteRenderer;

      /// <summary>
     /// Start is called on the frame when a script is enabled just before
     /// any of the Update methods is called the first time.
     /// </summary>
      void Start()
          {
               spriteRenderer = GetComponent<SpriteRenderer>();// Get component = metodo ultilizado para pegar o compontnete , forma de "Instanciar" objeto
          }

     
     
    void OnTriggerEnter2D(Collider2D other) //Metodo de colisao, retorna objeto "outro" 
   {
       if( other.gameObject.tag == "box" && hasPackage == false)// alternativamente, poderia se usar !hasPackaege(!= not)
       {
            Debug.Log("You got the package!!!");
            hasPackage = true;

            Destroy(other.gameObject,destroyDelay);

            spriteRenderer.color = hasPackageColor;
       }

       if(other.gameObject.tag == "Customer" &&  hasPackage == true)
       {
            Debug.Log("Package delivered");
            hasPackage = false;

             spriteRenderer.color = noPackageColor;
       }

       
   }
}
