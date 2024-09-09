using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    float time=0;
    float cooldown = 5.1f;
    float barriertime = 5f;
    bool barrierActivation;
    public GameObject sphere;
    [SerializeField] Image cooldownbar;
    [SerializeField] GameObject countdownGameObject;
    [SerializeField] Text countdownUI;
    [SerializeField] GameObject descriptiontext;
    private void Update()
    {

        if (gameObject == null) return;
        

        if (!barrierActivation) 
        {
            cooldownbar.fillAmount = time/cooldown;
        }
      
        if (time > cooldown) 
        {
            time = 0;
            barrierActivation = true;
        
        }
        if(time< barriertime && barrierActivation) 
        {
            sphere.SetActive(true);
            cooldownbar.fillAmount = 1;
            countdownGameObject.SetActive(true);
            countdownUI.text=(Mathf.Ceil(barriertime - time)).ToString();
            descriptiontext.SetActive(true);
        }
        else if(time > barriertime && barrierActivation) 
        {
            countdownGameObject.SetActive(false);
            barrierActivation = false;
            sphere.SetActive(false);
            time = 0;
            descriptiontext.SetActive(false);
        }

        time = time + Time.deltaTime;
    }

}
