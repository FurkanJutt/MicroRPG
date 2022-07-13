using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicroGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textComponent.text = state.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextState();
        for (int i = 0; i < nextState.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                state = nextState[i];
        }
        textComponent.text = state.GetStateText();
    }
}
