using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class correctTimePress : MonoBehaviour
{

    public void correctPressNormalNote(GameObject button)
    {
        GameObject instantiated =
            Instantiate(button, button.transform.position, Quaternion.identity);
        instantiated.GetComponent<noteMovement>().enabled = false;
        instantiated.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 1, 2, 2);
        instantiated.GetComponent<Collider2D>().enabled = false;
        Destroy(instantiated,0.3f);
        button.GetComponent<SpriteRenderer>().color = new Color(10,10,10);
        
        //Destroy(button);
    }
    public void missPressNormal()
    {
        
    }
    public void correctPressHolderNote(GameObject button)
    {
        //Debug.Log(button.name + " objesine animasyon uygula");
        //Destroy(button);
    }
}
