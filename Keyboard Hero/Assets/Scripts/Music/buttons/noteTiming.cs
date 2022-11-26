using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteTiming : MonoBehaviour
{
    [SerializeField] KeysSO keysSO;
    private correctTimePress correctTimePress;
    bool canPress;
    int keyArrayNumber;
    private GameObject detectObject;
    
    void Awake()
    {
        correctTimePress = GetComponent<correctTimePress>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        detectObject = other.gameObject;
        canPress = true;
        detectObjectName(other.gameObject);
    }


    void OnTriggerExit2D(Collider2D other)
    {
        canPress = false;
        if (detectObject.transform.childCount == 1)
        {
            Debug.Log(3131313);
            holdingNote(true,false);
        }
    }

    void Update()
    {
        if (canPress)
        {
            if (Input.GetKeyDown(keysSO.keys[keyArrayNumber]))
            {
                correctTimePress.corretPress(this.gameObject);
                if (detectObject.name.Contains("hold"))
                {
                    detectObject.transform.position = transform.position;
                    holdingNote(false,true);
                }
            }
            if (Input.GetKeyUp(keysSO.keys[keyArrayNumber]))
            {
                holdingNote(true,false);
            }
        }
    }
    private void holdingNote(bool parentBool,bool childBool)
    {
        detectObject.GetComponent<noteMovement>().enabled = parentBool;
        if (detectObject.transform.childCount == 1)
        {
            detectObject.transform.GetChild(0).GetComponent<noteMovement>().enabled = childBool;
        }
    }


    private void detectObjectName(GameObject other)
    {
        if (other.gameObject.name.Contains("LeftArrow"))
        {
            keyArrayNumber = 4;
        }
        else if (other.gameObject.name.Contains("1"))
        {
            keyArrayNumber = 0;
        }
        else if (other.gameObject.name.Contains("UpArrow"))
        {
            keyArrayNumber = 5;
        }
        else if (other.gameObject.name.Contains("2"))
        {
            keyArrayNumber = 1;
        }
        else if (other.gameObject.name.Contains("DownArrow"))
        {
            keyArrayNumber = 6;
        }
        else if (other.gameObject.name.Contains("3"))
        {
            keyArrayNumber = 2;
        }
        else if (other.gameObject.name.Contains("RightArrow"))
        {
            keyArrayNumber = 7;
        }
        else if (other.gameObject.name.Contains("4"))
        {
            keyArrayNumber = 3;
        }
        
    }
}
