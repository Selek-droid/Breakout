using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartButton : MonoBehaviour
{
    public Button gameStartButton;
    public InputField getPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        Button gameButton = gameStartButton.GetComponent<Button>();
        gameButton.onClick.AddListener(StartButtonClicked);

        // InputField getName = getPlayerName.GetComponent<InputField>();
        // getName.onEndEdit.AddListener(delegate { Gronk(); });

        // getName.ActivateInputField();
        // getName.onEndEdit.AddListener(ParrotName);
        // getPlayerName = getName;

        //  InputField inputField = getPlayerName.GetComponent<InputField>();
        // string testText = getPlayerName.text;
        
    }

    public void ParrotName()
    {
        string textText = getPlayerName.GetComponent<InputField>().text;
        Debug.Log("Input was " + textText);
    }

    public void Gronk()
    {
        // Debug.Log("You stopped typing!");
        InputField getName = getPlayerName.GetComponent<InputField>();
        string textMessage = getName.text;
        Debug.Log("You just typed " + textMessage);
    }

    public void StartButtonClicked()
    {
        Debug.Log("Clicked!");
        InputField getName = getPlayerName.GetComponent<InputField>();
        string textMessage = getName.text;
        NameKeeper.storedUsername = textMessage;
        SceneManager.LoadScene(1);
    }
    
}
