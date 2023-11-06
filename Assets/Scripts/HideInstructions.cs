using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HideInstructions : MonoBehaviour
{
    public GameObject TextObject;
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        TextObject.SetActive(false);
    }
}
