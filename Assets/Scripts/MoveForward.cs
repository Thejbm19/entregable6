using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;
    private float LimitY = 9f; // Establece limite arriba y abajo
    private float LimitX = 12f;  // Establece limite derecha y izquierda


    // Update is called once per frame
    void Update()
    {
        // Hace que se mueva constantemente
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > LimitY || transform.position.y < -LimitY || transform.position.x > LimitX || transform.position.x < -LimitX)
        {
                Destroy(gameObject); //destruye el GameObject
        }

    }
}
