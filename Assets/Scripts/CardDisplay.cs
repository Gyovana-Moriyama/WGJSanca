using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public Card[] card;
    public TextMeshProUGUI Tdescription;
    public TextMeshProUGUI TincreaseOption;
    public TextMeshProUGUI TdecreaseOption;
    public Image cardD;
    [SerializeField] private bool flipped = false;
    [SerializeField]private bool cardDestroy = false;
    [SerializeField] private bool points;

    [SerializeField]InputManager inputManager;
    int textOption;
   public int i = 0;
   

    void Awake()
    {
        inputManager = GameObject.FindGameObjectWithTag("Player").GetComponent<InputManager>();
        cardDestroy = false;
        points = false;
        Tdescription.text = card[i].description;
        TincreaseOption.text = card[i].increaseOption;
        TdecreaseOption.text = card[i].decreaseOption;
        
    }
    private void Update()
    {
         if(!flipped)
         {
            FlipItem();
         }
        if (cardDestroy == true && points == false && i + 1 < card.Length )
        {
            i++;
            flipped = false;
            cardDestroy = false;

                if(card[i].isAnswer == true)
                {
                    if(textOption == 1)
                    {
                        Tdescription.text = card[i].increaseText;
                        TincreaseOption.text = card[i].increaseOption;
                        TdecreaseOption.text = card[i].decreaseOption;
                    }
                    else if(textOption == -1)
                    {
                        Tdescription.text = card[i].decreaseText;
                        TincreaseOption.text = card[i].increaseOption;
                        TdecreaseOption.text = card[i].decreaseOption;
                    }
                }
                else
                {
                    Tdescription.text = card[i].description;
                    TincreaseOption.text = card[i].increaseOption;
                    TdecreaseOption.text = card[i].decreaseOption;  

                }
           
        }

         if(inputManager.side == 1)
        {
            if(points == false)
            {
                textOption = card[i].Points(card[i].increaseOption);
                points = true;
            }
            cardDestroy = true;  
            flipped = false;
        }
        else if(inputManager.side == -1)
        {
            if(points == false)
            {
                textOption = card[i].Points(card[i].decreaseOption);
                points = true;
            }
            cardDestroy = true;
            flipped = false;
        }
    }

    void FlipItem() {
        float speed = Time.deltaTime * 300f;
        if (this.transform.rotation.eulerAngles.y > 90)  
            cardD.sprite = card[i].frontCardSprite;

        if (this.transform.rotation.eulerAngles.y < 180)
            this.transform.Rotate(0, speed, 0);
        else
        {
            this.transform.rotation = Quaternion.Euler(0,0,0);
            flipped = true;
            inputManager.side = 0;
            points = false;
        }
    }
}