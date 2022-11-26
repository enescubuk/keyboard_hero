using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctTimePress : MonoBehaviour
{

    public void correctPressNormalNote(GameObject button)
    {
        Debug.Log(button.name + " objesine animasyon uygula");
        button.GetComponent<SpriteRenderer>().color = new Color(10,10,10);
        //Destroy(button);
    }
    public void correctPressHolderNote(GameObject button)
    {
        //Debug.Log(button.name + " objesine animasyon uygula");
        //Destroy(button);
    }
}
