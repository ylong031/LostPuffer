using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocks : MonoBehaviour
{
    public Transform[] rocktransforms = new Transform[5];
    public GameObject rocks;
    float time = 0;
   

    void Awake()
    {


        for (int i = 0; i < transform.childCount; i++)
        {
            rocktransforms[i] = transform.GetChild(i);

        }

    }

  

    private void Update()
    {
        time = time + Time.deltaTime;

        if(time > 3) 
        {
            int num = Random.Range(0, 4);
            GameObject rockobject=Instantiate(rocks,rocktransforms[num]);
            Destroy(rockobject, 3f);
            time = 0;
        
        }
    }

  

}
