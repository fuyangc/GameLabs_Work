using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler {

    public void OnPointerEnter(PointerEventData eventData){


    }

    public void OnpointerExit(PointerEventData eventData){


    }

    public void OnDrop(PointerEventData eventData){
        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if(d !=null){
            d.parentToReturnTo = this.transform;

        }


    }
}
