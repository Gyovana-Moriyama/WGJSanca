using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
public class InputManager : MonoBehaviour
{

    private bool draggingItem = false;
    private GameObject draggedObject;
    private Vector2 touchOffset;
    public int side;
    public TextMeshProUGUI TincreaseOption;
    public TextMeshProUGUI TdecreaseOption;
    public Image background;

    void Awake()
    {
        TincreaseOption.enabled = false;
        TdecreaseOption.enabled = false;
        background.enabled = false;
    }

    void Update()
    {
        if (HasInput)
        {
            DragOrPickUp();
        }
        else
        {
            if (draggingItem && draggedObject != null)
            {
               side = DropItem();
            }
        }
    }

    Vector2 CurrentTouchPosition
    {
        get
        {
            Vector2 inputPos;
            inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return inputPos;
        }
    }

    private void DragOrPickUp()
    {
        var inputPosition = CurrentTouchPosition;

        if (draggingItem)
        {
            float rotation = inputPosition.x * -10;
            if (rotation > -15 && rotation < 15)
                draggedObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
            if (rotation > 0)
            {
                TincreaseOption.enabled = false;
                TdecreaseOption.enabled = true;
                background.enabled = true;
            }
            else if (rotation < 0)
            {
                TincreaseOption.enabled = true;
                TdecreaseOption.enabled = false;
                background.enabled = true;
            }
        }
        else
        {
            TincreaseOption.enabled = false;
            TdecreaseOption.enabled = false;
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null)
                {
                    draggingItem = true;
                    draggedObject = hit.transform.gameObject;
                }
            }
        }
    }

    private bool HasInput
    {
        get
        {
            // returns true if either the mouse button is down or at least one touch is felt on the screen
            return Input.GetMouseButton(0);
        }
    }

    public int DropItem()
    {
         Debug.Log(draggedObject.name);

        // Right
        if (draggedObject.transform.rotation.z < -0.10f)
        {
            Debug.Log("entrou no if < -0.1");
            TincreaseOption.enabled = false;
            TdecreaseOption.enabled = false;
            background.enabled = false;
            draggedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            draggingItem = false;
            return 1;
        }
        // Left
        if (draggedObject.transform.rotation.z > 0.10f)
        {
             Debug.Log("entrou no if < -0.1");
            TincreaseOption.enabled = false;
            TdecreaseOption.enabled = false;
            background.enabled = false;
            draggedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            draggingItem = false;
            return -1;
        }
        TincreaseOption.enabled = false;
        TdecreaseOption.enabled = false;
        draggedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        draggingItem = false;
        return 0;
    }

    void ThrowItem(int z)
    {
        // if (draggingItem) {
        //   float speed = Time.deltaTime * 10f;
        // draggedObject.transform.Translate(z * speed, 0, 0);
        // }
    }
}