using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public bird birdScript;
    public GameObject borular;
    public float yukseklik;
    public float zaman;

    void Start()
    {
        StartCoroutine(BoruKlonla(zaman));
    }


    void Update()
    {
        
    }

    public IEnumerator BoruKlonla(float zaman)
    {

        while (!birdScript.olduMu)
        {
            Instantiate(borular, new Vector3(2, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity);
            yield return new WaitForSeconds(zaman);
        }
    }
}
