using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == door1)
        {
            // Actions when logging in to door1
            Debug.Log("The character entered door1 and exited door2");
            door2.GetComponent<Animator>().SetTrigger("Open");
        }
        else if (other.gameObject == door2)
        {
            // Actions when logging in to door2
            Debug.Log("The character entered door2 and exited door1");
            door1.GetComponent<Animator>().SetTrigger("Open");
        }
    }
}
