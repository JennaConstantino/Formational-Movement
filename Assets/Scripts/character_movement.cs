using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class character_movement : MonoBehaviour
{
    private float moveSpeed;
    private float radiusOfSatisfaction;
    [SerializeField] private Transform myTransform;
    [SerializeField] private Transform targetTransform;
    [SerializeField] private int formationNumber;
    [SerializeField] private Vector3 formationVariation; // difference from the main player (finger 4)

    void Start()
    {
        moveSpeed = 10f;
        radiusOfSatisfaction = 1.25f;
    }


    void Update()
    {
        RunKinematicArrive();
    }

    private void RunKinematicArrive() {
        Vector3 towardsTarget = targetTransform.position - myTransform.position + formationVariation; // adds difference in transform to maintain finger four

        if (towardsTarget.magnitude <= radiusOfSatisfaction) {
            return;
        }

        towardsTarget = towardsTarget.normalized;

        Quaternion targetRotation = Quaternion.LookRotation(towardsTarget);
        myTransform.rotation = Quaternion.Lerp(myTransform.rotation, targetRotation, 0.1f);

        Vector3 newPosition = myTransform.position;
        newPosition += myTransform.forward * moveSpeed * Time.deltaTime;


        myTransform.position = newPosition;
    }

}
