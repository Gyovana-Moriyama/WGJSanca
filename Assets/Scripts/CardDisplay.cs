using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public Card[] card;
    public TextMeshProUGUI Tdescription;
    public TextMeshProUGUI TincreaseOption;
    public TextMeshProUGUI TdecreaseOption;
    public Image image;
    [SerializeField] private bool flipped = false;
    [SerializeField]private bool cardDestroy = false;
    [SerializeField] private bool points;

    [SerializeField]InputManager inputManager;
  
    int i = 0;
   

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
        if (cardDestroy == true && i + 1 < card.Length )
        {
            i++;
            flipped = false;
            cardDestroy = false;
            Tdescription.text = card[i].description;
            TincreaseOption.text = card[i].increaseOption;
            TdecreaseOption.text = card[i].decreaseOption;
           
        }

         if(inputManager.side == 1)
        {
            if(points == false)
            {
                 card[i].Points(card[i].increaseOption);
                points = true;
            }
            cardDestroy = true;  
            flipped = false;
        }
        else if(inputManager.side == -1)
        {
            if(points == false)
            {
                 card[i].Points(card[i].decreaseOption);
                points = true;
            }
            cardDestroy = true;
            flipped = false;
        }
    }

    void FlipItem() {
        float speed = Time.deltaTime * 300f;
        if (this.transform.rotation.eulerAngles.y > 90) {
            image.sprite = card[i].frontCardSprite;
            //this.GetComponent<SpriteRenderer>().sprite = card[i].frontCardSprite;
        }

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