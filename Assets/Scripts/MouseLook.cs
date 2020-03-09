using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Transform player;
    public float mouseSensitivity = 100f;
    float xRotationAmount = 0;

    void Start()
    {
        if (player == null)
        {
            player = transform.parent.transform;
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame 
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float moveY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        Debug.Log(moveX);

        // yaw applied to the parent. 
        player.Rotate(Vector3.up * moveX);


        xRotationAmount -= moveY;
        xRotationAmount = Mathf.Clamp(xRotationAmount, -90f, 90f);

        // applied to camera.
        // transform.Rotate(Vector3.left * xRotationAmount); 
        transform.localRotation = Quaternion.Euler(xRotationAmount, 0, 0);
    }
}
