using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    int health;
    public GameObject text;
    public GameObject gameOver;
    

    void Start()
    {
       Time.timeScale = 1;
       health = 100;
        
    }

    // Update is called once per frame
    void Update()

    {
        text.GetComponent<UnityEngine.UI.Text>().text = health.ToString();
        if(health == 0)
        {
            gameOver.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "enemy")
        {
            health -= 25;
        }
    }
}
