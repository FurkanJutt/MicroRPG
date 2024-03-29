using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string StoryText;
    [SerializeField] State[] nextState;
    public string GetStateText()
    {
        return StoryText;
    }

    public State[] GetNextState()
    {
        return nextState;
    }
}
