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

public class unitSelecction : MonoBehaviour
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
    public List<int> nUnits = new List<int>();
    public int nCash = 20;
    //private int[] unitsCost = { 4, 3, 5, 10, 12, 12 };
    private List<GameObject> Selecteditems = new List<GameObject>();
    public GameObject[] games;
    private Sprite img;
    //public GameObject ros1;
    public GameObject roster1;
    public GameObject roster2;
    public GameObject roster3;
    public GameObject roster4;
    public GameObject roster5;
    public GameObject roster6;
    //private Image[] allImg;
    //private Sprite playerSprite;
    //public Sprite spriePub;
    void Start()
    {
        //allImg = GetComponentsInChildren<Image>();
        //playerSprite = spriePub;
        //for(int i=0; i<10; i++)
        //{
            //allImg[i].sprite = playerSprite;
        //}
        //    Button[] buttons = this.GetComponentsInChildren<Button>();
        //    allTexts = GetComponentsInChildren<Text>();
        //    //allSliders = GetComponentsInChildren<Slider>();

        //    //allSliders[0].value = 0.1;
        //    //for players
        //    buttons[0].onClick.AddListener(ButtonClicked);
        //    buttons[1].onClick.AddListener(ButtonClicked);
        //    buttons[2].onClick.AddListener(ButtonClicked);
        //    buttons[3].onClick.AddListener(ButtonClicked);
        //    buttons[4].onClick.AddListener(ButtonClicked);

        //    //for selecting and deselecting
        //    buttons[5].onClick.AddListener(ButtonClicked);
        //    buttons[6].onClick.AddListener(ButtonClicked);

        //    buttons[7].onClick.AddListener(ButtonClicked);
        //    buttons[8].onClick.AddListener(ButtonClicked);

        //    buttons[9].onClick.AddListener(ButtonClicked);
        //    buttons[10].onClick.AddListener(ButtonClicked);

        //    buttons[11].onClick.AddListener(ButtonClicked);
        //    buttons[12].onClick.AddListener(ButtonClicked);

        //    buttons[13].onClick.AddListener(ButtonClicked);
        //    buttons[14].onClick.AddListener(ButtonClicked);

        //    buttons[15].onClick.AddListener(ButtonClicked);
        //    buttons[16].onClick.AddListener(ButtonClicked);

        //    buttons[18].onClick.AddListener(ButtonClicked); //tobattle

        //    //texts

        //}

        //void ButtonClicked()
        //{
        //    //Output this to console when the Button3 is clic
        //    var unitName = EventSystem.current.currentSelectedGameObject.name;
        //    //Debug.Log("Unit name" + unitName);
        //    //texts[0] = nPlayers + " Players selected.";

        //    if (unitName == "beginGame")
        //    {
        //        print("battleGround");
        //        SceneManager.LoadScene("battleGround");
        //    }
        //    //for selecting and deselecting
        //    //unit0
        //    if (unitName == "removeUnit0")
        //    {
        //        if (nUnit0 > 0)
        //        {
        //            nUnit0 = nUnit0 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit0")
        //    {
        //        if(unitsCost[0]<= nCash)
        //        {
        //            nUnit0 = nUnit0 + 1;
        //        }
        //    }
        //    //unit1
        //    if (unitName == "removeUnit1")
        //    {
        //        if (nUnit1 > 0)
        //        {
        //            nUnit1 = nUnit1 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit1")
        //    {
        //        if (unitsCost[1] <= nCash)
        //        {
        //            nUnit1 = nUnit1 + 1;
        //        }
        //    }
        //    //unit2
        //    if (unitName == "removeUnit2")
        //    {
        //        if (nUnit2 > 0)
        //        {
        //            nUnit2 = nUnit2 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit2")
        //    {
        //        if (unitsCost[2] <= nCash)
        //        {
        //            nUnit2 = nUnit2 + 1;
        //        }
        //    }
        //    //unit3
        //    if (unitName == "removeUnit3")
        //    {
        //        if (nUnit3 > 0)
        //        {
        //            nUnit3 = nUnit3 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit3")
        //    {
        //        if (unitsCost[3] <= nCash)
        //        {
        //            nUnit3 = nUnit3 + 1;
        //        }
        //    }
        //    //unit4
        //    if (unitName == "removeUnit4")
        //    {
        //        if (nUnit4 > 0)
        //        {
        //            nUnit4 = nUnit4 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit4")
        //    {
        //        if (unitsCost[4] <= nCash)
        //        {
        //            nUnit4 = nUnit4 + 1;
        //        }
        //    }
        //    //unit5
        //    if (unitName == "removeUnit5")
        //    {
        //        if (nUnit5 > 0)
        //        {
        //            nUnit5 = nUnit5 - 1;
        //        }
        //    }
        //    if (unitName == "addUnit5")
        //    {
        //        if (unitsCost[5] <= nCash)
        //        {
        //            nUnit5 = nUnit5 + 1;
        //        }
        //    }

        //    //updating text
        //    allTexts[2].text = nUnit0.ToString();
        //    allTexts[3].text = nUnit1.ToString();
        //    allTexts[4].text = nUnit2.ToString();
        //    allTexts[5].text = nUnit3.ToString();
        //    allTexts[6].text = nUnit4.ToString();
        //    allTexts[7].text = nUnit5.ToString();

        //    nUnits = nUnit0 + nUnit1 + nUnit2 + nUnit3 + nUnit4 + nUnit5;
        //    nCash = 20 - ((unitsCost[0] * nUnit0) + (unitsCost[1] * nUnit1) + (unitsCost[2] * nUnit2) + (unitsCost[3] * nUnit3) + (unitsCost[4] * nUnit4) + (unitsCost[5] * nUnit5));
        //    allTexts[1].text = nCash.ToString();
        //    allTexts[0].text = nUnits + " Units Selected";
    }
    private void Update()
    {
        
    }
    
    public void OpenBattleGround()
    {
        print("2 battle");
        //StaticClass.CrossSceneInformation = Selecteditems;
        SceneManager.LoadScene("battleGround");
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
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros2").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros2").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros3").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros3").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                    //print(ros1.active);
                    break;
                }
                else if (GameObject.Find("ros4").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros4").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
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
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
                    if (Selecteditems.Count < 4)
                    {
                        Selecteditems.Add(roster1);
                        Use("roster archer");
                        break;
                    }
                }
                if (items.name == "Cavalry")
                {
                    print("Cavalry");
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
                    if (Selecteditems.Count < 4)
                    {
                        Selecteditems.Add(roster2);
                        Use("roster cavalry");
                        break;
                    }
                }
                if (items.name == "Sorceress")
                {
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
                    if (Selecteditems.Count < 4)
                    {
                        Selecteditems.Add(roster3);
                        Use("roster sorceress");
                        break;
                    }
                }
                if (items.name == "Thief")
                {
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
                    if (Selecteditems.Count < 4)
                    {
                        print("something");
                        Selecteditems.Add(roster4);
                        Use("roster thief");
                        break;
                    }
                }
                if (items.name == "Cleric")
                {
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
                    if (Selecteditems.Count < 4)
                    {
                        Selecteditems.Add(roster5);
                        Use("roster cleric");
                        break;
                    }
                }
                if (items.name == "Warrior")
                {
                    nCash -= 4;
                    if (nCash < 0) nCash += 4;
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
