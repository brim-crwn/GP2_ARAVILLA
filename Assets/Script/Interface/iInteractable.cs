using UnityEngine;

public interface iInteractable
{
    //No public/ private Modifiers are allowed here
    //Because interface members are public by definition
    void Interact(GameObject interactor);

}
