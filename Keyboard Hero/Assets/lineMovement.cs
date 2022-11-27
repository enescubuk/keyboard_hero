using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineMovement : MonoBehaviour
{
    GameManager gameManager => GameObject.Find("GameManager").GetComponent<GameManager>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-gameManager.firstBpm * Time.deltaTime,0,0));
    }
}
