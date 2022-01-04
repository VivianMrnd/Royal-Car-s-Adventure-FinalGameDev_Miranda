
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;
    

    private void Update()
    {
        transform.position = car.position + offset;
    }
   
}
