using OWML.Common;
using OWML.ModHelper;
using UnityEngine.InputSystem;

namespace SuperNovaOnDemand
{
    public class SuperNovaOnDemand : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"Mod {nameof(SuperNovaOnDemand)} is loaded!", MessageType.Success);
        }

        private void Update()
        {
            if (Keyboard.current[Key.N].wasPressedThisFrame)
            {
                GlobalMessenger.FireEvent("TriggerSupernova");
            }
        }
    }
}
