using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public TMP_InputField inputfield;
    public string enteredText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputfield = GetComponent<TMP_InputField>();
        inputfield.onEndEdit.AddListener(InputSubmit);
        Debug.Log(inputfield.text);
        enteredText = inputfield.text.ToString();
    
    }

    // Update is called once per frame
    void InputSubmit(string enteredText)
    {
        Debug.Log(enteredText);
    }
}
