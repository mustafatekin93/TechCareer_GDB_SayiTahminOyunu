using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public int turSayisi;
    public TMP_Text turYazi;
    public TMP_Text kazanmaYazi;

    void Start()
    {
        turSayisi = PlayerPrefs.GetInt("turSayisi");

        if (turSayisi <= 10)
        {
            kazanmaYazi.text = "BEN KAZANDIM :)";
        }
        else
        {
            kazanmaYazi.text = "SEN KAZANDIN :(";
        }
        
        turYazi.text = "Oyun " + turSayisi.ToString() + " tur sürdü.";

    }
}
