using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    private float speedBullet = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer rend;
    private float timeDestroy = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       //   Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
       // float ratatenZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
       // transform.rotation = Quaternion.Euler(0, 0, ratatenZ);
     
       Vector3 mousPos = GameInput.Instance.GetMousePosition();
       Vector3 playerPosition = Player.Instance.GetPlayerScreenPosition();
       rb.velocity = Vector2.right   * speedBullet;
      
       Invoke("DestroyBullet", timeDestroy);       
       
    }

    private void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
