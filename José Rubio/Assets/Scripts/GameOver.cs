using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            transform.position = initialPosition;
        }
        if (collision.gameObject.CompareTag("Meta"))
        {
            Debug.Log("GANASTE!!");
        }

    }
}
