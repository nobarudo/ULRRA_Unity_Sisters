using UnityEngine;
using System.Collections;

public class Blocktriangle : MonoBehaviour {
    public Transform blockPrefab;
    public int S;
    public Vector3 placePosition;
    public Transform topWall;

    // Use this for initialization
    void Start()
    {
        placePosition = new Vector3(
            topWall.position.x, topWall.position.y,
            topWall.position.z - topWall.localScale.z);
        Quaternion q = Quaternion.identity;

        for (int j = 0; j < S; j++)
        {
            for (int i = 0; i < S-j; i++)
            {
                Instantiate(blockPrefab, placePosition, q);
                placePosition.x += blockPrefab.transform.localScale.x * 2;
            }
            placePosition = new Vector3(
            topWall.position.x + blockPrefab.transform.localScale.x * 2,
            placePosition.y + blockPrefab.transform.localScale.y * 2,
            topWall.position.z - topWall.localScale.z);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
