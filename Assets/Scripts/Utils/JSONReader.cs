using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
    
public class JSONReader : MonoBehaviour
{

    public TextAsset textJSON;

    public HistoryTextList historyTextList = new HistoryTextList();

    [System.Serializable]
    public class HistoryTextList
    {
        public HistoryText[] historiesText;    
    }

    [System.Serializable]
    public class HistoryText
    {
        public string historyText;
        public string actionText;
        public string name;
        public string action;
    }
        
    void Start()
    {
        historyTextList = JsonUtility.FromJson<HistoryTextList>(textJSON.text);
    }
}