using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles rotating the tank turret
/// </summary>
[System.Serializable]
public class TankTurret
{
    public Transform tankTurretTransform; // gets a reference to the the tank turret
    public float turretRotateSpeed = 180f; // how fast the turret can rotate
    private bool enableTurret; // can the turret rotate?

    /// <summary>
    /// Sets up all the necessary variables for the turret script
    /// </summary>
    public void SetUp()
    {
        tankTurretTransform.rotation = new Quaternion(0f, 0f, 0f, 0f);
    }

    /// <summary>
    /// Tells us whether the tank turret can be rotated or not
    /// </summary>
    /// <param name="Enabled"></param>
    public void EnableTankTurret(bool Enabled)
    {
        enableTurret = Enabled;
    }

    public void HandleTurret(float turretRotation)
    {
        // if we can't move don't
        if (enableTurret == false)
        {
            return;
        }
        Rotate(turretRotation); // rotates the turret

    }

    /// <summary>
    /// Rotates the turret on the y axis
    /// </summary>
    /// <param name="turretRotation"></param>
    public void Rotate(float turretRotation)
    {
        Vector3 turnAngle = new Vector3(0f, turretRotation * turretRotateSpeed * Time.deltaTime, 0f); // the angle in degrees we want to turn our turret

        tankTurretTransform.transform.Rotate(turnAngle); // update the turret with this new rotation
    }
}
