using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
   // public Text nameText;
    public Text dialogText;
    public float positionnum;
  //  public static playermovement Playermovement;
    private Queue<string> sentences;
 //   public float playerPositon playerposition;


    void Start()
    {
       
        sentences = new Queue<string>();
       
    }

    public void StartDialog (Dialog dialog)
    {
       // positionnum = dialog.position;
     //   if(positionnum < PlayerMovement.playerPositon + 1 && positionnum > PlayerMovement.playerPositon - 1  )
     //   { 
      //  nameText.text = dialog.name;

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
       // }
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }
    void EndDialog()
    {
        Debug.Log("End of conversation.");
    }
}
