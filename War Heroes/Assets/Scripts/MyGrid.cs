using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour
{
    private int rows;
    private int cols;
    private float tileSize;
    public GameObject tile; //Keep in mind that we drag-drop the tile in inspector
    List<GameObject> allTiles;
    public GameObject Archer;
    public GameObject Warrior;
    public GameObject Calvary;
    public GameObject Cleric;
    public GameObject Soceress;
    public GameObject Thief;

    public bool move;
    public Vector3 pos;
    List<GameObject> units;
    // Start is called before the first frame update
    void Start()
    {
        rows = 35;
        cols = 13;
        tileSize = (tile.GetComponent<SpriteRenderer>().sprite.bounds.size.x) * tile.GetComponent<SpriteRenderer>().transform.lossyScale.x;
        allTiles = new List<GameObject>();
        units = new List<GameObject>();
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i< units.Count; i++)
        {
            if (units[i].GetComponent<Unit>().Selected == true)
            {
                //print("select true");
                if(Input.GetMouseButtonDown(0))
                {
                    //print("mouse down");
                    if (units[i].GetComponent<Unit>().Move == false)
                        units[i].GetComponent<Unit>().Move = true;
                    pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    pos.z = units[i].transform.position.z;
                }
            }
            if (units[i].GetComponent<Unit>().Move == true)
            {
                //print("move true");
                if (units[i].transform.position.x != pos.x)
                {
                    //print(pos);
                    units[i].transform.position = Vector3.MoveTowards(units[i].transform.position, new Vector3(pos.x,units[i].transform.position.y,0), 30 * Time.deltaTime);
                }
                else if (units[i].transform.position.y != pos.y)
                {
                   // print(pos);
                    units[i].transform.position = Vector3.MoveTowards(units[i].transform.position, new Vector3(units[i].transform.position.x,pos.y, 0), 30 * Time.deltaTime);
                }
                else if (units[i].transform.position == pos)
                    units[i].GetComponent<Unit>().Move = false;
            }
        }
    }

    private void PlaceTile(int x, int y, Vector3 worldStart)
    {
        GameObject newTile = Instantiate(tile);
        newTile.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
        x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
        allTiles.Add(newTile);
    }

    private void PlaceUnit(int x, int y, Vector3 worldStart, string name)
    {
        GameObject newunit = Instantiate(Archer);
        if (name == "Archer") { 
            newunit= Instantiate(Archer);
        }
        else if (name == "Warrior")
        {
            newunit = Instantiate(Warrior);
        }
        else if (name == "Calvary")
        {
            newunit = Instantiate(Calvary);
        }
        else if (name == "Cleric")
        {
            newunit = Instantiate(Cleric);
        }
        else if (name == "Soceress")
        {
            newunit = Instantiate(Soceress);
        }
        else if (name == "Thief")
        {
            newunit = Instantiate(Thief);
        }
        newunit.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
        x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
        units.Add(newunit);
        //newunit.pos(newunit.transform.position);
    }

    private void CreateGrid()
    {
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        for (int y = 0; y < cols; y++)
        {
            for (int x = 0; x < rows; x++)
            {
                PlaceTile(x, y, worldStart);
            }
        }
        PlaceUnit(0,0, worldStart, "Warrior");
        PlaceUnit(5, 5, worldStart, "Archer");
        PlaceUnit(10, 10, worldStart, "Cleric");
        PlaceUnit(15, 10, worldStart, "Calvary");
        PlaceUnit(3, 8, worldStart, "Soceress");
        PlaceUnit(10, 4, worldStart, "Thief");
    }

}
