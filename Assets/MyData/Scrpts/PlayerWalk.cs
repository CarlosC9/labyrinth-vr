using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float playerSpeed;
    private Vector3 newPosition;
    public bool canWalk = false;
    private Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float lookVerticalCamera = Camera.main.transform.forward.y;

        if (lookVerticalCamera > 0.7)
            canWalk = true;
        else if (lookVerticalCamera < -0.7)
        {
            canWalk = false;
            rg.velocity = new Vector3(0, 0, 0);
        }

        if (canWalk)
            rg.velocity = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z) * playerSpeed;
    }
}


