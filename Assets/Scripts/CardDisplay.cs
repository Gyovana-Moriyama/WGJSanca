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
        Tdescription = GetComponent<TextMeshProUGUI>();
        Tdescription.text = card.description;
        TincreaseOption = GetComponent<TextMeshProUGUI>();
        TincreaseOption.text = card.increaseOption;
        TdecreaseOption = GetComponent<TextMeshProUGUI>();
        TdecreaseOption.text = card.decreaseOption;
    }
}