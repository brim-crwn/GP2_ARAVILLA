using UnityEditor;
using UnityEngine;

public class TurretMechanics : MonoBehaviour
{
    //Target
    [SerializeField] private Transform target;

    //Rotation setting
    [SerializeField] private float rotationSpeed = 5f;

    //Alignment esque
    [SerializeField] private float alignmentThreshold = 0.98f;


    private void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 directionToTarget = (target.position - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }



}