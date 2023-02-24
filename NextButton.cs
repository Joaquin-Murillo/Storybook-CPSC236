using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public StorybookBackground background;
    public void OnClick()
    {
        background.NextButtonClick();
    }
}
