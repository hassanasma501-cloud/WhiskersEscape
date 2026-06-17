using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
   [Header("Forward Movement")]
   public float forwardSpeed = 5f;
   public float speedIncrease = 0.5f;
   [Header("Lane Movement")]
   public float laneDistance = 3f;
   public float laneChangeSpeed = 10f;
   [Header("Jump")]
   public float jumpForce = 8f;
   public float gravity = -20f;
   [Header("Slide")]
   public float slideHeight = 1f;
   private CharacterController controller;
   private Vector3 velocity;
   private int currentLane = 1; // 0 = gauche, 1 = centre, 2 = droite
   private float normalHeight;
   private Vector3 normalCenter;
   void Start()
   {
       controller = GetComponent<CharacterController>();
       normalHeight = controller.height;
       normalCenter = controller.center;
   }
   void Update()
   {
       // Avance automatique
       Vector3 move = Vector3.forward * forwardSpeed;
       // Changement de voie
       if (Input.GetKeyDown(KeyCode.LeftArrow))
       {
           currentLane--;
           currentLane = Mathf.Clamp(currentLane, 0, 2);
       }
       if (Input.GetKeyDown(KeyCode.RightArrow))
       {
           currentLane++;
           currentLane = Mathf.Clamp(currentLane, 0, 2);
       }
       float targetX = (currentLane - 1) * laneDistance;
       float deltaX = targetX - transform.position.x;
       move.x = deltaX * laneChangeSpeed;
       // Saut
       if (controller.isGrounded)
       {
           if (velocity.y < 0)
               velocity.y = -2f;
           if (Input.GetKeyDown(KeyCode.Space))
               velocity.y = jumpForce;
       }
       // Glissade
       if (Input.GetKey(KeyCode.DownArrow))
       {
           controller.height = slideHeight;
           controller.center = new Vector3(0, slideHeight / 2f, 0);
       }
       else
       {
           controller.height = normalHeight;
           controller.center = normalCenter;
       }
       // Gravité
       velocity.y += gravity * Time.deltaTime;
       move.y = velocity.y;
       controller.Move(move * Time.deltaTime);
   }
   // À appeler plus tard quand un fromage est ramassé
   public void IncreaseSpeed()
   {
       forwardSpeed += speedIncrease;
   }
}
