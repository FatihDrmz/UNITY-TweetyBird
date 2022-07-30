using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rigidbody;
    public bool olduMu;

    public GameManager game;

    public GameObject olumEkranı;
    public GameObject girisEkranı;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        //tıkalamayı aktifleştir
        if (Input.GetMouseButtonDown(0))
        {
            //kuşu zıplat
            rigidbody.velocity = Vector2.up * velocity;
            Destroy(girisEkranı, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            game.SkorGuncelle();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea") 
        {
            olduMu = true;
            Time.timeScale = 0;
            olumEkranı.SetActive(true);
        }
    }

}
