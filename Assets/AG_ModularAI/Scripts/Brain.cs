using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] private Motor motor;

    /// <summary>
    /// The possible states our AI agent can perform.
    /// </summary>
    public enum AIState
    { 
        /// <summary>
        /// Nothing yet. We need to choose something else.
        /// </summary>
        Undefined,
        /// <summary>
        /// Standing still.
        /// </summary>
        Idle,
        /// <summary>
        /// Moving towards the player character.
        /// </summary>
        Chasing,
        /// <summary>
        /// Moving away from the player character.
        /// </summary>
        Fleeing,
        /// <summary>
        /// Move *sideways* to avoid projectiles.
        /// </summary>
        Dodging
    }
    [SerializeField] private AIState state = AIState.Undefined;

    public GameObject playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        motor = GetComponent<Motor>();

        state = AIState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) state = AIState.Idle;
        if (Input.GetKeyDown(KeyCode.Alpha2)) state = AIState.Chasing;
        if (Input.GetKeyDown(KeyCode.Alpha3)) state = AIState.Fleeing;
        if (Input.GetKeyDown(KeyCode.Alpha4)) state = AIState.Dodging;

        switch (state)
        {
            case AIState.Undefined:
                // debug an error telling the developer to set a state
                break;
            case AIState.Idle:
                break;
            case AIState.Chasing:
                // we want to move towards the player character!
                motor.MoveTowardsPlayerCharacter();
                break;
            case AIState.Fleeing:
                motor.MoveAwayFromPlayerCharacter();
                break;
            case AIState.Dodging:
                motor.MoveSideways();
                break;
            default:
                break;
        }
    }
}
