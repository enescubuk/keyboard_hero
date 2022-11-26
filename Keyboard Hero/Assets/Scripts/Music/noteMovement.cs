using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteMovement : MonoBehaviour
{
    private GameManager gameManager;
    public float speed;
    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        transform.Translate(new Vector3(-gameManager.bpm * Time.deltaTime * speed,0,0));
    }

}
