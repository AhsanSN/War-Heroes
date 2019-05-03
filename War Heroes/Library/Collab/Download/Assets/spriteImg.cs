using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spriteImg : MonoBehaviour
{

    private Image[] allImg;
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
        go = GameObject.Find("Grid");
        grid = go.GetComponent<MyGrid>();
        playerUnits = new Sprite[4];
        
        playerUnits[0] = Warrior;
        playerUnits[1] = Archer;
        playerUnits[2] = Cleric;
        playerUnits[3] = Calvary;
        //playerUnits[4] = Soceress;
        //playerUnits[5] = Thief;

        //units dashboard
        
        allImg[0 + 4].sprite = playerUnits[grid.playerTurn];

        allImg[1 + 4].sprite = Warrior;
        allImg[2 + 4].sprite = Archer;
        allImg[3 + 4].sprite = Cleric;
        allImg[4 + 4].sprite = Calvary;
        
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
        
        /**
        foreach (Image image in allImg)
        {
            image.sprite = m_sprite;
        }
    **/

    }
}
