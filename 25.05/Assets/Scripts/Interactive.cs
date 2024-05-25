using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactive : MonoBehaviour
{
    [SerializeField] float distance;
    RaycastHit hit;

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "AnimatedDoor")
                {
                    Animator anim = hit.transform.GetComponent<Animator>();
                    if (anim != null)
                    {
                        anim.SetBool("Open", !anim.GetBool("Open"));
                        AudioManager.instance.Play("Door");
                    }
                }
            }
        }
    }
}
