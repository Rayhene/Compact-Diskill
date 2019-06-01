using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD : MonoBehaviour
{
    public int damage = 1;
    public float speed;
  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //player takes damage
            other.GetComponent<Floppy>().health -= damage;
            Debug.Log(other.GetComponent<Floppy>().health);
            Destroy(gameObject);
        }
    }

   

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
