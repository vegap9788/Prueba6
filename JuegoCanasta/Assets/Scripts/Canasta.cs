using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canasta : MonoBehaviour
{
    public float speed = 10f;
    public float xMin = -8f;
    public float xMax = 8f;

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 newPosition = transform.position + new Vector3(move, 0, 0) * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);

        transform.position = newPosition;
    }

    public string tagObjetoADestruir = "Objeto";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagObjetoADestruir))
        {
            Destroy(collision.gameObject);
        }
    }
}
