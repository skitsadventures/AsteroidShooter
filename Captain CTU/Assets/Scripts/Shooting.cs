using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePointL;
    public Transform firePointR;

    public float nextProjectile = 0.5f;
    public float projectileCoolDown = 0.5f;

    [SerializeField] private AudioSource shootSoundEffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextProjectile)
        {
            Shoot();
            nextProjectile = Time.time + projectileCoolDown;
            shootSoundEffect.Play();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePointL.position, firePointL.rotation);
        Instantiate(bulletPrefab, firePointR.position, firePointR.rotation);
    }
}
