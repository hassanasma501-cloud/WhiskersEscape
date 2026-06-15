using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float speed = 5f;

    public float jumpHeight = 5f;

    public float gravity = -9.81f;

    private CharacterController controller;

    private Vector3 velocity;

    void Start()

    {

        controller = GetComponent<CharacterController>();

    }

    void Update()

    {

        float x = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(x, 0, 1);

        controller.Move(move * speed * Time.deltaTime);

        if (controller.isGrounded && velocity.y < 0)

        {

            velocity.y = -2f;

        }

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)

        {

            velocity.y = jumpHeight;

        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }

}
