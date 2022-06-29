using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public GameObject spaceShipPre;
    public Transform[] spawners;
    public int shipSpeed = 5;
    void Start()
    {
        StartCoroutine(spawn());
    }
    private IEnumerator spawn()
    {
        Transform spawner = spawners[Random.Range(0, 6)];
        GameObject spaceShip = Instantiate(spaceShipPre,spawner.position,spawner.rotation);
        Rigidbody2D rb = spaceShip.GetComponent<Rigidbody2D>();
        rb.AddForce(spawner.up * shipSpeed, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spawn());
    }
    
}
