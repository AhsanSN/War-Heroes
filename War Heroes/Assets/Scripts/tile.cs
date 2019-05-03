using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    private bool occupied;

    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }
}
