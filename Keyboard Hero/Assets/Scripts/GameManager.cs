using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float bpm,firstBpm;
    public GameObject line;
    [SerializeField] keyNotesSO keyNotesSO;
    public int counter = 0;
    
    void Awake()
    {
        firstBpm = bpm;
        bpm = 60 / bpm;
        firstBpm = firstBpm / 20;

    }
    void Start()
    {
        InvokeRepeating("createLine",0,bpm*4);
        InvokeRepeating("createKey",0,bpm);
        
    }
    void createLine()
    {
        Instantiate(line,transform.position,Quaternion.identity);
    }
    void createKey()
    {
        counter++;
        if (counter <= keyNotesSO.NoteKeys.Count)
        {
            if (keyNotesSO.NoteKeys[counter] != 0)
            {
                GameObject instantiated = Instantiate(keyNotesSO.keyPrefabs[keyNotesSO.NoteKeys[counter]],new Vector3(transform.position.x,keyNotesSO.keyPrefabs[keyNotesSO.NoteKeys[counter]].transform.position.y,transform.position.z),Quaternion.identity);
            }
            
        }
    }
    
}
