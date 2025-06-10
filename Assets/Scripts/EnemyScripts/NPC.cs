using UnityEngine;
public class NPC : MonoBehaviour
{
   public Transform playerTransform;

    public float speed = 0.5f;  
    private GameObject player;
    private Rigidbody2D enemyRB;
    
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        EnemiMove();

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    private void EnemiMove()
    {
        Vector3 LoockDirection = (player.transform.position - transform.position).normalized; 
        enemyRB.AddForce(LoockDirection * speed);
    }
   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Bullet"))
      {
         GetComponent<HPSystem>().TakeDamage(10);
         GetComponent<HpBar>().TakeDamage(10);
      }
   }
}
