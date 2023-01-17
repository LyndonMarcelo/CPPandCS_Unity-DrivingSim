using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonFunction : MonoBehaviour
{

    public static int visibleOnScreen = 1;
    public RectTransform rectTransform;

    public void buttonClick()
    {
        rectTransform.localPosition = new Vector2(-1850, -30);
        visibleOnScreen = 0;
        Debug.Log(visibleOnScreen);
    }

    void Update()
    {
        if(visibleOnScreen == 1)
        {
            rectTransform.localPosition = new Vector2(0, -31);
        }

    }
}
