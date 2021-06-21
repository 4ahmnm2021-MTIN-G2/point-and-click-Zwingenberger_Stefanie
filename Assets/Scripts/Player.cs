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


            var newPos = this.gameObject.transform.position;
            mousePos = Input.mousePosition;
            if (CastRay() != "moveblock")
            {
            newPos = Camera.main.ScreenToWorldPoint(mousePos);
            }
            playerPos = new Vector3(newPos.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, playerPos, speed);

    }

    private string CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit.collider != null)
        {
            return hit.collider.gameObject.tag;
        }
        return null;

    }
}
