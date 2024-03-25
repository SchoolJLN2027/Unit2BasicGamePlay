using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
        else if (transform.position.x < -sideBound) 
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

    }
}
