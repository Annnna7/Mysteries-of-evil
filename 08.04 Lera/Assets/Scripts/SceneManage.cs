using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public static int number = 0;
    public static bool sudokuWin = false;
    public static bool puzzWin = false;
    public static bool diffWin = false;
    public static bool nextWin = false;
    public static void PlusScene()
    {
        number++;
    }
}
