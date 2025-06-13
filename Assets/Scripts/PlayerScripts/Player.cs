using UnityEngine;
using UnityEngine.UI;

[SelectionBase]
public class Player : MonoBehaviour
{
   public static Player Instance { get; private set; }
   
   private Rigidbody2D rb;
   private Vector2 inputVector;
   private bool isRuning = false;

   [SerializeField] private float speed = 10f;
   private float minSpeed = .1f;
   
  public GameObject bulletPrefab;
  public Transform bulletPoint;
  private float speedBullet = .1f;
  
  public Text armorText;


  public GameObject BulletPoofCloakItem;
  public GameObject BulletproofCloakWrist;
  public GameObject BulletproofCloakWrist2;
  public GameObject MilitaryHelmetItem;
  public GameObject ak_47;
  public GameObject makarov;
   private void Awake()
   {
      Instance = this;
      rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      inputVector = GameInput.Instance.GetMovementVector();
      Shot();
   }

   private void FixedUpdate()
   {
      inputVector = inputVector.normalized;
      rb.MovePosition(rb.position + inputVector * (speed * Time.deltaTime));
      if (Mathf.Abs(inputVector.x) > minSpeed || Mathf.Abs(inputVector.y) > minSpeed)
      {
         isRuning = true;
      }
      else
      {
         isRuning = false;
      }
   }
   public void Shot()
   {
      if (Input.GetKeyDown(KeyCode.Mouse0))
      {
         Vector2 mousePosition = Input.mousePosition;
         Vector2 worldPoint = Camera.main.ScreenToWorldPoint(new Vector2(mousePosition.x, mousePosition.y));
         GameObject Bull = Instantiate(bulletPrefab, bulletPoint.transform.position, Quaternion.identity);
         Vector3 direction = (worldPoint - rb.position).normalized;
         Bull.GetComponent<Rigidbody2D>().AddForce(direction * speedBullet);
      }
   }
   

   public Vector3 GetPlayerScreenPosition()
   {
      Vector3 vectorPlayerPosition = Camera.main.WorldToScreenPoint(transform.position);
      return vectorPlayerPosition;
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Enemy"))
      {
         GetComponent<HPSystem>().TakeDamage(10);
         GetComponent<HpBar>().TakeDamage(10);
      }
   }
}
