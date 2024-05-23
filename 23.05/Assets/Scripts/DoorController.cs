using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public void OpenDoor()
    {
        GetComponent<Animator>().SetTrigger("Open");
        StartCoroutine(CloseDoor());
    }

    private IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(2f); // ����� �������� �����
        GetComponent<Animator>().SetTrigger("Close");
    }
}
