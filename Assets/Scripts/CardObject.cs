using UnityEngine;


[CreateAssetMenu(fileName = "CardObject", menuName = "WGJSanca/CardObject", order = 0)]
public class CardObject : Card 
{
    Player player;

 
    public override int Points(string option)
    {
        if(option == increaseOption)
        {
            Debug.Log(option);
            Debug.Log(increaseOption);
             //Debug.Log("before " + player.Stats);
            //player.Stats += increaseValue;
           // Debug.Log("after "+player.Stats);
            return 1;
            //description = increaseText;
        }
        else if(option == decreaseOption)
        {
             Debug.Log(option);
            Debug.Log(decreaseOption);
           // player.Stats += decreaseValue;
           // description = decreaseText;
            return -1;
        }

        return 0;
    } 

    


}