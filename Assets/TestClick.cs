using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestClick : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Transform parentAfterDrag;
    public Vector3 startPos;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        startPos = this.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On Drag");
        transform.position = (Input.mousePosition);
        Debug.Log(transform.position.z);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
       transform.position = startPos;

    }
}
