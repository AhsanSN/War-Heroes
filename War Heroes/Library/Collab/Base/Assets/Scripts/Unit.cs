using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected=false;
    public bool Selected
    {
        get { return selected; }
        set { selected = value; }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(selected==false)
                selected = true;
            else if (selected == true)
                selected = false;
        }
    }
}
