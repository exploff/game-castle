using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour
{
   
    public int coins;

    public static Inventory instance;

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

    public void RemoveCoins(int count) 
    {
        coins -= count;
    }
    
    public void AddCoins(int count) 
    {
        coins += count;
    }
}
