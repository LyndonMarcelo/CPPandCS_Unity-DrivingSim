using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearIndicatorUI : MonoBehaviour
{
    //public float HorizontalSpeed = 1 ;
    //public float MaxHorizontalPosition = 200 ;
    //public float MinHorizontalPosition = -200 ;
    public float scrollVal;
    public static int GearSelector = 1;
 
    // Please, name correctly your variables.
    // Yourself, in 3 months will be grateful    
    private RectTransform rectTransform;
 
    void Start ()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector2(454, -444);
    }
 
    void Update ()
    {

        scrollVal = Input.mouseScrollDelta.y;

        if(scrollVal > 0)
        {
            if(GearSelector==2)
            {
                GearSelector=2;
            }

            else
            {
                GearSelector++;
            }


        }

        else if(scrollVal < 0)
        {
            if(GearSelector==0)
            {
                GearSelector=0;
            }

            else
            {
                GearSelector--;
            }
    
        }

        if(GearSelector==1)
        {
            rectTransform.localPosition = new Vector2(454, -359);
        }
        
        else if(GearSelector==0)
        {
            rectTransform.localPosition = new Vector2(454, -444);
        }

        else if(GearSelector==2)
        {
            rectTransform.localPosition = new Vector2(454, -274);
        }

    }
}
