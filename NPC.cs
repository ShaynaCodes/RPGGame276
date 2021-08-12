using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float npcPosition;

    private void FixedUpdate()
    {
        npcPosition = transform.position.x;
    }
}
