using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] GameObject ruleswindow; 
    private void Update()
    {
        

        if (Input.anyKey) 
        {
            ruleswindow.SetActive(false);
        
        }

    }

    public void StartGame() 
    {
        SceneManager.LoadScene(0);


    }

    public void Rules()
    {

        ruleswindow.SetActive(true);

    }


}
