using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float bpm;
    void Awake()
    {
        bpm = bpm / 60;
    }
}
