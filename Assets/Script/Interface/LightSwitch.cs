using UnityEngine;

public class LightSwitch : MonoBehaviour, iInteractable
{
    public GameObject lightSource;
    public bool isLightOn = true;

    public void Interact(GameObject interactor)
    {
        isLightOn = !isLightOn;
        if(lightSource != null)
        {
            lightSource.SetActive(isLightOn);
        }
        
    }
}
