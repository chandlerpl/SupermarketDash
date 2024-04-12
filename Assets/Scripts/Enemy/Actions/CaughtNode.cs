﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class CaughtNode : Node<AIMovement>
{
    public override bool Init(BehaviourTree<AIMovement> tree)
    {
        return true;
    }

    protected override NodeState Evaluate(AIMovement data)
    {
        // Caught the player! I need to do stuff here, but what?

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(3);

        return NodeState.Success;
    }
}