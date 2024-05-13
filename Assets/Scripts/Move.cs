using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rBody2;

    Vector3 p;
    bool isMove = false;
    int a = 5; 
    void Update()
    {
/*        if (Input.GetMouseButtonDown(0)) isMove = true;
        else if (Input.GetMouseButtonUp(0)) isMove = false;

        if (isMove)
        {
            p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            p.z = 0;
            rBody2.velocity = (p - rBody2.transform.position);
        }*/

        Vector2 cur = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cur.x, cur.y);
    }

    private void Start()
    {
        Debug.Log(--a + "   " + a--);
    }
}
