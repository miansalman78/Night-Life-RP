using UnityEngine;

namespace Prototype.Core
{
    public class PrototypeManager : MonoBehaviour
    {
        [Header("Prototype Settings")]
        [SerializeField] private string gameVersion = "0.1.0-Prototype";
        [SerializeField] private bool useGermanUI = true;

        private void Awake()
        {
            Debug.Log($"[Prototype] Night Life RP Initialized. Version: {gameVersion}. German UI: {useGermanUI}");
        }
    }
}
