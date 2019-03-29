using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected=false;
    private bool move = false;
    //attributes
    public class UnitMain
    {
        public int health;
        public int defense;
        public int range;
        public int speed;
        public int attack;
        public int name;

        public UnitMain(int name_i, int health_i, int attack_i, int defense_i, int range_i, int speed_i)
        {
            health = health_i;
            name = name_i;
            attack = attack_i;
            defense = defense_i;
            range = range_i;
            speed = speed_i;
        }
    }

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
            Vector3 mousePos2D = new Vector3(mousePos.x, mousePos.y, mousePos.z);

            Vector3 imp = new Vector3(0,0,-1);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, imp);
            if (hit.collider != null)
            {
                print(hit.collider);
                Debug.Log(hit.collider.gameObject.name);
                //hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
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
