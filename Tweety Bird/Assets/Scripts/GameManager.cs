using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int skor;
    public Text skorText;

    void Start()
    {
        skor = 0;
        skorText.text = skor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void SkorGuncelle()
    {
        skor++;
        skorText.text = skor.ToString();
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene(0);
    }
}
