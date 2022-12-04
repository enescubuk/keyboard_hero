using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guitarselect : MonoBehaviour
{
    public AchievementsControl AchievementsControl;
    public int a;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            Debug.Log(AchievementsControl.count);
        }
    }
}
