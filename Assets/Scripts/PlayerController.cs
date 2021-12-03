using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Prefab;
    private Quaternion UpShoot = Quaternion.Euler(0, 0, 0);   //Rotar arriba
    private Quaternion LeftShoot = Quaternion.Euler(0, 0, 90);  //Rotar izquierda
    private Quaternion RightShoot = Quaternion.Euler(0, 0, -90);  //Rotar derecha
    private Quaternion DownShoot = Quaternion.Euler(0, 0, 180);  //Rotar abajo


    // Update is called once per frame
    void Update()
    {
        // dispara hacia arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProjectile(UpShoot);    
        }

        // dispara hacia abajo
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProjectile(DownShoot);
        }

        // dispara hacia izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProjectile(LeftShoot);
        }

        // dispara hacia derecha
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProjectile(RightShoot);
        }
    }

    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(Prefab, transform.position, rotation); // Hace aparecer el projectil
    }
}
