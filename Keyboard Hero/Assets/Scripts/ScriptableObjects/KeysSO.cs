using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Game/Keys")]
public class KeysSO : ScriptableObject
{
    public KeyCode[] keys = new KeyCode[8];
}
