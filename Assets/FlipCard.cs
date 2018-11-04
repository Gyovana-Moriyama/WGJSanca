using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour {

    public Sprite front;
    private bool flipped = false;

    private void Update() {
        if(!flipped)
           FlipItem();
    }

    void FlipItem() {
        float speed = Time.deltaTime * 300f;
        if (this.transform.rotation.eulerAngles.y > 90)
            this.GetComponent<SpriteRenderer>().sprite = front;

        if (this.transform.rotation.eulerAngles.y < 180)
            this.transform.Rotate(0, speed, 0);
        else
            flipped = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(this.gameObject);
    }
}
