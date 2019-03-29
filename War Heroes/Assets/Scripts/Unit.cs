using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected=false;
    private bool move = false;
    //public GameObject unit; //Keep in mind that we drag-drop the tile in inspector
    //attributes
    public int health;
    public int defense;
    public int range;
    public int speed;
    public int attack;
    public int title;

    public bool Selected
    {
        get { return selected; }
        set { selected = value; }
    }

    public bool Move
    {
        get { return move; }
        set { move = value; }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            print("pos" + mousePos.x+"  "+ mousePos.y);
            if ((Mathf.Abs(mousePos.x- this.transform.position.x) < 5)&& (Mathf.Abs(mousePos.y - this.transform.position.y) < 5))
            {
                print("hit");
                if (selected == false) { 
                    selected = true;
                    gameObject.GetComponent<Renderer>().material.color = new Color(0.2F, 0.3F, 0.4F, 0.5F);
                }
                else if (selected == true)
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
                    selected = false;
                }
                    
            }
            /**
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mousePos2D = new Vector3(mousePos.x, mousePos.y, mousePos.z);

            Vector3 imp = new Vector3(0,0,-1);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, imp);
            if (hit.collider != null)
            {
                print(hit.collider);
                Debug.Log(hit.collider.gameObject.name);
                //hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        **/
        }
        /**
        if (Input.GetMouseButtonDown(0))
        {
            if(selected==false)
                selected = true;
            else if (selected == true)
                selected = false;
        }
    **/
    }


    }
