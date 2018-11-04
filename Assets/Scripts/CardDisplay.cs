using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public Card[] card;
    public TextMeshProUGUI Tdescription;
    public TextMeshProUGUI TincreaseOption;
    public TextMeshProUGUI TdecreaseOption;
    [SerializeField] private bool flipped = false;
    [SerializeField]private bool cardDestroy = false;
  
    int i = 0;
   

    void Awake()
    {
        cardDestroy = false;
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
        if (cardDestroy == true)
        {
            i++;
            flipped = false;
            cardDestroy = false;
            Tdescription.text = card[i].description;
            TincreaseOption.text = card[i].increaseOption;
            TdecreaseOption.text = card[i].decreaseOption;
           
        }
    }

    void FlipItem() {
        float speed = Time.deltaTime * 300f;
        if (this.transform.rotation.eulerAngles.y > 90)
            this.GetComponent<SpriteRenderer>().sprite = card[i].frontCardSprite;

        if (this.transform.rotation.eulerAngles.y < 180)
            this.transform.Rotate(0, speed, 0);
        else
            flipped = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        cardDestroy = true;
        Destroy(card[i]);
    }
}