using UnityEngine;
using System.Collections;

public class MoveRoomba : MonoBehaviour
{
    public bool Move = false;
    public bool Forward, Left, Right, Back;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Move)
        {
            if (Forward)
            {
                transform.position += new Vector3(0, 0, 1);
            }
            if (Left)
            {
                transform.position -= new Vector3(1, 0, 0);
            }
            if (Right)
            {
                transform.position += new Vector3(1, 0, 0);
            }
            if (Back)
            {
                transform.position += new Vector3(0, 0, -1);
            }
        }
    }
}
