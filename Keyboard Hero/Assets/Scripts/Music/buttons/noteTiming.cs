using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteTiming : MonoBehaviour
{
    [SerializeField] musicControllerSO musicControllerSO;
    [SerializeField] KeysSO keysSO;
    private correctTimePress correctTimePress;
    bool canPress;
    string whichKey;
    int keyArrayNumber;
    
    void Awake()
    {
        correctTimePress = GetComponent<correctTimePress>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        canPress = true;
        detectObjectName(other);
        Debug.Log("a");
    }


    void OnTriggerExit2D(Collider2D other)
    {
        canPress = false;

        Debug.Log("b");
    }

    void Update()
    {
        if (canPress)
        {
            if (Input.GetKeyDown(keysSO.keys[keyArrayNumber]))
            {
                correctTimePress.corretPress(this.gameObject);
            }
        }
    }


    private void detectObjectName(Collider2D other)
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
