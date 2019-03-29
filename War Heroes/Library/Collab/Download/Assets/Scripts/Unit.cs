using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected=false;

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
