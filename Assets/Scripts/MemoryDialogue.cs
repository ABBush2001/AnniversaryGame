using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MemoryDialogue : MonoBehaviour
{
    [SerializeField] private string[] dialgoue = new string[4];

    [SerializeField] private GameObject dialogueText;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject buttonText;
    [SerializeField] private GameObject promptText;

    [SerializeField] private GameObject eventSystem;

    public bool dialogueStarted;
    public bool dialogueFinished;

    [SerializeField] private int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        dialogueStarted = false;
        dialogueFinished = false;
    }

    private void Update()
    {
        if(dialogueStarted && Input.GetKeyDown(KeyCode.E))
        {
            i++;
            Dialogue();
        }
    }

    public void Dialogue()
    {
        dialogueStarted = true;

        if(i < 4)
        {
            dialogueText.GetComponent<TextMeshProUGUI>().text = dialgoue[i];    
        }
        else
        {
            dialogueText.SetActive(false);
            buttonText.SetActive(false);
            panel.SetActive(false);
            promptText.SetActive(false);
            dialogueStarted = false;
            dialogueFinished = true;
            eventSystem.GetComponent<MoveToNextScene>().MoveToNextMemory();
        }

    }
}
