using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public GameObject Go;
    //public GameObject Goa;
    //public GameObject Gob;
    //public GameObject Goc;
    //public GameObject God;
    //public GameObject Goe;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Go);
        //Instantiate(Goa);
        //Instantiate(Gob);
        //Instantiate(Goc);
        //Instantiate(God);
        //Instantiate(Goe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
