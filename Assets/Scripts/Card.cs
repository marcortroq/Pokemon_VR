using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName; // Cambi� cardname a cardName
    public int cost;
    public int power;
    public string cardDescription;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription)
    {
        id = Id;
        cardName = CardName; // Cambi� cardname a cardName
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
    }
}
