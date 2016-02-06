using UnityEngine;
using System.Collections;

public class Retray : MonoBehaviour {
    public Transform Player;
    private Vector3 StartPint;

    // Use this for initialization
    void Start () {
        StartPint = Player.position;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player.position = StartPint;
        }
    }

}
