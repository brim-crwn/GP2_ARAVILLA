using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    public float attackPower = 25f;

    private void Update()
    {
        //0 =  LMB
        //1 = RMB
        //2 = MMB
        //If Enemy is clicked, they get damaged by the attackPower of the player.
        //We use Raycast to detect if the mouse is over an enemy.
        //Left Click triggers RAYCAST attack from camera
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hitInfo, 100f))
            {
                //We search exclusively for the Enemy with Actor Deprivation
                Actor targetActor = hitInfo.collider.GetComponent<Actor>();
                if (targetActor != null)
                {
                    Debug.Log($"You assualted the {targetActor.name}");
                    targetActor.TakeDamage(attackPower);
                }
            }
        }
    }
}
