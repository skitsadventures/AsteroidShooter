using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
   

    public GameObject ballPrefab;
    public float respawntime;

    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(BallWave());
    }

    private void Spawnball()
    {
        GameObject b = Instantiate(ballPrefab) as GameObject;
        b.transform.position = new Vector3(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));
    }

  

    IEnumerator BallWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            
            Spawnball();
        }
    }
}
