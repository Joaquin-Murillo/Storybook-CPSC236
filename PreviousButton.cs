using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousButton : MonoBehaviour
{
    public StorybookBackground background;
    public void OnClick()
    {
        background.PreviousButtonClick();
    }
}