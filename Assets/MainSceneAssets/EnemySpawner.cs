using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;

    public float StallTime = 3.0F;

	void Start () {

        StartCoroutine(Spawn());

    }


	void Update () {

	}



    IEnumerator Spawn()
    {

        while(true)
        {
            GameObject bulletObject = Instantiate(enemy) as GameObject;

            BoxCollider2D box = GetComponent<BoxCollider2D>();

            var x = Random.Range(-(box.size.x / 2), (box.size.x / 2));
            bulletObject.transform.position = transform.position + new Vector3(x, 0, 0);

            yield return new WaitForSeconds(StallTime);
        }


    }

}
