using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    
   private Animator anim;
   private SpriteRenderer rend;
   
   private const string  IS_RUNING = "isRuning";

   private void Awake()
   {
       anim = GetComponent<Animator>();
       rend = GetComponent<SpriteRenderer>();
   }

   private void Update()
   {
//       anim.SetBool( IS_RUNING, Player.Instance.IsRunning());
       PlayerDirection();
   }

   public void PlayerDirection()
   {
       Vector3 mousPos = GameInput.Instance.GetMousePosition();
       Vector3 playerPosition = Player.Instance.GetPlayerScreenPosition();
       if (mousPos.x < playerPosition.x)
       {
           rend.flipX = true;
       }
       else
       {
           rend.flipX = false;
       }
   }
}
