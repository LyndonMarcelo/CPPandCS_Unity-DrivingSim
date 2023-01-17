using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonBehavior : MonoBehaviour
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
            rectTransform.localPosition = new Vector2(0, -460);
        }
    }
}
