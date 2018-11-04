using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
           // GetComponent<TextMeshProUGUI>().text = Stats.ToString();
            
        }
    }
}