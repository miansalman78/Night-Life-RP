using UnityEngine;

namespace Prototype.Player
{
    public class PrototypePlayerController : MonoBehaviour
    {
        [Header("References")]
        private JUTPS.CharacterBrain.JUCharacterController characterController;

        private void Start()
        {
            characterController = GetComponent<JUTPS.CharacterBrain.JUCharacterController>();
            if (characterController == null)
            {
                Debug.LogWarning("[Prototype] JUCharacterController component not found on player object.");
            }
        }
    }
}
