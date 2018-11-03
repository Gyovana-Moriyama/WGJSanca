using UnityEngine;

[CreateAssetMenu(fileName = "NewEra", menuName = "WGJSanca/NewEra", order = 1)]
public class NewEra : Card 
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