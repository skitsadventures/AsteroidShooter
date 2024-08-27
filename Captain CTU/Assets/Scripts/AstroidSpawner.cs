using System.Collections;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{

    //public int startAmount;
    //public int growthRate;
    //public int numberOfIntervals = 3;
    public GameObject astroidPrefab;
    public float respawntime;

    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(AstroidWave());
    }

    private void SpawnEnemy()
    {
        GameObject a = Instantiate(astroidPrefab) as GameObject;
        a.transform.position = new Vector3(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));
    }

    //private void Update()
    //{
    //    respawntime = startAmount * Mathf.Pow((1 + growthRate), numberOfIntervals);
    //}

    IEnumerator AstroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
            SpawnEnemy();
        }
    }
}
