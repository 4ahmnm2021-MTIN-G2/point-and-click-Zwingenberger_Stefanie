using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 mouseCameraPos;
    public float speed = 0.3f;
    private Vector3 playerPos;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            var newPos = Camera.main.ScreenToWorldPoint(mousePos);
            playerPos = new Vector3(newPos.x, newPos.y, this.gameObject.transform.position.z);

        }
            this.transform.position = Vector3.MoveTowards(this.transform.position,playerPos,speed);
    }
}
