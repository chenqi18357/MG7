using Unity.VisualScripting;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private float _interactionDistance;
    [SerializeField] private Transform playerTransform;
    private void Update()
    {
        foreach (GameObject s in sparrows)
        {
            if(Vector3.Distance(playerTransform.position, s.transform.position) < _interactionDistance)
            {
                s.SetActive(true);
            }
        }
    }
}