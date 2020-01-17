using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMap : MonoBehaviour
{
    private Camera mainCamera;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float posX = -1 * mainCamera.transform.forward.x/1.5f;
        float posZ = -1 * mainCamera.transform.forward.z/1.5f;


        GetComponent<RectTransform>().localPosition = new Vector3(posX, -1.2f, posZ);

        GetComponent<RectTransform>().localRotation = Quaternion.Euler(new Vector3(0, mainCamera.transform.rotation.eulerAngles.y - 180,0));
    }
}
