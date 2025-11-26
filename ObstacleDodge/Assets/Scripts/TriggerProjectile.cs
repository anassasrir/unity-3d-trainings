using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player entered trigger, activating projectile.");
            foreach (GameObject projectile in projectiles) 
            {
                if (projectile != null)
                {
                    projectile.SetActive(true);
                }
            }
        }
    }
}
