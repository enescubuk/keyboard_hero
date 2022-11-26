using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTransitions : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject OptionsCanvas;
    public static bool CloseControl = false;

    public void OptionsButton()
    {
        StartCoroutine(CloseButton());
    }

    IEnumerator CloseButton()
    {
        CloseControl = true;
        yield return new WaitForSeconds(1.5f);
        MainMenuCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }
}
