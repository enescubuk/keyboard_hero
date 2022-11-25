using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]MusicController musicController;
    public float bpm;
    void Awake()
    {
        bpm = bpm / 360;
    }
}
