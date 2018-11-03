using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public int stats;
    public int Stats
    {
        get
        {
            return stats;
        }

        set
        {
            this.stats = value;
        }
    }
}