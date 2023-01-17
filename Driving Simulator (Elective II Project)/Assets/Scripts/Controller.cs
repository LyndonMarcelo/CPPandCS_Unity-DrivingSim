using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    int GearSelector = 1;

    public float Speed = 10f;

    private Transform localTrans;


    // Start is called before the first frame update
    void Start()
    {
        localTrans=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(GearSelector==2)
            {
                GearSelector=2;
            }

            else
            {
                GearSelector++;
            }

            Debug.Log(GearSelector);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(GearSelector==0)
            {
                GearSelector=0;
            }

            else
            {
                GearSelector--;
            }

            Debug.Log(GearSelector);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if(GearSelector==2)
            {
                localTrans.position += localTrans.forward * Speed * Time.deltaTime;
            }

            if(GearSelector==0)
            {
                localTrans.position += localTrans.forward * -1 * Speed * Time.deltaTime;
            }

            
        }

    }
}
