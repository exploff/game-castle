using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public Text interactUI;
    private bool isInRange = false;
    public Animator animator;
    public int numberItems;

    public GameObject door;
    
    public Inventory inventory;
    public ItemsReader itemsReader;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInRange) {
            OpenChest();
        }
        
    }

    void OpenChest() {
        animator.SetTrigger("OpenChest");
        GetComponent<BoxCollider2D>().enabled = false;
        interactUI.enabled = false;
        for (int i = 0; i < numberItems; i++) {
            ItemsReader.Items item = this.itemsReader.GetOneRandomItem();
            if (item != null) {
                this.inventory.AddItem(item);
            }
        }

        if (this.door != null) {
            if(this.door.active) {
                this.door.SetActive(false);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collision) {  
        interactUI.enabled = true;
        isInRange = true;
        
    }

    void OnTriggerExit2D(Collider2D collision) {
        interactUI.enabled = false;
        isInRange = false; 
        
    }
}
