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
        GameObject ball1 = Instantiate(BallPrefab);
        GameManager.instance.AddCount();
        Vector3 pos1 = IndexToPosition(GameManager.instance.totalBalls);
        ball1.transform.position = pos1;
        yield return new WaitForSeconds(1);
        GameObject ball2 = Instantiate(BallPrefab);
        GameManager.instance.AddCount();
        Vector3 pos2 = IndexToPosition(GameManager.instance.totalBalls);
        ball2.transform.position = pos2;
    }
    public int TotalPositions = 10000; // Total number of positions
    public Vector3 GridSize = new Vector3(1000, 0, 1000); // Size of the grid in x and z dimensions
    public float YIncrement = 5f; // Y increment when index exceeds TotalPositions

    public Vector3 IndexToPosition(int index)
    {
        //index *= 10;
        int ypos = index/10000;
        index = index % 10000;
        // Calculate the normalized position based on the index
        // int x = index % (int)GridSize.x;
        // int z = (int)(index/100) % (int)GridSize.z;
        int x = (int)(index % 100) * 10;//0=0,1=10,2=20....100=1000
        int z = (index / 100) * 10;//0=0,1=0...100=0,101=1,


        // Calculate the position in Vector3 format
        Vector3 position = new Vector3(x, 2 + 2*ypos, z);

        return position;
    }
}
