using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGrid : MonoBehaviour
{
    
    private int rows;
    private int cols;
    private float tileSize;
    public GameObject[] tile; //Keep in mind that we drag-drop the tile in inspector
    List<GameObject> allTiles;
    List<GameObject> allObstacles;
    List<GameObject> Treasures;
    public GameObject Archer;
    public GameObject Warrior;
    public GameObject Calvary;
    public GameObject Cleric;
    public GameObject Soceress;
    public GameObject Thief;
    public GameObject[] Rock;
    public GameObject Market;
    public GameObject Treasure;
    public bool move;
    public Vector3 pos;
    public List<GameObject> units = new List<GameObject>();
    public List<GameObject> enemyUnits = new List<GameObject>();
    public Vector3[] toPos = new Vector3[6];
    public Vector3[] toPosEnemy = new Vector3[6];
    public Scrollbar scrollX;
    public Scrollbar scrollY;
    // Start is called before the first frame update
    public int playerTurn = 0;
    public int playerEnemyTurn = 0;
    public bool isMyTurn = true;

    //Set this in the Inspector
    private float scrollXval = 1;
    private float scrollYval = 1;
    private GameObject go;
    Unit unit;

    private int nArcher = 1;
    private int nWarrior = 1;
    private int nCalvary = 1;
    private int nCleric = 1;
    private int nSoceress = 0;
    private int nThief = 0;
    
    private int nArcher_enemy = 1;
    private int nWarrior_enemy = 1;
    private int nCalvary_enemy = 1;
    private int nCleric_enemy = 1;
    private int nSoceress_enemy = 0;
    private int nThief_enemy = 0;

    private float enemyRange;
    private int globI;
    private int globEI; //enemy unit that will be hit by my unit
    private bool attckBtnShown;
    private bool gridShown = false;

    public int randI;
    private int nTreasures;
    private int nMarkets;

    void Start()
    {
        //Debug.Log("asdjlasndaksndlnasldnalsdnklaksdn"+StaticClass.CrossSceneInformation[0].name);

        GameObject.Find("attack").GetComponent<Button>().enabled = false;
        GameObject.Find("attack").GetComponent<Image>().color = Color.clear;
        GameObject.Find("marketbutton").GetComponent<Button>().enabled = false;
        GameObject.Find("marketbutton").GetComponent<Image>().color = Color.clear;
        GameObject.Find("End Turn").GetComponent<Button>().enabled = false;
        GameObject.Find("End Turn").GetComponent<Image>().color = Color.clear;

        

        //GameObject.Find("attack").GetComponent<Button>().enabled = true;
        //GameObject.Find("attack").GetComponent<Image>().color = Color.white;
        rows = 56;
        cols = 25;
        int rnd = Random.Range(0, 2);
        tileSize = (tile[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x) * tile[0].GetComponent<SpriteRenderer>().transform.lossyScale.x;
        allTiles = new List<GameObject>();
        //units = new List<GameObject>();
        CreateGrid();
        go = GameObject.Find("Grid");
        unit = go.GetComponent<Unit>();
        GameObject.Find("attack").GetComponent<Button>().onClick.AddListener(() => engageBattle());
        //GameObject.Find("End Turn").GetComponent<Button>().onClick.AddListener(() => endBattle());
        scrollY.value = 1f;
        //playerTurn = 1;

        randI = Random.Range(0, units.Count);
        scrollX.value = 0f;
        scrollY.value = 1f;
    }
    
    void Update()
    {
        //showGridIsStart();
        if (playerTurn == units.Count)
        {
            toPosEnemy[playerEnemyTurn] = units[randI].transform.position;
            isMyTurn = false;
            playerTurn = 0;
        }

        print("isMyTurn" + isMyTurn + "unit" + playerTurn);
        print("enemy turn " + playerEnemyTurn);
        //enemy movement
        if (isMyTurn == false)
        {
            moveEnemyUnitAI();
        }
        myTurnMoves();
        moveMyUnits();
        scrollWithKeys();

    }

    private void scrollWithKeys()
    {
        if (Input.GetKeyDown("up"))
        {
            topScrollButton();
        }
        if (Input.GetKeyDown("down"))
        {
            downScrollButton();
        }
        if (Input.GetKeyDown("left"))
        {
            leftScrollButton();
        }
        if (Input.GetKeyDown("right"))
        {
            rightScrollButton();
        }
    }

    private void moveMyUnits()
    {
        for (int i = 0; i < units.Count; i++)
        {
            if (units[i].GetComponent<Unit>().Move == true)
            {
                units[i].GetComponent<Unit>().move_anim();
                if ((units[i].transform.position.x != toPos[playerTurn].x) && (units[i].transform.position.y != toPos[i].y))
                {
                    enemyRange = (minDistanceToAllEnemies(units[i].transform.position.x, units[i].transform.position.y));
                    if (units[i].GetComponent<Unit>().TouchedMarket == true)
                    {
                        GameObject.Find("attack").GetComponent<Button>().enabled = false;
                        GameObject.Find("attack").GetComponent<Image>().color = Color.clear;
                        GameObject.Find("End Turn").GetComponent<Button>().enabled = false;
                        GameObject.Find("End Turn").GetComponent<Image>().color = Color.clear;
                        GameObject.Find("marketbutton").GetComponent<Button>().enabled = true;
                        GameObject.Find("marketbutton").GetComponent<Image>().color = Color.white;
                    }
                    if (units[i].GetComponent<Unit>().Colliding == false)
                    {
                        globI = i;
                        if (enemyRange < units[i].GetComponent<Unit>().Range)
                        {
                            print("ready for attk");
                            if (attckBtnShown == false && isMyTurn)
                            {
                                GameObject.Find("marketbutton").GetComponent<Button>().enabled = false;
                                GameObject.Find("marketbutton").GetComponent<Image>().color = Color.clear;
                                GameObject.Find("attack").GetComponent<Button>().enabled = true;
                                GameObject.Find("attack").GetComponent<Image>().color = Color.white;
                                GameObject.Find("End Turn").GetComponent<Button>().enabled = true;
                                GameObject.Find("End Turn").GetComponent<Image>().color = Color.white;
                                //units[i].transform.position = Vector3.MoveTowards(units[i].transform.position, toPos[i], units[i].GetComponent<Unit>().Speed * Time.deltaTime);
                                toPos[playerTurn].x = units[i].transform.position.x;
                                toPos[playerTurn].y = units[i].transform.position.y;
                            }
                            else
                            {
                                units[i].transform.position = Vector3.MoveTowards(units[i].transform.position, toPos[i], units[i].GetComponent<Unit>().Speed * Time.deltaTime);
                            }
                        }
                        else
                        {
                            GameObject.Find("attack").GetComponent<Button>().enabled = false;
                            GameObject.Find("attack").GetComponent<Image>().color = Color.clear;
                            GameObject.Find("marketbutton").GetComponent<Button>().enabled = false;
                            GameObject.Find("marketbutton").GetComponent<Image>().color = Color.clear;
                            GameObject.Find("End Turn").GetComponent<Button>().enabled = false;
                            GameObject.Find("End Turn").GetComponent<Image>().color = Color.clear;
                            units[i].transform.position = Vector3.MoveTowards(units[i].transform.position, toPos[i], units[i].GetComponent<Unit>().Speed * Time.deltaTime);
                        }
                    }
                    else
                    {
                        toPos[playerTurn].x = units[i].transform.position.x;
                        toPos[playerTurn].y = units[i].transform.position.y;
                        units[i].GetComponent<Unit>().Colliding = false;
                    }
                }
                else if (units[i].transform.position == toPos[i])
                {
                    print("player move stopped");
                    units[i].GetComponent<Unit>().Move = false;
                }
                    
                //enemyUnits[globEI].GetComponent<Unit>().Move = true;
            }
        }
    }

    private void myTurnMoves()
    {
        if (isMyTurn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (units[playerTurn].GetComponent<Unit>().Move == false)
                {
                    units[playerTurn].GetComponent<Unit>().Move = true;

                }
                toPos[playerTurn] = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                toPos[playerTurn].z = units[playerTurn].transform.position.z;
                playerTurn = playerTurn + 1;
                if (playerTurn == units.Count)
                {
                    print("turn changed");

                }
                enemyUnits[globEI].GetComponent<Unit>().Move = true;
            }
        }
    }

    private void endBattle()
    {
        print("end battle called");
        GameObject.Find("attack").GetComponent<Button>().enabled = false;
        GameObject.Find("attack").GetComponent<Image>().color = Color.clear;
        GameObject.Find("End Turn").GetComponent<Button>().enabled = false;
        GameObject.Find("End Turn").GetComponent<Image>().color = Color.clear;
    }

    public void engageBattle(bool isMyAttack = true)
    {
        print("engaging in battle");
        doSpecialAttack(units[playerTurn].GetComponent<Unit>().name);
        var attckCount = 0;
        var defendCount = 0;
        var hitScore = 0;
        attckBtnShown = true;
        if (isMyAttack == false)
        {
            GameObject.Find("attack").GetComponent<Button>().enabled = false;
            GameObject.Find("attack").GetComponent<Image>().color = Color.clear;
            GameObject.Find("End Turn").GetComponent<Button>().enabled = false;
            GameObject.Find("End Turn").GetComponent<Image>().color = Color.clear;
        }

        //template
        var a = units[globI].GetComponent<Unit>().Attack; //attk
        var b = enemyUnits[globEI].GetComponent<Unit>().Defense; //defend
        
        //attack
        if (isMyAttack)
        {
            a = units[globI].GetComponent<Unit>().Attack;
            b = enemyUnits[globEI].GetComponent<Unit>().Defense;

            units[globI].GetComponent<Unit>().attack_anim();
            enemyUnits[globEI].GetComponent<Unit>().defend_anim();
        }
        else
        {
            a = enemyUnits[playerEnemyTurn].GetComponent<Unit>().Attack;
            b = units[randI].GetComponent<Unit>().Defense;

            enemyUnits[playerEnemyTurn].GetComponent<Unit>().attack_anim();
            units[randI].GetComponent<Unit>().defend_anim();
        }

        for (int j = 0; j < a; j++)
        {
            if (Random.Range(0.0f, 10.0f) > 5f)
            {
                attckCount = attckCount + 1;
            }
        }
        //defend
        for (int j = 0; j < b; j++)
        {
            if (Random.Range(0.0f, 10.0f) > 5f)
            {
                defendCount = defendCount + 1;
            }
        }

        //score
        if (attckCount >= defendCount)
        {
            hitScore = attckCount - defendCount;
            print("hit score" + hitScore);
        }

        //hit damage
        if (isMyAttack)
        {
            enemyUnits[globEI].GetComponent<Unit>().Health = enemyUnits[globEI].GetComponent<Unit>().Health - hitScore;
        }
        else
        {
            units[randI].GetComponent<Unit>().Health = units[randI].GetComponent<Unit>().Health - hitScore;
        }

    }

    private void moveEnemyUnitAI()
    {
        //select random usint to move towards
        //var randI = Random.Range(0, units.Count);
        //toPos[globEI] = units[randI].transform.position;
        toPosEnemy[playerEnemyTurn] = units[randI].transform.position;
        if (enemyUnits[playerEnemyTurn].GetComponent<Unit>().Move == true)
        {
            if ((enemyUnits[playerEnemyTurn].transform.position.x != (toPosEnemy[playerEnemyTurn].x) && (enemyUnits[playerEnemyTurn].transform.position.y != (toPosEnemy[playerEnemyTurn].y))))
            {
                if (enemyUnits[playerEnemyTurn].GetComponent<Unit>().Colliding == false)
                {
                    var dis = distanceToEnemy(enemyUnits[playerEnemyTurn].transform.position.x, enemyUnits[playerEnemyTurn].transform.position.y, toPosEnemy[playerEnemyTurn].x, toPosEnemy[playerEnemyTurn].y);
                    //print("dis " + dis);
                    if (dis > 10)
                    {
                        print("moving enemy");
                        //print("dis " + dis);
                        enemyUnits[playerEnemyTurn].transform.position = Vector3.MoveTowards(enemyUnits[playerEnemyTurn].transform.position, units[randI].transform.position, enemyUnits[playerEnemyTurn].GetComponent<Unit>().Speed * Time.deltaTime);
                        //moveEnemyUnitAI(playerEnemyTurn, randI);
                    }
                    else
                    {
                        print("enemy turning off1");
                        toPosEnemy[playerEnemyTurn].x = enemyUnits[playerEnemyTurn].transform.position.x;
                        toPosEnemy[playerEnemyTurn].y = enemyUnits[playerEnemyTurn].transform.position.y;
                        //attacjing
                        engageBattle(false);
                        enemyUnits[playerEnemyTurn].GetComponent<Unit>().Move = false;
                        print("enemy turned off12");
                        playerEnemyTurn = playerEnemyTurn + 1;
                        randI = Random.Range(0, units.Count);
                        if (playerEnemyTurn == enemyUnits.Count)
                        {
                            playerEnemyTurn = 0;
                            print("turned true1");
                            isMyTurn = true;
                        }
                        toPosEnemy[playerEnemyTurn] = units[randI].transform.position;
                        enemyUnits[playerEnemyTurn].GetComponent<Unit>().Move = true;
                        //isMyTurn = true;
                    }
                }
                else
                {
                    toPosEnemy[playerEnemyTurn].x = enemyUnits[playerEnemyTurn].transform.position.x;
                    toPosEnemy[playerEnemyTurn].y = enemyUnits[playerEnemyTurn].transform.position.y;
                    enemyUnits[playerEnemyTurn].GetComponent<Unit>().Colliding = false;
                }
            }
            else if (enemyUnits[playerEnemyTurn].transform.position == toPosEnemy[playerEnemyTurn])
            {
                print("enemy turned off");
                enemyUnits[playerEnemyTurn].GetComponent<Unit>().Move = false;
                playerEnemyTurn = playerEnemyTurn + 1;
                if (playerEnemyTurn == enemyUnits.Count)
                {
                    playerEnemyTurn = 0;
                    print("turned true1");
                    isMyTurn = true;
                }
                toPosEnemy[playerEnemyTurn] = units[randI].transform.position;
                enemyUnits[playerEnemyTurn].GetComponent<Unit>().Move = true;
            }
        }

    }

    private void PlaceTile(int x, int y, Vector3 worldStart)
    {
        GameObject newTile = Instantiate(tile[Random.Range(0,2)], GameObject.Find("Content").transform);
        newTile.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
        x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
        allTiles.Add(newTile);

        if (Random.Range(0.0f, 10.0f) < 0.1)
        {
            int trend = Random.Range(0, 2);
            GameObject newObstacle = Instantiate(Rock[trend], GameObject.Find("Content").transform);
            newObstacle.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
            x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
            //allTiles.Add(newObstacle);
        }
        if (Random.Range(0.0f, 10.0f) < 0.02 && nTreasures < 10)
        {
            GameObject newTreasure = Instantiate(Treasure, GameObject.Find("Content").transform);
            newTreasure.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
            x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
            //allTiles.Add(newTreasure);
            nTreasures += 1;
        }
        if (Random.Range(0.0f, 10.0f) < 0.02 && nMarkets < 10)
        {
            GameObject newMarket = Instantiate(Market, GameObject.Find("Content").transform);
            newMarket.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize *
            x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
            //allTiles.Add(newMarket);
            nMarkets += 1;
        }
    }

    private void PlaceUnit(int x, int y, Vector3 worldStart, string name, bool isEnemy = false)
    {
        //print("name  " + name);
        GameObject newunit;//Instantiate(Archer, GameObject.Find("Content").transform);
        if (name == "Archer") {
            newunit = Instantiate(Archer, GameObject.Find("Content").transform);
        }
        else if (name == "Warrior")
        {
            newunit = Instantiate(Warrior, GameObject.Find("Content").transform);
        }
        else if (name == "Calvary")
        {
            newunit = Instantiate(Calvary, GameObject.Find("Content").transform);
        }
        else if (name == "Cleric")
        {
            newunit = Instantiate(Cleric, GameObject.Find("Content").transform);
        }
        else if (name == "Soceress")
        {
            newunit = Instantiate(Soceress, GameObject.Find("Content").transform);
        }
        else if (name == "Thief")
        {
            newunit = Instantiate(Thief, GameObject.Find("Content").transform);
        }
        else
        {
            newunit = Instantiate(Thief, GameObject.Find("Content").transform);
        }
        newunit.transform.position = new Vector3(worldStart.x + tileSize / 2 + (tileSize * x), worldStart.y - tileSize / 2 - (tileSize * y), 0);
        if (isEnemy == false)
        {
            units.Add(newunit);
        }
        else {
            enemyUnits.Add(newunit);
        }
        //print("size" + units.Count);
        //newunit.pos(newunit.transform.position);
    }

    private void placeUnits()
    {
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(110, 300));
        //my units
        for (int i = 0; i < nArcher; i++)
        {
            PlaceUnit(6+5, 44-32, worldStart, "Archer");
        }
        for (int i = 0; i < nCleric; i++)
        {
            PlaceUnit(5 + 5, 40 - 32, worldStart, "Cleric");
        }
        for (int i = 0; i < nSoceress; i++)
        {
            PlaceUnit(4 + 5, 44 - 32, worldStart, "Soceress");
        }
        for (int i = 0; i < nThief; i++)
        {
            PlaceUnit(3 + 5, 44 - 32, worldStart, "Thief");
        }
        for (int i = 0; i < nWarrior; i++)
        {
            PlaceUnit(2 + 5, 44 - 32, worldStart, "Warrior");
        }
        for (int i = 0; i < nCalvary; i++)
        {
            PlaceUnit(1 + 5, 44 - 32, worldStart, "Calvary");
        }
        //enemy units
        for (int i = 0; i < nArcher_enemy; i++)
        {
            PlaceUnit(105-86, 5, worldStart, "Archer", true);
        }
        for (int i = 0; i < nCleric_enemy; i++)
        {
            PlaceUnit(105 - 86, 6, worldStart, "Cleric", true);
        }
        for (int i = 0; i < nSoceress_enemy; i++)
        {
            PlaceUnit(105 - 86, 7, worldStart, "Soceress", true);
        }
        for (int i = 0; i < nThief_enemy; i++)
        {
            PlaceUnit(108 - 86, 8, worldStart, "Thief", true);
        }
        for (int i = 0; i < nWarrior_enemy; i++)
        {
            PlaceUnit(108 - 86, 9, worldStart, "Warrior", true);
        }
        for (int i = 0; i < nCalvary_enemy; i++)
        {
            PlaceUnit(108 - 86, 10, worldStart, "Calvary", true);
        }
    }

    private void CreateGrid()
    {
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(110, 300));//new Vector3(0, 0);//Camera.main.ScreenToWorldPoint(new Vector3(0, 0));
        for (int y = 0; y < cols; y++)
        {
            for (int x = 0; x < rows; x++)
            {
                PlaceTile(x, y, worldStart);
            }
        }
        placeUnits();
    }

    public void MoveContentPane(float value)
    {
        var pos = transform.position;
        pos.x += value;
        transform.position = pos;
    }

    public float distanceToEnemy(float uX, float uY, float oX, float oY)
    {
        return Mathf.Sqrt(Mathf.Pow((uX - oX), 2) + Mathf.Pow((uY - oY), 2));
    }

    public float minDistanceToAllEnemies(float uX, float uY)
    {
        float minDis = 1231231231;
        globEI = 0;
        for (int i = 0; i < enemyUnits.Count; i++)
        {
            var dis = distanceToEnemy(uX, uY, enemyUnits[i].transform.position.x, enemyUnits[i].transform.position.y);
            if (dis < minDis)
            {
                minDis = dis;
                globEI = i;
            }
        }
        //print("minDis" + minDis);
        return minDis;
    }

    public void leftScrollButton() {
        print("left clickted");
        if (scrollXval > 0.1f)
        {
            scrollXval = scrollXval - 0.1f;
        }
        scrollX.value = scrollXval;
    }

    public void rightScrollButton()
    {
        print("right clickted");
        if (scrollXval < 1f)
        {
            scrollXval = scrollXval + 0.1f;
        }
        scrollX.value = scrollXval;
    }

    public void downScrollButton()
    {
        print("down clickted");
        if (scrollYval > 0.1f)
        {
            scrollYval = scrollYval - 0.1f;
        }
        scrollY.value = scrollYval;
    }

    public void topScrollButton()
    {
        print("top clickted");
        if (scrollYval < 1f)
        {
            scrollYval = scrollYval + 0.1f;
        }
        scrollY.value = scrollYval;
    }
    //specialAttacks
    public void doSpecialAttack(string name){
        //print("name--" + name);
        print("special attack");
        units[playerTurn].GetComponent<Unit>().power_anim();
        if (name== "warrior(Clone)")
        {
            specialAttack_warrior();
        }
        if (name == "archer(Clone)")
        {
            specialAttack_archer();
        }
        if (name == "Cleric(Clone)")
        {
            specialAttack_cleric();
        }
        if (name == "Thief(Clone)")
        {
            specialAttack_thief();
        }
        if (name == "Sorceress(Clone)")
        {
            specialAttack_sorceress();
        }
        /**
        if (name == "Calvary(Clone)")
        {
            specialAttack_calvary();
        }
        **/
    }

    public void specialAttack_warrior()
    {
        List<int> enemiesInRange = new List<int>();
        for (int i = 0; i < enemyUnits.Count; i++)
        {
            var dis = distanceToEnemy(units[playerTurn].transform.position.x, units[playerTurn].transform.position.y, enemyUnits[i].transform.position.x, enemyUnits[i].transform.position.y);
            if (dis < units[playerTurn].GetComponent<Unit>().Range)
            {
                enemiesInRange.Add(i);
            }
        }
        if (enemiesInRange.Count >= 2)
        {
            print("hitting enemy");
            units[playerTurn].GetComponent<Unit>().Health -= 1;
            foreach (int enemy in enemiesInRange){
                enemyUnits[enemy].GetComponent<Unit>().Defense = enemyUnits[enemy].GetComponent<Unit>().Defense - 1;
            }
        }
    }

    public void specialAttack_archer()
    {
        units[playerTurn].GetComponent<Unit>().Attack += 1;
    }

    public void specialAttack_cleric()
    {
        List<int> alliesInRange = new List<int>();
        for (int i = 0; i < units.Count; i++)
        {
            if (i != playerTurn)
            {
                var dis = distanceToEnemy(units[playerTurn].transform.position.x, units[playerTurn].transform.position.y, units[i].transform.position.x, units[i].transform.position.y);
                if (dis < units[playerTurn].GetComponent<Unit>().Range)
                {
                    alliesInRange.Add(i);
                }
            }
        }
        if (alliesInRange.Count >=1)
        {
            print("healing allies");
            foreach (int ally in alliesInRange)
            {
                units[ally].GetComponent<Unit>().Health +=1;
            }
        }
    }

    public void specialAttack_sorceress()
    {
        List<int> alliesInRange = new List<int>();
        for (int i = 0; i < units.Count; i++)
        {
            if (i != playerTurn)
            {
                var dis = distanceToEnemy(units[playerTurn].transform.position.x, units[playerTurn].transform.position.y, units[i].transform.position.x, units[i].transform.position.y);
                if (dis < units[playerTurn].GetComponent<Unit>().Range)
                {
                    alliesInRange.Add(i);
                }
            }
        }
        if (alliesInRange.Count >= 1)
        {
            print("healing allies with health of dmg");
            foreach (int ally in alliesInRange)
            {
                if(Random.Range(0, 10) < 5)
                {
                    units[ally].GetComponent<Unit>().Defense += 1;
                }
                else
                {
                    units[ally].GetComponent<Unit>().Attack += 1;
                }
            }
        }
    }

    public void specialAttack_thief()
    {
        if (enemyUnits[globEI].GetComponent<Unit>().Health<2)
        {
            units[playerTurn].GetComponent<Unit>().Attack += 1;
        }
    }

    private void showGridIsStart()
    {
        
        if (scrollX.value > 0f && scrollY.value > 0f && !gridShown)
        {
            print("hello");
            scrollX.value -= 0.1f;
            scrollY.value -= 0.1f;
        }
        if (scrollX.value > 0f && scrollY.value > 0f)
        {
            gridShown = true;
        }
    }

    public void Marketset()
    {
        print("market set called");
        var a = units[playerTurn].GetComponent<Unit>();
        int def = (int)GameObject.Find("Defence").GetComponent<Slider>().value;
        int att = (int)GameObject.Find("Attack").GetComponent<Slider>().value;
        if (a.Cash >= def * 10 + att * 10)
        {
            a.Cash -= def * 10 + att * 10;
            a.Defense += def;
            a.Attack += att;
            GameObject.Find("success").GetComponent<Text>().enabled = true;
        }
        else
        {
            GameObject.Find("fail").GetComponent<Text>().enabled = true;
        }
    }

}

