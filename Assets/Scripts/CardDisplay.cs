using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI Tdescription;
    public TextMeshProUGUI TincreaseOption;
    public TextMeshProUGUI TdecreaseOption;

    private void Start() 
    {  
        Tdescription.text = card.description;
        TincreaseOption.text = card.increaseOption;
        TdecreaseOption.text = card.decreaseOption;
    }
}