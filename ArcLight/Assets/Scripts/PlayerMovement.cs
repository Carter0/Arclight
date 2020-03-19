using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController controller;
    public float speed = 10f;
    public const float gravity = 9.81f;
    Vector3 moveDirection;
    public float jumpHeight = 10f;
    public float airControl = 10f;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var input = transform.right * moveHorizontal + transform.forward * moveVertical;
        input *= speed;

        if (controller.isGrounded)
        {
            moveDirection = input;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = Mathf.Sqrt(2 * gravity * jumpHeight);
            }
        }
        else
        {
            // the object is in the air
            // moveDirection.y = 0f;
            input.y = moveDirection.y;
            moveDirection = Vector3.Lerp(moveDirection, input, airControl * Time.deltaTime);
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
