using UnityEngine;

public class TargetLogic : MonoBehaviour
{
    public GameObject targetDoor;
    public AudioClip hitSoundEffect;

    private LevelManager levelManager;

    private bool hit = false;

    void Start() {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            if (!hit) {
                Debug.Log("Target Hit");
                AudioSource.PlayClipAtPoint(hitSoundEffect, gameObject.transform.position);
                levelManager.IncrementHitTargets();
                hit = true;
            }
            //targetDoor.Open();
        }
    }

    public bool isHit() {
        return hit;
    }
}
