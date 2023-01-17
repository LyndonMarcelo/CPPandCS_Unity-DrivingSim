using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonFunction : MonoBehaviour
{
    public RectTransform rectTransform;

    public void buttonClick()
    {
        rectTransform.localPosition = new Vector2(-1329, -497);
        PlayButtonFunction.visibleOnScreen = 1;        
    }
}
