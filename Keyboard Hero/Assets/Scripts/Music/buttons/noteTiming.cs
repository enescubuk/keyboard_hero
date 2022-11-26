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
        if (other.transform.parent != null)
        {
            detectObject = other.transform.parent.gameObject;
        }
        else
        {
            detectObject = other.gameObject;
        }
        canPress = true;
        detectObjectName(detectObject);
    }
    void Update()
    {
        if (canPress)
        {
            Debug.Log(keysSO.keys[keyArrayNumber]);
            if (Input.GetKeyDown(keysSO.keys[keyArrayNumber]))
            {
                
                if (detectObject.name.Contains("hold"))
                {
                    holdingIcon(detectObject);
                    holdingNote(false,true);
                }
            }
            if (Input.GetKeyUp(keysSO.keys[keyArrayNumber]))
            {
                
                holdingNote(true,false);
                correctTimePress.correctPressNormalNote(detectObject);
                
                if (detectObject.name.Contains("hold"))
                {
                    detectObject.transform.GetChild(0).GetComponent<Collider2D>().enabled = false;
                }
                else
                {
                    detectObject.GetComponent<Collider2D>().enabled = false;
                }
            }
        }
    }

    private void holdingIcon(GameObject detectObject)
    {
        Vector3 firstPosChild = detectObject.transform.GetChild(0).position;
        detectObject.transform.position = transform.position;
        detectObject.transform.GetChild(0).position = firstPosChild;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        canPress = false;
        if (detectObject.transform.childCount >= 1)
        {
            holdingNote(true,false);
            correctTimePress.correctPressHolderNote(other.transform.parent.gameObject);
        }
    }

    
    private void holdingNote(bool parentBool,bool childBool)
    {
        detectObject.GetComponent<noteMovement>().enabled = parentBool;
        if (detectObject.transform.childCount >= 1)
        {
            detectObject.transform.GetChild(0).GetComponent<noteMovement>().enabled = childBool;
        }
    }


    private void detectObjectName(GameObject other)
    {
        
        if (other.gameObject.name.Contains("Alpha1"))
        {
            keyArrayNumber = 0;
        }
        else if (other.gameObject.name.Contains("Alpha2"))
        {
            keyArrayNumber = 1;
        }
        else if (other.gameObject.name.Contains("Alpha3"))
        {
            keyArrayNumber = 2;
        }
        else if (other.gameObject.name.Contains("Alpha4"))
        {
            keyArrayNumber = 3;
        }
        else if (other.gameObject.name.Contains("LeftArrow"))
        {
            keyArrayNumber = 4;
        }
        else if (other.gameObject.name.Contains("UpArrow"))
        {
            keyArrayNumber = 5;
        }
        
        else if (other.gameObject.name.Contains("DownArrow"))
        {
            keyArrayNumber = 6;
        }
        
        else if (other.gameObject.name.Contains("RightArrow"))
        {
            keyArrayNumber = 7;
        }
    }
}
