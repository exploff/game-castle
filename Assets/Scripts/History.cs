using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class History : MonoBehaviour
{
    public GameObject history;
    public GameObject iconBook;

    public PlayerMovement playerMovement;

    public GameObject textHistory;
    public GameObject textAction;

    public JSONReader JSONReader;

    public int historyNumber = 0;
    
    public void ResetSelectedEvent()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void ClickOnIconBook() {

        if(history.active) {
            history.SetActive(false);
        } else {
            DisplayHistoryText();
            history.SetActive(true);
        }

        playerMovement.ManageMovement();
    }

    public void Update() {
            
    }

    public void Start() {        

        
    }

    public void DisplayHistoryText() {
        Debug.Log("Recuperation des valeurs");
        TMP_Text TMP_textHistory = textHistory.GetComponent<TMP_Text>();
        TMP_Text TMP_textAction = textAction.GetComponent<TMP_Text>();
        if (this.historyNumber <= this.JSONReader.historyTextList.historiesText.Length) {
            JSONReader.HistoryText historyText = this.JSONReader.historyTextList.historiesText[historyNumber];
            TMP_textHistory.text = historyText.historyText;
            TMP_textAction.text = historyText.actionText;
        }
        
    }



}
