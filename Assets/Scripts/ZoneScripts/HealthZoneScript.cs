using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZoneScript : MonoBehaviour
{
    public float damage = -10f;

    private void OnTriggerEnter(Collider other)
    {
        TankGameEvents.OnObjectTakeDamageEvent?.Invoke(other.transform, damage);
    }
}
