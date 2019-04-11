using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spriteImg : MonoBehaviour
{

    private Image[] allImg;
    private Slider[] allSliders;
    private Sprite[] playerUnits;
    MyGrid grid;
    public Sprite Archer;
    public Sprite Warrior;
    public Sprite Calvary;
    public Sprite Cleric;
    public Sprite Soceress;
    public Sprite Thief;

    private GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        allImg = GetComponentsInChildren<Image>();
        allSliders = GetComponentsInChildren<Slider>();
        go = GameObject.Find("Grid");
        grid = go.GetComponent<MyGrid>();
        playerUnits = new Sprite[4];

        string name;
        for (int i=0; i<4; i++)
        {
            name = grid.units[i].name;
            if (name == "warrior(Clone)")
            {
                playerUnits[i] = Warrior;
                allImg[i + 5].sprite = Warrior;
            }
            if (name == "archer(Clone)")
            {
                playerUnits[i] = Archer;
                allImg[i + 5].sprite = Archer;
            }
            if (name == "Cleric(Clone)")
            {
                playerUnits[i] = Cleric;
                allImg[i + 5].sprite = Cleric;
            }
            if (name == "Thief(Clone)")
            {
                playerUnits[i] = Thief;
                allImg[i + 5].sprite = Thief;
            }
            if (name == "Sorceress(Clone)")
            {
                playerUnits[i] = Soceress;
                allImg[i + 5].sprite = Soceress;
            }
            if (name == "Calvary(Clone)")
            {
                playerUnits[i] = Calvary;
                allImg[i + 5].sprite = Calvary;
            }

        }
        //units dashboard
        allImg[0 + 4].sprite = playerUnits[grid.playerTurn];
               
    }

    // Update is called once per frame
    void Update()
    {
        //print("grid.playerTurn" + grid.playerTurn);
        allImg[0 + 4].sprite = playerUnits[grid.playerTurn];
        for (int i=0; i<=4; i++)
        {
            if(i== grid.playerTurn)
            {
                allImg[i].color = Color.green;
            }
            else
            {
                allImg[i].color = Color.white;
            }
        }

        allSliders[0].value = grid.units[grid.playerTurn].GetComponent<Unit>().Health;
        allSliders[1].value = grid.units[grid.playerTurn].GetComponent<Unit>().Attack;

        /**
        foreach (Image image in allImg)
        {
            image.sprite = m_sprite;
        }
    **/

    }
}
