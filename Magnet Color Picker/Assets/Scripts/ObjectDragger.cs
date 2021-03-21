using UnityEngine;
using System.Collections;
 
public class ObjectDragger : MonoBehaviour 
{
    //public bool isX;
    //public bool isY;

    //private Vector3 screenPoint;
    //private Vector3 offset;

    Vector3 pos_move;
    public static bool isDrag;

    public static bool isMouseDown;
      public static bool isMouseUp;
    private void Start()
    {
        isDrag = true;
        isMouseDown = false;
        isMouseUp = false;
    }
   
    private void OnMouseDown()
    {
        isMouseDown = true;
        isMouseUp = false;
        print("Mouse Down");

    }
    private void OnMouseUp()
    {
        isMouseUp = true;
        isMouseDown = false;


    }

    private Vector3 distance;


    //void OnMouseDown()
    //{
    //    //distance = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) - transform.position;
    //    //distance = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //    //transform.position = new Vector3(transform.position.y, transform.position.y, transform.position.z);

    //}

    void OnMouseDrag()
    {
        if (isDrag)
        {
            Vector3 distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen.z));
            transform.position = new Vector3(pos_move.x - distance.x, transform.position.y, pos_move.z);

        }

    }

    //   void OnMouseDown()
    //{
    //       screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //       //screenPoint = Input.mousePosition;
    //       offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));


    //}

    //void OnMouseDrag()
    //{
    //       Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    //       transform.position = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;



    //}

}