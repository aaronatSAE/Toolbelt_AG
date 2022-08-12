using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] private Brain aiBrain;
    [SerializeField] private float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        aiBrain = GetComponent<Brain>();
    }

    public void MoveTowardsPlayerCharacter()
    {
        transform.position = Vector3.MoveTowards(transform.position, aiBrain.playerCharacter.transform.position, moveSpeed * Time.deltaTime);
    }

    public void MoveAwayFromPlayerCharacter()
    {
        // TODO: The agent will not flee if it has the same position as the player character's position.
        transform.position = Vector3.MoveTowards(transform.position, aiBrain.playerCharacter.transform.position, -moveSpeed * Time.deltaTime);
    }

    public void MoveSideways()
    {
        // TODO: Get this working—make AI "strafe" using Vector3.Dot(...)
        //transform.position = Vector3.MoveTowards(transform.position, 
        //    new Vector3(aiBrain.playerCharacter.transform.position.x,
        //                aiBrain.playerCharacter.transform.position.y,
        //                aiBrain.playerCharacter.transform.position.z), moveSpeed * Time.deltaTime);
    }
}
