using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteController : MonoBehaviour
{
    [SerializeField] keyNotesSO keyNotesSO;
    public Vector2 distance;
    GameManager gameManager => GameObject.Find("GameManager").GetComponent<GameManager>();

    void Start()
    {
        for (int i = 0; i < keyNotesSO.NoteKeys.Count; i++)
        {
            if (keyNotesSO.NoteKeys[i] != 0)
            {
                GameObject key = Instantiate(keyNotesSO.keyPrefabs[keyNotesSO.NoteKeys[i]]);
                key.transform.position = new Vector3(transform.position.x + 10 * (i + 1),transform.position.y,transform.position.z);
            }
        }
    }
}
