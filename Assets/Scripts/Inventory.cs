using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public GameObject spriteItem1;
    public GameObject spriteItem2;
    
    public PlayerMovement playerMovement;

    public static Inventory instance;

    private int numberOfItems;

    private ItemsReader.Items item1;
    private ItemsReader.Items item2;

    private void Awake() 
    {
        if (instance == null) {
            instance = this;
        }
    }

    public void ResetSelectedEvent()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    
    public void ClickOnIconChest() {

        if(inventory.active) {
            inventory.SetActive(false);
        } else {
            DisplayInventoryItems();
            inventory.SetActive(true);
        }

        playerMovement.ManageMovement();
    }

    public void Update() {
        if(Input.GetKeyDown(KeyCode.M)){
            ClickOnIconChest();
        }
    }

    public void DisplayInventoryItems() {

        TMP_Text TMP_spriteItem1 = spriteItem1.GetComponent<TMP_Text>();
        TMP_Text TMP_spriteItem2 = spriteItem2.GetComponent<TMP_Text>();

        if(item1 == null) {
            TMP_spriteItem1.text = "Emplacement vide";
        } else {
            TMP_spriteItem1.text = item1.title + "\n" + item1.description;
        }
        if(item2 == null) {
            TMP_spriteItem2.text = "Emplacement vide";
        } else {
            TMP_spriteItem2.text = item2.title + "\n" + item2.description;
        }
    }

    public void AddItem(ItemsReader.Items items) {
        if(item1 == null) {
            item1 = items;
        }
        else if(item2 == null) {
            item2 = items;
        }
    }

    public void RemoveItem(ItemsReader.Items items) {
        if(item1.Equals(items)) {
            item1 = null;
        }
        if(item2.Equals(items)) {
            item2 = null;
        }
    }

}
