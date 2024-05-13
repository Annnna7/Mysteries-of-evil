using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactive : MonoBehaviour
{
    [SerializeField] float distance;
    RaycastHit hit;
    public AudioClip musicClip; 
    private AudioSource musicSource;
    //public Counter counter;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "AnimatedDoor")
                {
                    musicSource.PlayOneShot(musicClip);
                    Animator anim = hit.transform.GetComponent<Animator>();
                    anim.SetBool("Open", !anim.GetBool("Open"));
                }
            }
        }
    }

    /*[SerializeField] float distance;
    RaycastHit hit;
    public Counter counter;

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                if(hit.transform.tag == "AnimatedDoor")
                {
                    Animator anim = hit.transform.GetComponent<Animator>();
                    anim.SetBool("Open", !anim.GetBool("Open"));
                    if (SceneManage.number == 0)
                    {
                        SceneManager.LoadScene("Sudoku");
                        SceneManage.PlusScene();
                        return;
                    }
                    if (SceneManage.number == 1)
                    {
                        SceneManager.LoadScene("Differences");
                        SceneManage.PlusScene();
                        return;
                    }
                    if (SceneManage.number == 2)
                    {
                        SceneManager.LoadScene("SimpPuzz");
                        SceneManage.PlusScene();
                        return;
                    }
                    if (SceneManage.number == 3)
                    {
                        SceneManager.LoadScene("next");
                        SceneManage.PlusScene();
                        return;
                    }
                }
            }
        }
    }*/
}
