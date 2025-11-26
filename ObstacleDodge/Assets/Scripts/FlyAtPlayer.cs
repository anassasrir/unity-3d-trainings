using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float projectileSpeed = 0.05f; 
    Vector3 targetPosition;


    private void DestroyWhenReached()
    {
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayerPosition()
    {
        Debug.Log("player position: " + transform.position);

        Debug.Log("player position: " + targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * projectileSpeed);
    }

    void Start()
    {
        targetPosition = target.transform.position;
    }
    void Update()
    {
        MoveToPlayerPosition();
        DestroyWhenReached();
    }


}
