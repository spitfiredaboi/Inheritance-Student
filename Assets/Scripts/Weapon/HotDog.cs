using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotDog : MonoBehaviour
{
    public float damage;
    public Rigidbody2D rb;
    public CapsuleCollider2D cc;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.forward, -90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider belongs to an enemy.
        if (collision.CompareTag("Enemy"))
        {
            // If it does, deal damage to the enemy.
            collision.GetComponent<Enemy>().TakeDamage(damage);
        }
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
