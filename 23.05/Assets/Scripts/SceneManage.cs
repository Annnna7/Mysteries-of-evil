using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public static int number = 0;
    public static int gameWin = 0;
    public static void PlusScene()
    {
        number++;
    }
    public static void PlusWin()
    {
        gameWin++;
    }
}
