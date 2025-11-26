using UnityEngine;

public class Dodger: MonoBehaviour
{
    //[SerializeField] Vector3 startingPosition = new Vector3(0, 0.5f, -40);
    [SerializeField] public int maxLives = 3;
    [SerializeField] float moveSpeed = 0.01f;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDodger();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move the Dodger around the level, and avoid bumping into obstacles!!");
    }

    void MoveDodger()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
