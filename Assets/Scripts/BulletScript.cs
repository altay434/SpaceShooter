using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firedBullet;
    public Transform firePoint;
    public int bulletForce;
    public AudioSource bulletAudio;
    public GameObject laser;
    public bool isLaserAvaible=true;
    public bool isRaycastAvaible = false;
    RaycastHit2D hit;


    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Q) && isLaserAvaible == true)
        {
            StartCoroutine(Laser());
        }
        if(isRaycastAvaible == true)
        {
            if (hit = Physics2D.Raycast(firePoint.position, firePoint.up, 8f))
            {
                if (hit.collider.CompareTag("enemy"))
                {
                    Destroy(hit.collider.gameObject);
                    GameObject.Find("Score").GetComponent<scoreScript>().score += 1;
                }
            }
        }
    }

    void Shoot()
    {
        AudioSource ses = Instantiate(bulletAudio,firePoint.position,firePoint.rotation);
        ses.Play();
        Destroy(ses.gameObject, 3);
        firedBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = firedBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(firedBullet, 5f);
    }
    
    private IEnumerator Laser() {

        isRaycastAvaible = true;
        isLaserAvaible = false;
        laser.SetActive(true);
        yield return new WaitForSeconds(10);
        laser.SetActive(false);
        isRaycastAvaible = false;
        yield return new WaitForSeconds(10);
        isLaserAvaible = true;
    }

}
