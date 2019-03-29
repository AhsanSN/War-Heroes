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


public class unitSelecction : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    private int nUnits = 0;
    //private Text nUnitsSelected;
    private string[] unitsSelectedArray;
    private int nUnit0 = 0;
    private int nUnit1 = 0;
    private int nUnit2 = 0;
    private int nUnit3 = 0;
    private int nUnit4 = 0;
    private int nUnit5 = 0;
    private Text[] allTexts;
    //private Slider[] allSliders;
    private int nCash = 20;
    private int[] unitsCost = { 4, 3, 5, 10, 12, 12 };

    void Start()
    {
        Button[] buttons = this.GetComponentsInChildren<Button>();
        allTexts = GetComponentsInChildren<Text>();
        //allSliders = GetComponentsInChildren<Slider>();

        //allSliders[0].value = 0.1;
        //for players
        buttons[0].onClick.AddListener(ButtonClicked);
        buttons[1].onClick.AddListener(ButtonClicked);
        buttons[2].onClick.AddListener(ButtonClicked);
        buttons[3].onClick.AddListener(ButtonClicked);
        buttons[4].onClick.AddListener(ButtonClicked);

        //for selecting and deselecting
        buttons[5].onClick.AddListener(ButtonClicked);
        buttons[6].onClick.AddListener(ButtonClicked);

        buttons[7].onClick.AddListener(ButtonClicked);
        buttons[8].onClick.AddListener(ButtonClicked);

        buttons[9].onClick.AddListener(ButtonClicked);
        buttons[10].onClick.AddListener(ButtonClicked);

        buttons[11].onClick.AddListener(ButtonClicked);
        buttons[12].onClick.AddListener(ButtonClicked);

        buttons[13].onClick.AddListener(ButtonClicked);
        buttons[14].onClick.AddListener(ButtonClicked);

        buttons[15].onClick.AddListener(ButtonClicked);
        buttons[16].onClick.AddListener(ButtonClicked);

        buttons[18].onClick.AddListener(ButtonClicked); //tobattle

        //texts

    }

    void ButtonClicked()
    {
        //Output this to console when the Button3 is clic
        var unitName = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log("Unit name" + unitName);
        //texts[0] = nPlayers + " Players selected.";
        
        if (unitName == "beginGame")
        {
            print("battleGround");
            SceneManager.LoadScene("battleGround");
        }
        //for selecting and deselecting
        //unit0
        if (unitName == "removeUnit0")
        {
            if (nUnit0 > 0)
            {
                nUnit0 = nUnit0 - 1;
            }
        }
        if (unitName == "addUnit0")
        {
            if(unitsCost[0]<= nCash)
            {
                nUnit0 = nUnit0 + 1;
            }
        }
        //unit1
        if (unitName == "removeUnit1")
        {
            if (nUnit1 > 0)
            {
                nUnit1 = nUnit1 - 1;
            }
        }
        if (unitName == "addUnit1")
        {
            if (unitsCost[1] <= nCash)
            {
                nUnit1 = nUnit1 + 1;
            }
        }
        //unit2
        if (unitName == "removeUnit2")
        {
            if (nUnit2 > 0)
            {
                nUnit2 = nUnit2 - 1;
            }
        }
        if (unitName == "addUnit2")
        {
            if (unitsCost[2] <= nCash)
            {
                nUnit2 = nUnit2 + 1;
            }
        }
        //unit3
        if (unitName == "removeUnit3")
        {
            if (nUnit3 > 0)
            {
                nUnit3 = nUnit3 - 1;
            }
        }
        if (unitName == "addUnit3")
        {
            if (unitsCost[3] <= nCash)
            {
                nUnit3 = nUnit3 + 1;
            }
        }
        //unit4
        if (unitName == "removeUnit4")
        {
            if (nUnit4 > 0)
            {
                nUnit4 = nUnit4 - 1;
            }
        }
        if (unitName == "addUnit4")
        {
            if (unitsCost[4] <= nCash)
            {
                nUnit4 = nUnit4 + 1;
            }
        }
        //unit5
        if (unitName == "removeUnit5")
        {
            if (nUnit5 > 0)
            {
                nUnit5 = nUnit5 - 1;
            }
        }
        if (unitName == "addUnit5")
        {
            if (unitsCost[5] <= nCash)
            {
                nUnit5 = nUnit5 + 1;
            }
        }

        //updating text
        allTexts[2].text = nUnit0.ToString();
        allTexts[3].text = nUnit1.ToString();
        allTexts[4].text = nUnit2.ToString();
        allTexts[5].text = nUnit3.ToString();
        allTexts[6].text = nUnit4.ToString();
        allTexts[7].text = nUnit5.ToString();

        nUnits = nUnit0 + nUnit1 + nUnit2 + nUnit3 + nUnit4 + nUnit5;
        nCash = 20 - ((unitsCost[0] * nUnit0) + (unitsCost[1] * nUnit1) + (unitsCost[2] * nUnit2) + (unitsCost[3] * nUnit3) + (unitsCost[4] * nUnit4) + (unitsCost[5] * nUnit5));
        allTexts[1].text = nCash.ToString();
        allTexts[0].text = nUnits + " Units Selected";
    }
}