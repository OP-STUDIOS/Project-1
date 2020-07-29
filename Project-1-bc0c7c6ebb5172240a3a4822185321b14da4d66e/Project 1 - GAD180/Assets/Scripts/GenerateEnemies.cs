using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    private GameObject[] currentEnemies;
    private int enemyCount;

    public float minX_Pos, MaxX_Pos;
    public float minZ_Pos, MaxZ_Pos;
    public float Y_Pos;

    private float ranXPos, ranZPos;


    private void Update()
    {
        currentEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = currentEnemies.Length;
        if (enemyCount >= 0 && enemyCount < 5)
        {
            StartCoroutine(SpawnEnemy());
        }
    }

    IEnumerator SpawnEnemy()
    {
            ranXPos = Random.Range(minX_Pos, MaxX_Pos);
            ranZPos = Random.Range(minZ_Pos, MaxZ_Pos);
            Instantiate(theEnemy, new Vector3(ranXPos, Y_Pos, ranZPos), theEnemy.transform.rotation);
            yield return new WaitForSeconds(0.1f);
    }
}
