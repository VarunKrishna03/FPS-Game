using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bulletdestroy : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time>5.0f)
        {
            Destroy(gameObject);
        }
        time = time + Time.deltaTime;
        if(time>20.0f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
