using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    public Transform target;
    private Vector3 offset;
    private Vector3 camePos;

    // Use this for initialization
    void Start () {
        offset = GetComponent<Transform>().position;
        camePos = offset;
    }
	
	// Update is called once per frame
	void Update () {
        camePos.x = target.position.x + offset.x;
        GetComponent<Transform>().position = camePos;
	}
}
