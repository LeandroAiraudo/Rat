using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    public float speed;
    public Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
 
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (swipeControls.SwipeLeft)
            m_Rigidbody.MovePosition(player.position + (Vector3.left*Time.deltaTime*speed));
        if (swipeControls.SwipeRight)
            m_Rigidbody.MovePosition(player.position + (Vector3.right*Time.deltaTime*speed));
        if (swipeControls.SwipeUp)
            m_Rigidbody.MovePosition(player.position + (Vector3.forward*Time.deltaTime*speed));
        if (swipeControls.SwipeDown)
            m_Rigidbody.MovePosition(player.position + (Vector3.back*Time.deltaTime*speed));
 
        //player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
 
    }

    
}

