using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedZoneScript : MonoBehaviour
{
    public float accelAmount = 1.5f; // how much a tank is accelerated by the zone
    public float premodifiedSpeed; // the speed the tank was moving before calculations

    private void OnTriggerEnter(Collider other)
    {
        TankGameEvents.OnMoveSpeedChangeEvent?.Invoke(other.transform, accelAmount);
        //premodifiedSpeed = other.GetComponent<Tank>().tankMovement.speed; // set a reference to how fast the tank was moving before the zone
        //other.GetComponent<Tank>().tankMovement.speed *= accelAmount; // slow the tank by slowAmount
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    other.GetComponent<Tank>().tankMovement.speed = premodifiedSpeed; // reset the tank to it's normal speed
    //}
}
