using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject objectToShow;
    public AudioClip clip;

    public void hide()
    {
        //objectToShow.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectToShow.SetActive(true);
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
    }
}