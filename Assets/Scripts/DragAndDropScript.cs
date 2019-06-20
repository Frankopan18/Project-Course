using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDropScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject DraggedInstance;
    public DominantnaBoja dominantnaBoja;
    Vector3 _startPosition;
    Vector3 _offsetToMouse;
    public static Transform startParent;
    float _zDistanceToCamera;
    private Slot slot;

   


    #region Interface Implementations

    public void OnBeginDrag(PointerEventData eventData)
    {
        DraggedInstance = gameObject;
        _startPosition = transform.position;
        startParent = transform.parent;
        _zDistanceToCamera = Mathf.Abs(_startPosition.z - Camera.main.transform.position.z);

        _offsetToMouse = _startPosition - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, _zDistanceToCamera)
        );
        GetComponent<CanvasGroup>().blocksRaycasts = false;
   //     DraggedInstance.transform.SetParent(DraggedInstance.transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;

        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, _zDistanceToCamera)
            ) + _offsetToMouse;
     //   Debug.Log("tijekom draga:" + transform.parent.name);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _offsetToMouse = Vector3.zero;
    //    Debug.Log("Dragged instance sprite name:" + DraggedInstance.GetComponent<Image>().sprite.name);

        if (decideIfItsGood())
        {
            
        //        Debug.Log("tu smo");
      //          dominantnaBoja.audio.Play();
                DraggedInstance.SetActive(false);
                
        }
        else
        {
            transform.position = _startPosition;

        }
        DraggedInstance = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public bool decideIfItsGood()
    {
   //  Debug.Log("ime zivotinje:" + DraggedInstance.GetComponent<Image>().sprite.name + " i ime boje:" + transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name);
        if (DraggedInstance.GetComponent<Image>().sprite.name.Equals("pile") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("zuta"))
        {
            return true;
        }
        else if(DraggedInstance.GetComponent<Image>().sprite.name.Equals("papiga") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("crvena"))
        {
            return true;
        }else if (DraggedInstance.GetComponent<Image>().sprite.name.Equals("riba") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("plava"))
        {
            return true;
        }else if (DraggedInstance.GetComponent<Image>().sprite.name.Equals("svinja") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("ruzicasta"))
        {
            return true;
        }else if (DraggedInstance.GetComponent<Image>().sprite.name.Equals("macka") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("narancasta"))
        {
            return true;
        }else if (DraggedInstance.GetComponent<Image>().sprite.name.Equals("zaba") && transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name.Equals("zelena"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    #endregion
}