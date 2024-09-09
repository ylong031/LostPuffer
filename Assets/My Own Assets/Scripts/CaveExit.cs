using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveExit : MonoBehaviour
{
    [SerializeField] GameObject boss;
    [SerializeField] GameObject caveExit;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject misc;


    private void awake()
    {
        
    }
    private void Update()
    {
        if (!boss) 
        {
            wall.SetActive(false);
            caveExit.SetActive(true);            
        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            WinScene.globaltime = Mathf.Round(misc.GetComponent<Misc>().time);
            WinScene.winVariable = true;
            SceneManager.LoadScene(2);
            
        }
    }
}
