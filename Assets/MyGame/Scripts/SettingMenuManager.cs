using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingMenuManager : MonoBehaviour
{
    public TMP_Dropdown graphicsDropDown;


    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropDown.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
