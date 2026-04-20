using UnityEngine;


public class BowlCheck : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    public DogAI dog;

    void Update()
    {
        dog.toyInBowl = socket.hasSelection;
    }
}