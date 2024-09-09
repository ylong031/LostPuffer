using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Misc : MonoBehaviour
{
    public float time;
    [SerializeField] TextMeshProUGUI uitext;
    void Start()
    {
        
    }

    
    void Update()
    {
        time = time + Time.deltaTime;
        uitext.text= Mathf.Round(time).ToString();
    }
}
