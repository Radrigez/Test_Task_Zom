using System;
using UnityEngine;

[SelectionBase]
public class Player : MonoBehaviour
{
   public static Player Instance { get; private set; }
   
   private Rigidbody2D rb;
   private Vector2 inputVector;
   private bool isRuning = false;

   [SerializeField] private float speed = 10f;
   private float minSpeed = .1f;
   
   public GameObject lounchPoin;
   public GameObject bulletPrefab;
   
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
         Instantiate(bulletPrefab, transform.position, Quaternion.identity);
      }
   }
   
   public bool IsRunning()
   {
      return isRuning;
   }

   public Vector3 GetPlayerScreenPosition()
   {
      Vector3 vectorPlayerPosition = Camera.main.WorldToScreenPoint(transform.position);
      return vectorPlayerPosition;
   }
  
}
