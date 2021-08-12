using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public PlayerMovement playermovement;
    public NPC npc;

    public void TriggerDialog()
    {
        if ( npc.npcPosition < playermovement.playerPosition + 1 && npc.npcPosition > playermovement.playerPosition -1)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
        else
        {
            Debug.Log("Get CLoser to NPC");
        }
    }
}

