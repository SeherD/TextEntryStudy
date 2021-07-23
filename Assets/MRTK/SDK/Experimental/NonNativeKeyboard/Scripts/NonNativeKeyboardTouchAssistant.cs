using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.MixedReality.Toolkit.Experimental.UI
{
    /// <summary>
    /// Adds touch events to the NonNativeKeyboard buttons (and a tap sound)
    /// </summary>
    public class NonNativeKeyboardTouchAssistant : MonoBehaviour
    {
        [SerializeField]
        private AudioClip clickSound = null;

        private AudioSource clickSoundPlayer;

        private void Start()
        {
            if (CoreServices.InputSystem is IMixedRealityCapabilityCheck capabilityChecker && capabilityChecker.CheckCapability(MixedRealityCapability.ArticulatedHand))
            {
                EnableTouch();
            }
        }

        private void EnableTouch()
        {
            clickSoundPlayer = gameObject.AddComponent<AudioSource>();
            clickSoundPlayer.playOnAwake = false;
            clickSoundPlayer.spatialize = true;
            clickSoundPlayer.clip = clickSound;
            var buttons = GetComponentsInChildren<Button>();
           // var colliders= GetComponentsInChildren<BoxCollider>();
            foreach (var button in buttons)
            {
                var boxCollider=button.gameObject.EnsureComponent<BoxCollider>();
                var w=button.gameObject.GetComponent<RectTransform>().rect.width;
                var h = button.gameObject.GetComponent<RectTransform>().rect.height;
                boxCollider.size = new Vector3(w,h, 2);
                boxCollider.center= new Vector3(w/2, -h/2, 0);
                /*var ni = button.gameObject.EnsureComponent<NearInteractionTouchableUnityUI>();
                ni.EventsToReceive = TouchableEventType.Pointer;
                button.onClick.AddListener(PlayClick);*/
            }
            
        }

        private void PlayClick()
        {
            if (clickSound != null)
            {
                clickSoundPlayer.Play();
            }
        }
    }
}
