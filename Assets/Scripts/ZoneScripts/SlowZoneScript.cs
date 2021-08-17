using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowZoneScript : MonoBehaviour
{
    public float slowAmount = 0.5f; // how much a tank is slowed by the zone
    public float premodifiedSpeed; // the speed the tank was moving before calculations

    private void OnTriggerEnter(Collider other)
    {
        TankGameEvents.OnMoveSpeedChangeEvent?.Invoke(other.transform, slowAmount);
        //premodifiedSpeed = other.GetComponent<Tank>().tankMovement.speed; // set a reference to how fast the tank was moving before the zone
        //other.GetComponent<Tank>().tankMovement.speed *= slowAmount; // slow the tank by slowAmount
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    other.GetComponent<Tank>().tankMovement.speed = premodifiedSpeed; // reset the tank to it's normal speed
    //}
}
