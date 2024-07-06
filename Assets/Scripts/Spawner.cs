using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BallPrefab;
    void Start()
    {
        StartCoroutine(SpawnAnotherBalls());
    }

    IEnumerator SpawnAnotherBalls()
    {
        yield return new WaitForSeconds(1);
        GameObject ball1 = Instantiate(BallPrefab,transform);
        GameManager.instance.AddCount();
        yield return new WaitForSeconds(1);
        GameObject ball2 = Instantiate(BallPrefab,transform);
        GameManager.instance.AddCount();
    }
}
