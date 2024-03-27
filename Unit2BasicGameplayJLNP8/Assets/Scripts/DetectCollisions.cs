using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            return;
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
