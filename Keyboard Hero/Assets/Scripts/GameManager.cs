using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float bpm,firstBpm;
    public GameObject line;
    [SerializeField] keyNotesSO keyNotesSO;
    int counter = -1;
    
    void Awake()
    {
        firstBpm = bpm;
        bpm = 60 / bpm;
        firstBpm = firstBpm / 15;

    }
    void Start()
    {
        InvokeRepeating("createLine",0,bpm);
        InvokeRepeating("createKey",0,bpm/2);
        
    }
    void createLine()
    {
        Instantiate(line,transform.position,Quaternion.identity);
    }
    void createKey()
    {
        counter++;
        if (counter < 31)
        {
            if (keyNotesSO.NoteKeys[counter] != 0)
            {
                GameObject instantiated = Instantiate(keyNotesSO.keyPrefabs[keyNotesSO.NoteKeys[counter]],new Vector3(transform.position.x,keyNotesSO.keyPrefabs[keyNotesSO.NoteKeys[counter]].transform.position.y,transform.position.z),Quaternion.identity);
            }
        }
    }
    
}
