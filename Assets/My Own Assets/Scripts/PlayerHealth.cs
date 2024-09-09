using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    static int health = 3;
    [SerializeField] GameObject player;
    bool isdead;
    float time;
    [SerializeField] GameObject[] images = new GameObject[3];
    void Awake()
    {
        if (health == 0) 
        {

            health = 3;
            SceneManager.LoadScene(2);

        }
        for(int i=0; i<health; i++) 
        {
            Image image = images[i].GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);


        }
       
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene(0);

        }
        if (player == null)
        {
            time = time + Time.deltaTime;

            if (time > 3)
            {
                SceneManager.LoadScene(0);

            }
        }
        if (player == null && !isdead) 
        {
            health = health - 1;
            WinScene.chestNUM = 0;
            isdead = true;
            
            
                

            
            
        }

        
    }
}
