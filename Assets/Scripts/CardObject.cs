using UnityEngine;


[CreateAssetMenu(fileName = "CardObject", menuName = "WGJSanca/CardObject", order = 0)]
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
            Debug.Log(option);
            Debug.Log(increaseOption);
             Debug.Log("before " + player.Stats);
            player.Stats += increaseValue;
            Debug.Log("after "+player.Stats);
        }
        else if(option == decreaseOption)
        {
             Debug.Log(option);
            Debug.Log(decreaseOption);
            player.Stats += decreaseValue;
        }
    } 

    


}