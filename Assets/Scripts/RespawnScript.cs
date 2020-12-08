using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartScene()
    {
        SceneManager.LoadScene("PixelPaced");
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }
}
