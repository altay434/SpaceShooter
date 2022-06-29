using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipScript : MonoBehaviour
{

    //public GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //text.GetComponent<UnityEngine.UI.Text>().text = "Score: "  + score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "bullet")
        {
            GameObject.Find("Score").GetComponent<scoreScript>().score += 1;
            Destroy(this.gameObject);
            Destroy(collision.collider.gameObject);

        }
        if(collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        
    }
}
