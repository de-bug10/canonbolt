using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float lifeTime = 5f;
    public GameObject explosion;
    public float minY = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StatusCheck();

    }

    void StatusCheck()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            //Destroy
        }

        if (transform.position.y < minY)
        {
            //Destroy
        }
    }

    void Destroy() 
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
