using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryTrigger : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject promptText;
    [SerializeField] private GameObject promptButton;
    [SerializeField] private GameObject dialogueText;

    [SerializeField] private GameObject eventSystem;

    private bool inMemory;

    private void Start()
    {
        inMemory = false;
    }

    private void Update()
    {
        if(inMemory & Input.GetKeyDown(KeyCode.E))
        {
            promptText.SetActive(false);
            promptButton.SetActive(true);
            dialogueText.SetActive(true);
            eventSystem.GetComponent<MemoryDialogue>().Dialogue();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            panel.SetActive(true);
            promptText.SetActive(true);
            inMemory = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            panel.SetActive(false);
            promptText.SetActive(false);
            inMemory = false;
        }
    }
}
