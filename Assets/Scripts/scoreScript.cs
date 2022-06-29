using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreScript : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }
}
