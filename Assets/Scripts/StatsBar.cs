using UnityEngine;
using UnityEngine.UI;
public class StatsBar : MonoBehaviour {
    
    Player player;
    [SerializeField] private Image statsImage;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

  
    void Update()
    {
        statsImage.fillAmount = (player.Stats/100);
    }
}