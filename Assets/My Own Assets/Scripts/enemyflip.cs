using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyflip : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject player;
    [SerializeField] float y1;
    [SerializeField] float y2;
    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        if (player.transform.position.x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, y1, 0);

        }
        else 
        {
            transform.rotation = Quaternion.Euler(0, y2, 0);
        }
        
    }
}
