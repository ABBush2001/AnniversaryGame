using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextScene : MonoBehaviour
{
    public GameObject Abcde;
    public GameObject eventSystem;

    public void MoveToNextMemory()
    {
        if(eventSystem.GetComponent<MemoryDialogue>().dialogueFinished)
        {
            Abcde.GetComponent<AbcdeMovement>().moveSpeed = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
