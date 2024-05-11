using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform PonitA;
    public Transform PonitB;
    public Transform PonitC;
    public Transform PonitD;
    public Transform PonitE;
    public float speed = 20f;
    private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = PonitA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == PonitA.position)
        {
            targetPos = PonitB.position;
        }
        if (transform.position == PonitB.position)
        {
            targetPos = PonitC.position;
        }
        if (transform.position == PonitC.position)
        {
            targetPos = PonitD.position;
        }
        if (transform.position == PonitD.position)
        {
            targetPos = PonitE.position;
        }
        if (transform.position == PonitE.position)
        {
            targetPos = PonitA.position;
        }


        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
        transform.LookAt(targetPos);

    }
}
