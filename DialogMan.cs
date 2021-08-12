using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogMan : MonoBehaviour
{
    public List<Dialog> dialog;
    public GameObject[] gonext;
    public int currentDialog;
    public Text DialogTxt;
    public GameObject Dialogpanel;

    int totalDialogs = 0;
    public int position;

    private void Start()
    {
        //   if(playerMovement.playerPosition == 1)
        //   { 
        totalDialogs = dialog.Count;
        Dialogpanel.SetActive(false);
        generateDialog();
        // }
    }

    public void Story()
    {
       // Quizpanel.SetActive(false);
        Dialogpanel.SetActive(true);
        //if position, displays this text
       /* if (score <= 3)
        {
            EndTxt.text = "ending 1";
        }
        if (score > 3 && score <= 8)
        {
            EndTxt.text = "ending 2";
        }
        if (score > 8)
        {
            EndTxt.text = "ending 3";
        }*/

    }


    void generateDialog()
    {
        if (dialog.Count > 0)
        {
            currentDialog = Random.Range(0, dialog.Count);

            DialogTxt.text = dialog[currentDialog].conversation;
            //SetAnswers();

        }
        else
        {
            Debug.Log("Out Of Conversation");
            Story();
        }

        // QnA.RemoveAt(currentQuestion);
    }
}
