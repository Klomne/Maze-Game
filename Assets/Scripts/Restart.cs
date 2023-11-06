using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class restartGame : MonoBehaviour
{
    bool restart;
    void Awake()
    {
        restart = false;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) && !restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}