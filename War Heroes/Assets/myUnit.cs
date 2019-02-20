using UnityEngine;
using System.Collections;

public class myUnit : MonoBehaviour
{

    public int speed = 100;
    private Vector3 target;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Input.mousePosition;
            //target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}