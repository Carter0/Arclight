using UnityEngine;

public class TargetLogic : MonoBehaviour
{
    public GameObject targetDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            //targetDoor.Open();
        }
    }
}
