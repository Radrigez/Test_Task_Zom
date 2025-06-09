using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
   private Transform playerTransform;

   void Start()
   {
      
   }
   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Bullet"))
      {
         GetComponent<HPSystem>().TakeDamage(10);
      }
   }
}
