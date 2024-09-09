using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class WinScene : MonoBehaviour
{
    public static bool winVariable=false;
    public static float globaltime;
    public static int chestNUM=0;
    [SerializeField] TMP_Text youwin;
    [SerializeField] TMP_Text chest;
    [SerializeField] TMP_Text time;
    [SerializeField] Image chestimage;
   
    void Update()
    {
        if(winVariable)
        {

            youwin.text = "YOU WIN";
            chest.text = "x " + chestNUM.ToString(); 
            time.text=globaltime.ToString() + " Seconds";


        }
        else 
        {
            chestimage.enabled=false;
            chest.enabled = false;
            time.enabled=false;
        
        
        }

    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(1);
        winVariable = false;
        chestNUM = 0;
        globaltime = 0;

    }
}
