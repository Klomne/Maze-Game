using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextManager textManager;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
        textManager.AddCoins();
        Destroy(gameObject);
    }
}
