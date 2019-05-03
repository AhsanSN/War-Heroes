// To use this example, attach this script to an empty GameObject.
// Create three buttons (Create>UI>Button). Next, select your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button, Your Second Button
// and Your Third Button fields in the Inspector.
// Click each Button in Play Mode to output their message to the console.
// Note that click means press down and then release.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class unitSelection : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    //private int nUnits = 0;
    ////private Text nUnitsSelected;
    //private string[] unitsSelectedArray;
    //private int nUnit0 = 0;
    //private int nUnit1 = 0;
    //private int nUnit2 = 0;
    //private int nUnit3 = 0;
    //private int nUnit4 = 0;
    //private int nUnit5 = 0;
    //private Text[] allTexts;
    //private Slider[] allSliders;
    public int nCash = 50;
    public int[] cost ={10, 20, 5};
    //private int[] unitsCost = { 4, 3, 5, 10, 12, 12 };
    public List<GameObject> Selecteditems = new List<GameObject>();
    public GameObject[] games;
    private Sprite img;
    //public GameObject ros1;
    public GameObject nCoins;
    public GameObject roster1;
    public GameObject roster2;
    public GameObject roster3;
    public GameObject roster4;
    public GameObject roster5;
    public GameObject roster6;
    //private Image[] allImg;
    //private Sprite playerSprite;
    //public Sprite spriePub;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        nCoins.GetComponent<Text>().text = nCash.ToString();
    }
    private void Update()
    {
        nCoins.GetComponent<Text>().text = nCash.ToString();
    }
    private void Use(string name)
    {
        foreach (var item in Selecteditems)
        {
            if (item.name == name)
            {
                if (GameObject.Find("ros1").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros1").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros1").GetComponent<Animation>().Play("roster select");
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros2").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros2").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros2").GetComponent<Animation>().Play("roster select");
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros3").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros3").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros3").GetComponent<Animation>().Play("roster select");
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros4").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros4").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros4").GetComponent<Animation>().Play("roster select");
                    //print(ros1.active);
                    break;
                }
            }
        }
    }
    public void dUse1()
    {
        
        if (GameObject.Find("ros1").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros1").GetComponent<Image>().sprite.name;
            GameObject.Find("ros1").GetComponent<Image>().sprite = null;
            GameObject.Find("ros1").GetComponent<Image>().color = Color.clear;
            foreach (var item in Selecteditems)
            {
                if (item.name == sprit)
                {
                    if (item.name == "roster cavalry")
                    {
                        nCash += 20;
                    }
                    else if (item.name == "roster thief")
                    {
                        nCash += 5;
                    }
                    else
                    {
                        nCash += 10;
                    }
                    Selecteditems.Remove(item);
                    break;
                }
            }
        }
    }
    public void dUse2()
    {
        
        if (GameObject.Find("ros2").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros2").GetComponent<Image>().sprite.name;
            GameObject.Find("ros2").GetComponent<Image>().sprite = null;
            GameObject.Find("ros2").GetComponent<Image>().color = Color.clear;
            foreach (var item in Selecteditems)
            {
                if (item.name== sprit)
                {
                    if (item.name == "roster cavalry")
                    {
                        nCash += 20;
                    }
                    else if (item.name == "roster thief")
                    {
                        nCash += 5;
                    }
                    else
                    {
                        nCash += 10;
                    }
                    Selecteditems.Remove(item);
                    break;
                }
            }
        }
    }   
    public void dUse3()
    {
        if (GameObject.Find("ros3").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros3").GetComponent<Image>().sprite.name;
            GameObject.Find("ros3").GetComponent<Image>().sprite = null;
            GameObject.Find("ros3").GetComponent<Image>().color = Color.clear;
            foreach (var item in Selecteditems)
            {
                if (item.name == sprit)
                {
                    if (item.name == "roster cavalry")
                    {
                        nCash += 20;
                    }
                    else if (item.name == "roster thief")
                    {
                        nCash += 5;
                    }
                    else
                    {
                        nCash += 10;
                    }
                    Selecteditems.Remove(item);
                    break;
                }
            }
        }
    }
    public void dUse4()
    {
        
        if (GameObject.Find("ros4").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros4").GetComponent<Image>().sprite.name;
            GameObject.Find("ros4").GetComponent<Image>().sprite = null;
            GameObject.Find("ros4").GetComponent<Image>().color = Color.clear;
            foreach (var item in Selecteditems)
            {
                if (item.name == sprit)
                {
                    if (item.name == "roster cavalry")
                    {
                        nCash += 20;
                    }
                    else if (item.name == "roster thief")
                    {
                        nCash += 5;
                    }
                    else
                    {
                        nCash += 10;
                    }
                    Selecteditems.Remove(item);
                    break;
                }
            }
        }
    }     
        
    public void ButtonPlus()
    {
        print(Selecteditems.Count);
        foreach (var items in games)
        {
            if (items.activeSelf == true)
            {
                if (items.name == "Archer")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster1);
                            Use("roster archer");
                            break;
                        }
                    }
                }
                if (items.name == "Cavalry")
                {
                    if (nCash >= cost[1])
                    {
                        nCash -= 20;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster2);
                            Use("roster cavalry");
                            break;
                        }
                    }
                }
                if (items.name == "Sorceress")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster3);
                            Use("roster sorceress");
                            break;
                        }
                    }
                }
                if (items.name == "Thief")
                {
                    if (nCash >= cost[2])
                    {
                        nCash -= 5;
                        if (Selecteditems.Count < 4)
                        {
                            print("something");
                            Selecteditems.Add(roster4);
                            Use("roster thief");
                            break;
                        }
                    }
                }
                if (items.name == "Cleric")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster5);
                            Use("roster cleric");
                            break;
                        }
                    }
                }
                if (items.name == "Warrior")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster6);
                            Use("roster warrior");
                            break;
                        }
                    }
                }
            }
        }
    }
    public void Player1()
    {
        foreach(var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[0].active = true;
    }
    public void Player2()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[1].active = true;
    }
    public void Player3()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[2].active = true;
    }
    public void Player4()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[3].active = true;
    }
    public void Player5()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[4].active = true;
    }
    public void Player6()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[5].active = true;
    }
}
    public class Characters{
        public int defence { get; set; }
        public int attack { get; set; }
        public int range { get; set; }
        public int speed { get; set; }
        public int health { get; set; }
        public int price { get; set; }
        public int units { get; set; }
    }
    public class Archer : Characters
    {
        public Archer()
        {
            defence = 1;
            attack = 3;
            health = 4;
            range = 3;
            speed = 2;
            price = 4;
        }
    }
    public class Cavalry : Characters
    {
        public Cavalry()
        {
            defence = 3;
            attack = 3;
            health = 5;
            range = 1;
            speed = 5;
            price = 6;
        }
    }
    public class Thief : Characters
    {
        public Thief()
        {
            defence = 1;
            attack = 1;
            health = 3;
            range = 2;
            speed = 4;
            price = 4;
        }
    }
    public class Sorceress : Characters
    {
        public Sorceress()
        {
            defence = 1;
            attack = 1;
            health = 3;
            range = 2;
            speed = 2;
            price = 4;
        }
    }
    public class Cleric : Characters
    {
        public Cleric()
        {
            defence = 1;
            attack = 2;
            health = 3;
            range = 1;
            speed = 2;
            price = 4;
        }
    }
    public class Warrior : Characters
    {
        public Warrior()
        {
            defence = 2;
            attack = 3;
            health = 5;
            range = 1;
            speed = 3;
            price = 4;
        }
    }
