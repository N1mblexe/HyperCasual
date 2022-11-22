using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Shop : MonoBehaviour
{
    [SerializeField] private string[] Items;
    [SerializeField] private int[] prices;
    [SerializeField] private TextMeshProUGUI Item1, Item2, Item3,Item1P,Item2P,Item3P;
    public void SatýnAl(string ItemName)
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (ItemName == Items[i])
            {
                if (MissionSystem.cash >= prices[i])
                {
                    MissionSystem.cash -= prices[i];
                }
            }

        }
    }

     void Start()
    {

      Item1.text = Items[0];
      Item2.text = Items[1];
      Item3.text = Items[2];
      Item1P.text = prices[0].ToString();
      Item2P.text = prices[1].ToString();
      Item3P.text = prices[2].ToString();
    }
}
