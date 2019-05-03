using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class objectTransition : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Button start;
    public UnityEngine.UI.Button options;
    public UnityEngine.UI.Button quit;
    public UnityEngine.UI.Image Rhombus;
    public UnityEngine.UI.Image Warrior;
    public UnityEngine.UI.Image Archer;
    public GameObject voltext;
    public UnityEngine.UI.Button back;
    public UnityEngine.UI.Slider volume;
    private bool clicked;
    private bool done;
    private bool bckbutt;
    private bool redone;
    void Start()
    {
        clicked = false;
        done = false;
        bckbutt = false;
        redone = false;
    }
    public void backbutton()
    {
        bckbutt = true;
        redone = false;
        if (start.transform.position.x >= 422.5f && start.transform.position.y >= 310.5f)
        {
            start.transform.position = start.transform.position + new Vector3(-2f, -1.5f, 0);
        }

        if (quit.transform.position.x <= 420.5f && quit.transform.position.y <= 145.5f)
        {
            //print(start.transform.position);
            quit.transform.position = quit.transform.position + new Vector3(3f, 1.5f, 0);
        }

        if (options.transform.position.x != 421.5f && options.transform.position.y != 222.0f)
        {
            //print(start.transform.position);
            options.transform.position = Vector3.MoveTowards(options.transform.position,new Vector3(421.5f,222.0f),170*Time.deltaTime);
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
        if (back.transform.position.y != -36.0f)
        {
            back.transform.position = Vector3.MoveTowards(back.transform.position, new Vector3(back.transform.position.x, -36.0f), 200 * Time.deltaTime);
        }
        if (voltext.transform.position.x != -19.5f)
        {
            voltext.transform.position = Vector3.MoveTowards(voltext.transform.position, new Vector3(-19.5f, voltext.transform.position.y), 200 * Time.deltaTime);
        }
        if (volume.transform.position.y != 472.4f)
        {
            volume.transform.position = Vector3.MoveTowards(volume.transform.position, new Vector3(volume.transform.position.x, 472.4f), 200 * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        print(clicked+" "+done);
        if (clicked == false && bckbutt==false)
        {
            if (start.transform.position.x >= 422.5f && start.transform.position.y >= 310.5f)
            {
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
        if (clicked == true && done==false)
        {
            Settings();
            if(Rhombus.transform.position.x<-309.5)
            {
                done = true;
                print(voltext.transform.position);
                GameObject.Find("Settings").GetComponent<Button>().enabled = false;
                bckbutt = false;
            }
                
        }
        if (bckbutt==true && redone == false)
        {
            backbutton();
            if (options.transform.position.x >= 420.4f)
            {
                redone = true;
                print("hi");
                GameObject.Find("Settings").GetComponent<Button>().enabled = true;
                clicked = false;
            }
        }
    }
    public void Settings()
    {
        clicked = true;
        done = false;
        if (Warrior.transform.position.x != -287.2f)
        {
            Warrior.transform.position = Vector3.MoveTowards(Warrior.transform.position, new Vector3(-287.2f, Warrior.transform.position.y), 200 * Time.deltaTime);
        }
        if (Archer.transform.position.x != 1016.5f)
        {
            Archer.transform.position = Vector3.MoveTowards(Archer.transform.position, new Vector3(1016.5f, Archer.transform.position.y), 200 * Time.deltaTime);
        }
        if (Rhombus.transform.position.x != -309.6f)
        {
            Rhombus.transform.position = Vector3.MoveTowards(Rhombus.transform.position, new Vector3(-309.6f, Rhombus.transform.position.y), 300 * Time.deltaTime);
        }
        if (start.transform.position != new Vector3(570.5f,456.0f))
        {
            start.transform.position = Vector3.MoveTowards(start.transform.position, new Vector3(570.5f, 456.0f), 200 * Time.deltaTime);
        }
        if (quit.transform.position != new Vector3(164.5f, -43.9f))
        {
            quit.transform.position = Vector3.MoveTowards(quit.transform.position, new Vector3(164.5f, -43.9f), 200 * Time.deltaTime);
        }
        if (options.transform.position != new Vector3(200.0f, 350.0f))
        {
            options.transform.position = Vector3.MoveTowards(options.transform.position, new Vector3(200.0f, 350.0f), 200 * Time.deltaTime);
        }
        if (back.transform.position.y != 100.9f)
        {
            back.transform.position = Vector3.MoveTowards(back.transform.position, new Vector3(back.transform.position.x, 100.9f), 200 * Time.deltaTime);
        }
        if (voltext.transform.position.x != 200.0f)
        {
            voltext.transform.position = Vector3.MoveTowards(voltext.transform.position, new Vector3(200.0f, voltext.transform.position.y), 200 * Time.deltaTime);
        }
        if (volume.transform.position.y != 220.0f)
        {
            volume.transform.position = Vector3.MoveTowards(volume.transform.position, new Vector3(volume.transform.position.x, 220.0f), 200 * Time.deltaTime);
        }
    }
}
