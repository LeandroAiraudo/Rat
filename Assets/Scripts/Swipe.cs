using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Swipe : MonoBehaviour
{
    [SerializeField]
    private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    [SerializeField]
    private bool isDraging = false;
    [SerializeField]
    public Vector2 startTouch, swipeDelta;
    
 
    public void Update()
    {
        tap = swipeLeft = swipeDown = swipeRight = swipeUp = false;
 
        #region Standalone Inputs
        if(Input.GetMouseButtonDown(0))
        {
            tap = true;
            isDraging = true;
            
            startTouch = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            Reset();
        }
        #endregion
 
        #region  Mobile Inputs
        if (Input.touches.Length > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                isDraging = true;
                tap = true;
                //startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Reset();
            }
        }
        #endregion
   
        // Calcula la distancia
        //swipeDelta = Vector2.zero;
        
        if (isDraging)
        {
            if(Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            if(Input.GetMouseButton(0))
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
        }
 
        // Cruzamos la zona?
        //if(swipeDelta.magnitude > 50)
        
        
        //{  
            // en q direccion?
            float x = (swipeDelta.x);
            float y = (swipeDelta.y);
            
            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                // derecha o izquierda
                if(x < 0)
                    swipeLeft = true;
                else if(x > 0)
                    swipeRight = true;
            }
            else
            {
                //arriba o abajo
                if (y < 0) 
                    swipeDown = true;
                else if (y > 0)
                    swipeUp = true;
            }
 
 
            //Reset();
        //}
    }
 
 
    public void Reset()
    {
        startTouch = Vector2.zero;
        swipeDelta = Vector2.zero;
    }
 
    public Vector2 SwipeDelta { get {return swipeDelta; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }


    
}


