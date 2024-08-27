using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private AudioSource bombSoundEffect;
    public GameObject explosion;
    public float speed = 30f;
    private float life;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Astroid astroid = hitInfo.GetComponent<Astroid>();
        if (astroid != null)
        {
            ScoreScript.scoreValue += 1;
            astroid.TakeDamage(2);
            Instantiate(explosion, rb.position, transform.rotation = Quaternion.identity);
        }
            Destroy(gameObject);
    }
    private void Update()
    {
        life += 0.1f;
        if (life > 20.0f)
        {
            Destroy(gameObject);
        }
    }

}
