using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCubeWhenLookDown : MonoBehaviour
{
    public GameObject objectDestroy;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!other.gameObject.GetComponent<PlayerWalk>().canWalk)
            {
                Destroy(objectDestroy);
                Destroy(gameObject);
            }
        }
    }
}
