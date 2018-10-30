using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{

    


    public void OnPointerEnter(PointerEventData eventData)
    {


    }

    public void OnpointerExit(PointerEventData eventData)
    {


    }

    public void OnDrop(PointerEventData eventData)
    {
        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;

        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "card1")
        {
            Debug.Log("card 1 present");
        
        }
    }

}
    

