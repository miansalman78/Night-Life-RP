using UnityEngine;

namespace Prototype.Vehicle
{
    public class PrototypeVehicleController : MonoBehaviour
    {
        [Header("Vehicle Properties")]
        [SerializeField] private string vehicleName = "Test Car";
        [SerializeField] private float maxSpeed = 100f;

        private void Start()
        {
            Debug.Log($"[Prototype] Vehicle {vehicleName} initialized.");
        }
    }
}
