﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler {

    public void OnBeginDrag(PointerEventData eventData){
        this.transform.SetParent(this.transform.parent.parent);

    }
    public void OnDrag (PointerEventData eventData)
    {
        this.transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData){


    }

}
