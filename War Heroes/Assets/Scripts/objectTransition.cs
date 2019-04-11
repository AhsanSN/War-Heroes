﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransition : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Button start;
    public UnityEngine.UI.Button options;
    public UnityEngine.UI.Button quit;
    public UnityEngine.UI.Image Rhombus;
    public UnityEngine.UI.Image Warrior;
    public UnityEngine.UI.Image Archer;
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        if (start.transform.position.x >= 422.5f && start.transform.position.y >= 310.5f)
        {
            print(start.transform.position);
            start.transform.position = start.transform.position + new Vector3(-2f, -1.5f, 0);
        }

        if (quit.transform.position.x <= 420.5f && quit.transform.position.y <= 145.5f)
        {
            //print(start.transform.position);
            quit.transform.position = quit.transform.position + new Vector3(3f, 1.5f, 0);
        }

        if (options.transform.position.x <= 420.5f && options.transform.position.y <= 245.5f)
        {
            //print(start.transform.position);
            options.transform.position = options.transform.position + new Vector3(3, 3, 0);
        }
        if (Rhombus.transform.position.x <= 300.5f)
        {
            Rhombus.transform.position = Rhombus.transform.position + new Vector3(8, 0, 0);
        }
        if (Warrior.transform.position.x <= 160.5f)
        {
            Warrior.transform.position = Warrior.transform.position + new Vector3(5, 0, 0);
        }
        if (Archer.transform.position.x >= 600.5f)
        {
            Archer.transform.position = Archer.transform.position + new Vector3(-5, 0, 0);
        }
    }
}