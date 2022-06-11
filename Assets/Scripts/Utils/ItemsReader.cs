using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ItemsReader : MonoBehaviour
{

    public TextAsset textJSON;

    public ItemsList itemsList = new ItemsList();

    [System.Serializable]
    public class ItemsList
    {
        public Items[] items;

        public Items[] GetItems() { return items; } 

        public int Size() { return items.Length; }

        public Items GetItemAt(int index) { return items[index]; }

        public void RemoveItemAt(int indexToRemove) {
            var list = new List<Items>(this.items);
            list.RemoveAt(indexToRemove);
            this.items = list.ToArray();
        }

    }

    [System.Serializable]
    public class Items
    {
        public int id;
        public string name;
        public string title;
        public string description;
        public string action;
    }
        
    void Start()
    {
        itemsList = JsonUtility.FromJson<ItemsList>(textJSON.text);
    }

    public Items GetOneRandomItem() {
        System.Random rnd = new System.Random();
        if (this.itemsList.Size() > 0) {
            
            int nb = rnd.Next(0, this.itemsList.Size());
            Items item = this.itemsList.GetItemAt(nb);
            this.itemsList.RemoveItemAt(nb);
            return item;
        }
        return null;
    }
   
}
