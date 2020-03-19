using UnityEngine;

public class TargetLogic : MonoBehaviour
{
    public GameObject targetDoor;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Target Hit");
            //targetDoor.Open();
        }
    }
}
