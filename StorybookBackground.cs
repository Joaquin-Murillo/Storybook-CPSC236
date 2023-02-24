using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorybookBackground : MonoBehaviour
{
    public GameObject PreviousButton;
    public GameObject NextButton;
    public RawImage Image1;
    public RawImage Image2;
    public RawImage Image3;
    public RawImage Image4;
    public RawImage Image5;
    public RawImage Image6;
    public RawImage Image7;
    public RawImage Image8;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text Text5;
    public Text Text6;
    public Text Text7;
    public Text Text8;
    private int pageCount = 1;

    public void NextButtonClick()
    {
        pageCount++;
        CheckPage();
    }
    
    public void PreviousButtonClick()
    {
        pageCount--;
        CheckPage();
    }

    private void CheckPage()
    {
        switch (pageCount)
        {
            case 1:
                Image1.enabled = true;
                Image2.enabled = false;
                Text2.enabled = false;
                Text1.enabled = true;
                PreviousButton.SetActive(false);
                break;
            
            case 2:
                Image1.enabled = false;
                Image2.enabled = true;
                Text3.enabled = false;
                Text1.enabled = false;
                Text2.enabled = true;
                PreviousButton.SetActive(true);
                break;
            
            case 3:
                Image2.enabled = false;
                Image3.enabled = true;
                Text4.enabled = false;
                Text3.enabled = true;
                Text2.enabled = false;
                break;
            
            case 4:
                Image3.enabled = false;
                Image4.enabled = true;
                Text5.enabled = false;
                Text4.enabled = true;
                Text3.enabled = false;
                break;
            
            case 5:
                Image4.enabled = false;
                Image5.enabled = true;
                Text6.enabled = false;
                Text5.enabled = true;
                Text4.enabled = false;
                break;
            
            case 6:
                Image5.enabled = false;
                Image6.enabled = true;
                Text7.enabled = false;
                Text6.enabled = true;
                Text5.enabled = false;
                break;
            
            case 7:
                Image6.enabled = false;
                Image7.enabled = true;
                Text7.enabled = true;
                Text8.enabled = false;
                Text6.enabled = false;
                NextButton.SetActive(true);
                break;
            
            case 8:
                Image7.enabled = false;
                Image8.enabled = true;
                Text8.enabled = true;
                Text7.enabled = false;
                NextButton.SetActive(false);
                break;
        }

    }
    
}
