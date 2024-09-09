using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    [SerializeField]AudioSource audio1;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player") 
        {
            audio1.Play();
            WinScene.chestNUM++;
            Destroy(gameObject);
        
        }
    }
}
