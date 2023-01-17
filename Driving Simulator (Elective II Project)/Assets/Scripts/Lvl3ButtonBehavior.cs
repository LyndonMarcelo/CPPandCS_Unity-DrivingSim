using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3ButtonBehavior : MonoBehaviour
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
            rectTransform.localPosition = new Vector2(580, 0);
        }

        else
        {
            rectTransform.localPosition = new Vector2(-1329, 196);
        }
    }

}
