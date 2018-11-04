using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeStats : MonoBehaviour 
{
    Player player;

     private TextMeshProUGUI textMPro;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        textMPro = GetComponent<TextMeshProUGUI>();
    }
    
    void Stats()
    {
        textMPro.text = player.Stats.ToString();
    }
    
}