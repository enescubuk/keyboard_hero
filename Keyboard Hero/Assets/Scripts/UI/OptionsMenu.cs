using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
