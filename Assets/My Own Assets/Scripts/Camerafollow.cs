using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camerafollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (player == null) return;


        /*transform.position = player.transform.position + offset;*/
        transform.position= new Vector3(player.transform.position.x + offset.x,9.51f,player.transform.position.z+offset.z);
        
    }
}
