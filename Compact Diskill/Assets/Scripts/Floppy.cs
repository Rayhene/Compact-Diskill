using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floppy : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public GameObject rightBullet;
    Transform firePos;
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        firePos = transform.FindChild("firePos");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveUp))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5, 0);

        if (Input.GetKeyDown(moveDown))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

    }

    void Fire()
    {
        Instantiate(rightBullet, firePos.position, Quaternion.identity);
    }
}
