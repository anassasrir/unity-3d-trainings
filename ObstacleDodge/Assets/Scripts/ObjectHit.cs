using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public static Collision collision;

    private void OnCollisionEnter(Collision objectcollision)
    {
        if (objectcollision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            Debug.Log("Ouch! You hit an obstacle!");
        }
        collision = objectcollision;

    }
}
