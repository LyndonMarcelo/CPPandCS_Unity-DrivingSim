using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButtonBehavior : MonoBehaviour
{
    public RectTransform rectTransform;

    void Start ()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if(PlayButtonFunction.visibleOnScreen == 0)
        {
            rectTransform.localPosition = new Vector2(-1850, -150);
        }

        else
        {
            rectTransform.localPosition = new Vector2(0, -384);
        }
    }
}
