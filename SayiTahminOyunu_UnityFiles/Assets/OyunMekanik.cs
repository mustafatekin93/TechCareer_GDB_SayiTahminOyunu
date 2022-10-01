using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OyunMekanik : MonoBehaviour
{
    public TMP_Text pcTahmin;
    public TMP_Text turSayisiText;
    int minTahmin = 1;
    int maxTahmin = 1501;
    int turSayisi = 0;
    int randomSayi;
    int newRandom;
    // Start is called before the first frame update
    void Start()
    {
        randomSayi = Random.Range(minTahmin, maxTahmin);
        pcTahmin.text = randomSayi.ToString();
        turSayisiArttir();
    }

    public void Arttır()
    {
        minTahmin = randomSayi;
        randomSayi = (minTahmin + maxTahmin) / 2;
        pcTahmin.text = randomSayi.ToString();
        turSayisiArttir();
    }

    public void Azalt()
    {
        maxTahmin = randomSayi;
        randomSayi = (minTahmin + maxTahmin) / 2;
        pcTahmin.text = randomSayi.ToString();
        turSayisiArttir();
    }

    public void Dogru()
    {
        SceneManager.LoadScene(1);
    }

    void turSayisiArttir()
    {
        turSayisi++;
        PlayerPrefs.SetInt("turSayisi", turSayisi);
        turSayisiText.text = "Tur sayısı: " + turSayisi.ToString();
    }

}
