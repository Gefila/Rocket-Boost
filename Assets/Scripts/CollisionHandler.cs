using Unity.Cinemachine;
using UnityEngine;

public class CollisionEnter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Finish":
                Debug.Log("Finish");
                break;
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Fuel":
                Debug.Log("Fuel");
                break;
            default:
                Debug.Log("Crashed");
                break;
        }
    }
}
