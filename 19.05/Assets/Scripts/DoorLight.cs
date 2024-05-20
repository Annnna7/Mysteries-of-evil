using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLight : MonoBehaviour
{
    public int myNumber;
    void Update()
    { 
        if (myNumber != SceneManage.number)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }

        if(!ToggleExample.isLight)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
        
        if(ToggleExample.isLight && myNumber == SceneManage.number)
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
    }

}
