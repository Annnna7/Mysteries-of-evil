using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinity : MonoBehaviour
{
    RaycastHit hit;
    public GameObject otherDoor;

    private void OnTriggerEnter(Collider other)
    {
        Animator anim = hit.transform.GetComponent<Animator>();
        if (anim.GetBool("Open"))
        {
            other.transform.position = otherDoor.transform.position;
        }
        else if (other.CompareTag("Exit"))
        {
            other.transform.position = transform.position;
        }
    }
}
