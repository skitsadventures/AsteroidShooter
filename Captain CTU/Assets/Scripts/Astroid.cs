using UnityEngine.SceneManagement;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    public int health = 1;
    public float lifeSpan;
    public float speed = 10.0f;

    private Rigidbody2D rb;
    public GameObject explosion;
    


    private void Awake()
    {
        lifeSpan = 0.0f;
    }
 
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerMovement astroid = hitInfo.GetComponent<PlayerMovement>();
        if (astroid != null)
        {
            astroid.TakeDamage(2);
            Instantiate(explosion, rb.position, transform.rotation = Quaternion.identity);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die(); 
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        //speed = startAmount * Mathf.Pow(1+growthRate,numberOfIntervals);

        speed += 1f * Time.deltaTime;

        lifeSpan += 0.1f;
        if (lifeSpan > 140.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
