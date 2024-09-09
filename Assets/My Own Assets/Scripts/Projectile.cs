using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        transform.localScale = transform.localScale / 3;
    }
    void Start()
    {
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0.05f, 0, 0));
        Destroy(gameObject, 3f);
    }
}
