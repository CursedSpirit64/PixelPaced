using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestGoal : MonoBehaviour
{
    public Text winText;
    private bool FinishPlane = false;

    // Use this for initialization
    void Start()
    {
        FinishPlane = false;

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            FinishPlane = true;
            winText.text = "You Win!";

        }
    }
}
