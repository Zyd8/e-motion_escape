using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour, IInteractible
{
    [SerializeField] public GameObject paddle;
    [SerializeField] public bool paddleTaken = false;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Got the Paddle");
        paddleTaken = true;
        paddle.SetActive(false);
        return true;
    }
}
