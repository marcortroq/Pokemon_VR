using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(1, "Bulbasaur", 2, 1, "This is a Bulbasaur"));
        cardList.Add(new Card(2, "Ivysaur", 3, 3, "This is an Ivysaur"));
        cardList.Add(new Card(3, "Venusaur", 4, 4, "This is a Venusaur"));
        cardList.Add(new Card(4, "Charmander", 2, 1, "This is a Charmander"));
        cardList.Add(new Card(5, "Charmeleon", 3, 3, "This is a Charmeleon"));
        cardList.Add(new Card(6, "Charizard", 4, 4, "This is a Charizard"));
    }
}
