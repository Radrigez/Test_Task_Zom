using UnityEngine;
public class NPC : MonoBehaviour
{
   public Transform playerTransform;

    public float speed = 0.5f;  
    private GameObject player;
    private Rigidbody2D enemyRB;
    private Vector2 movementVector;
    private Transform enemyTrans;
    
    
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRB = GetComponent<Rigidbody2D>();
        movementVector = transform.position;
        enemyTrans = GetComponent<Transform>();
        //movementVector = new Vector2(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y);
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
        
        if(enemyTrans.position.x < Player.Instance.transform.position.x) 
        {
            enemyTrans.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            enemyTrans.localScale = new Vector3(-1, 1, 1);

        }
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
