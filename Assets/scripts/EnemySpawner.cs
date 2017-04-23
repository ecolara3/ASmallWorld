using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;

    public float StallTime = 1F;

    public static bool spawnEnemies = true;

	void Start () {

        StartCoroutine(Spawn());

    }


	void Update () {
        
	}



    IEnumerator Spawn()
    {

        while(spawnEnemies)
        {

            GameObject bulletObject = Instantiate(enemy) as GameObject;

            BoxCollider2D box = GetComponent<BoxCollider2D>();

            var x = Random.Range(-(box.size.x / 2), (box.size.x / 2));
            var y = Random.Range(-(box.size.y / 2), (box.size.y / 2));
            bulletObject.transform.position = transform.position + new Vector3(x, y, 0);

            yield return new WaitForSeconds(StallTime);
        }


    }

}
