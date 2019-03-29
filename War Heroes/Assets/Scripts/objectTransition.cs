using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransition : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Button start;
    public UnityEngine.UI.Button join;
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
        if (start.transform.position.x >= 420.5f && start.transform.position.y >= 345.5f)
        {
            //print(start.transform.position);
            start.transform.position = start.transform.position + new Vector3(-2f, -1f, 0);
        }

        if (join.transform.position.x >= 420.5f && join.transform.position.y >= 245.5f)
        {
            //print(start.transform.position);
            join.transform.position = join.transform.position + new Vector3(-2, -2, 0);
        }
        if (quit.transform.position.x <= 420.5f && quit.transform.position.y <= 145.5f)
        {
            print(start.transform.position);
            quit.transform.position = quit.transform.position + new Vector3(2f, 1f, 0);
        }

        if (options.transform.position.x <= 420.5f && options.transform.position.y <= 245.5f)
        {
            //print(start.transform.position);
            options.transform.position = options.transform.position + new Vector3(2, 2, 0);
        }
        if (Rhombus.transform.position.x <= 360.5f)
        {
            Rhombus.transform.position = Rhombus.transform.position + new Vector3(8, 0, 0);
        }
        if (Warrior.transform.position.x <= 160.5f)
        {
            Warrior.transform.position = Warrior.transform.position + new Vector3(5, 0, 0);
        }
        if (Archer.transform.position.x >= 700.5f)
        {
            Archer.transform.position = Archer.transform.position + new Vector3(-5, 0, 0);
        }
    }
}
