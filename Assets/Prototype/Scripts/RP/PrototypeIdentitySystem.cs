using UnityEngine;

namespace Prototype.RP
{
    public class PrototypeIdentitySystem : MonoBehaviour
    {
        [Header("Identity Info")]
        [SerializeField] private string firstName = "Max";
        [SerializeField] private string lastName = "Mustermann";
        [SerializeField] private bool hasIDCard = false;
        
        [Header("Visual Settings")]
        [SerializeField] private bool isNameRevealed = false;

        public string GetFullName()
        {
            if (isNameRevealed)
            {
                return $"{firstName} {lastName}";
            }
            return "Unbekannter Spieler"; // "Unknown player" in German
        }

        public void RevealIdentity()
        {
            isNameRevealed = true;
            Debug.Log($"[RP] Identity revealed: {firstName} {lastName}");
        }

        public void HideIdentity()
        {
            isNameRevealed = false;
        }
    }
}
