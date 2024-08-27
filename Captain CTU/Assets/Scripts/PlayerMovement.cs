using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController controller;

    public float speed = 12f;
     public int health = 1;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y >= 4.3f)
        {
            transform.position = new Vector3(transform.position.x, 4.2f, 0);
        }
         
        else if (transform.position.y <= -4.2f)
        {
            transform.position = new Vector3(transform.position.y, -4.1f, 0);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * -z;

        //controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Bang!");
        }
    }
    public void TakeDamage(int damage)
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
}