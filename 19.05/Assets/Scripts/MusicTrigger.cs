using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;
    private void OnTriggerEnter(Collider other)
    {
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.playOnAwake = true;
        musicSource.loop = true;
        musicSource.PlayOneShot(musicClip);
        Destroy(GetComponent<SphereCollider>());
    }
}
