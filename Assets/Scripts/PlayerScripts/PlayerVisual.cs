using UnityEngine;

public class PlayerVisual : MonoBehaviour
{ 
    private SpriteRenderer rend;
    private const string  IS_RUNING = "isRuning";

   private void Awake()
   {
       rend = GetComponent<SpriteRenderer>();
   }

   private void Update()
   {
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
