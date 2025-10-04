using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private List<ICommand> commnads;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        commnads = new List<ICommand>();
        
    }

    // Update is called once per frame
    void Update()
    {
        commnads.Clear();
        float horizontalInput = Input.GetAxis("Horizontal");
        commnads.Add(new MoveCommand(playerMovement, horizontalInput));
        
        foreach(ICommand command in commnads)
        {
            command.Execute();
        }
    }
}
