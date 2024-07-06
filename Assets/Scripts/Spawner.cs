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
        yield return new WaitForSeconds(.3f);
        GameObject ball1 = Instantiate(BallPrefab,transform);
        ball1.GetComponent<Rigidbody>().AddForce(Vector3.one*(Random.Range(10, 30)));
        GameManager.instance.AddCount();
        yield return new WaitForSeconds(.3f);
        GameObject ball2 = Instantiate(BallPrefab,transform);
        ball2.GetComponent<Rigidbody>().AddForce(Vector3.one*(Random.Range(10, 30)));
        GameManager.instance.AddCount();
    }
}
