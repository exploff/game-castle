using UnityEngine;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public GameObject gameObject;

    public void SetHealth(int health) 
    {
        TMP_Text mText = gameObject.GetComponent<TMP_Text>();

        mText.text = health.ToString();

    }

}
