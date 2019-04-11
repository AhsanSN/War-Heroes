using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Unit : MonoBehaviour
{

    Animator anim;
    int idleHash;
    int walkHash;
    int attackHash;
    int defendHash;
    int powerHash;
    int deadHash;
    int runStateHash = Animator.StringToHash("Base Layer.Run");



    // Start is called before the first frame update
    private bool selected=false;
    private bool move = false;
    private bool colliding = false;
    private bool touchedMarket = false;
    //public GameObject unit; //Keep in mind that we drag-drop the tile in inspector
    //attributes
    private int health;
    private int defense;
    private int range;
    private int speed;
    private int attack;
    private int cash;
    private string title;
    private Rigidbody2D rb2D; //For selecting the attached rigid body component


    //int jumpHash = Animator.StringToHash("Jump");
    //int runStateHash = Animator.StringToHash("Base Layer.Run");

    //player stats
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }
    public int Range
    {
        get { return range; }
        set { range = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int Cash
    {
        get { return cash; }
        set { cash = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public bool Selected
    {
        get { return selected; }
        set { selected = value; }
    }

    public bool Colliding
    {
        get { return colliding; }
        set { colliding = value; }
    }

    public bool Move
    {
        get { return move; }
        set { move = value; }
    }
    public bool TouchedMarket
    {
        get { return touchedMarket; }
        set { touchedMarket = value; }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger(idleHash);

        rb2D = GetComponent<Rigidbody2D>();
        colliding = false;
        if (rb2D.name == "archer(Clone)")
        {
            print("archer detected");
            health= 2;
            defense = 5;
            range = 100;
            speed = 60;
            attack = 4;
            title = "";
            walkHash = Animator.StringToHash("walk_archer");
            attackHash = Animator.StringToHash("attack_archer");
            idleHash = Animator.StringToHash("idle_archer");
            defendHash = Animator.StringToHash("defend_archer");
            powerHash = Animator.StringToHash("power_archer");
            deadHash = Animator.StringToHash("dead_archer");
        }
        else if (rb2D.name == "Cleric(Clone)")
        {
            print("cleric detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 60;
            attack = 12;
            title = "";
            walkHash = Animator.StringToHash("walk_cleric");
            attackHash = Animator.StringToHash("attack_cleric");
            idleHash = Animator.StringToHash("idle_cleric");
            defendHash = Animator.StringToHash("defend_cleric");
            powerHash = Animator.StringToHash("power_cleric");
            deadHash = Animator.StringToHash("dead_cleric");
        }
        else if (rb2D.name == "warrior(Clone)")
        {
            print("warrior detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 60;
            attack = 12;
            title = "";
            walkHash = Animator.StringToHash("walk_warrior");
            attackHash = Animator.StringToHash("attack_warrior");
            idleHash = Animator.StringToHash("idle_warrior");
            defendHash = Animator.StringToHash("defend_warrior");
            powerHash = Animator.StringToHash("power_warrior");
            deadHash = Animator.StringToHash("dead_warrior");

        }
        else if (rb2D.name == "Calvary(Clone)")
        {
            print("Calvary detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 60;
            attack = 12;
            title = "";
            walkHash = Animator.StringToHash("walk_calvary");
            attackHash = Animator.StringToHash("attack_calvary");
            idleHash = Animator.StringToHash("idle_calvary");
            defendHash = Animator.StringToHash("defend_calvary");
            powerHash = Animator.StringToHash("power_calvary");
            deadHash = Animator.StringToHash("dead_calvary");

        }
        else if (rb2D.name == "Soceress(Clone)")
        {
            print("Soceress detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 60;
            attack = 12;
            title = "";
            walkHash = Animator.StringToHash("walk_soceress");
            attackHash = Animator.StringToHash("attack_soceress");
            idleHash = Animator.StringToHash("idle_soceress");
            defendHash = Animator.StringToHash("defend_soceress");
            powerHash = Animator.StringToHash("power_soceress");
            deadHash = Animator.StringToHash("dead_soceress");

        }
        else if (rb2D.name == "Thief(Clone)")
        {
            print("Thief detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 60;
            attack = 12;
            title = "";
            walkHash = Animator.StringToHash("walk_thief");
            attackHash = Animator.StringToHash("attack_thief");
            idleHash = Animator.StringToHash("idle_thief");
            defendHash = Animator.StringToHash("defend_thief");
            powerHash = Animator.StringToHash("power_thief");
            deadHash = Animator.StringToHash("dead_thief");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
     
       print(name+ " unit killed");
            dead_anim();
            //Destroy(this.gameObject);
            //gameObject.GetComponent<Renderer>().enabled = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle")) //If collided object has tag Ground
        {
            colliding = true;
        }
        if (collision.gameObject.CompareTag("treasure"))
        {
            cash += 10;
            print("cash Added");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("market"))
        {
            print("hit market");
            touchedMarket = true;
        }
    }

    public void move_anim()
    {
        anim.SetTrigger(walkHash);
    }

    public void attack_anim()
    {
        anim.SetTrigger(attackHash);
    }

    public void defend_anim()
    {
        anim.SetTrigger(defendHash);
    }

    public void power_anim()
    {
        anim.SetTrigger(powerHash);
    }

    public void dead_anim()
    {
        anim.SetTrigger(deadHash);
    }
}
