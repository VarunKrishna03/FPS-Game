using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButton(0))    
        {
            GameObject bulletreference = Instantiate(bullet);
            bulletreference.transform.position = transform.position;
            Rigidbody rb = bulletreference.GetComponent<Rigidbody>();
            rb.velocity = transform.rotation * Vector3.forward * 100.0f;
        }
    }
}
