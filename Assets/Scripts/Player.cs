using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 mouseCameraPos;
    public float speed = 0.1f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mouseCameraPos = Camera.main.ScreenToWorldPoint(mousePos);
            this.transform.position = Vector3.MoveTowards(this.transform.position,mouseCameraPos,speed);
        }
    }
}
