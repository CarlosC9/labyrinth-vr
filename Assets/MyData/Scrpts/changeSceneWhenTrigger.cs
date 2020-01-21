using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneWhenTrigger : MonoBehaviour
{
    public int indexScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerWalk>().canWalk = false;
            SceneManager.LoadScene(indexScene);
        } 
    }
}
