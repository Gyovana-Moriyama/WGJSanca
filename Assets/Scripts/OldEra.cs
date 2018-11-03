using UnityEngine;

[CreateAssetMenu(fileName = "OldEra", menuName = "WGJSanca/OldEra", order = 0)]
public class OldEra : Card
{
    Player player;
    
    void Awake()
    {
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    
    public override void Points(string option)
    {
        if(option == increaseOption)
        {
            player.Stats += increaseValue;
        }
        else if(option == decreaseOption)
        {
            player.Stats -= decreaseValue;
        }
    }
}
