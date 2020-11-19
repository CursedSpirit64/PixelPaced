using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        

    }
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
    // Update is called once per frame
    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);   
    }
}
