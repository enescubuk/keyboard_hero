using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Music/Note Keys" , fileName = "your_music_name_notes")]
public class keyNotesSO : ScriptableObject
{
    public List<int> NoteKeys = new List<int>();
    public List<GameObject> keyPrefabs = new List<GameObject>();
}
