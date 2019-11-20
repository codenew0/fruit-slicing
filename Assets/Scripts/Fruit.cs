using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicePrefab;
    public float startForce = 15f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.tag == "Blade")
        {
        //     Vector3 direction = (col.transform.position - transform.position).normalized;
        //     Quaternion rotation = Quaternion.LookRotation(direction);
        //     Instantiate(fruitSlicePrefab, transform.position, rotation);
            GameObject slicedFruit = Instantiate(fruitSlicePrefab, transform.position, transform.rotation);
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);
        }
    }
}
