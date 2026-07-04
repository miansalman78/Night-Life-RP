using UnityEngine;
using UnityEngine.UI;

namespace Prototype.UI
{
    public class PrototypeUIManager : MonoBehaviour
    {
        [Header("UI References")]
        [SerializeField] private GameObject interactPrompt;
        [SerializeField] private Text interactText;

        public void ShowInteractPrompt(string messageGerman)
        {
            if (interactText != null && interactPrompt != null)
            {
                interactText.text = messageGerman;
                interactPrompt.SetActive(true);
            }
        }

        public void HideInteractPrompt()
        {
            if (interactPrompt != null)
            {
                interactPrompt.SetActive(false);
            }
        }
    }
}
