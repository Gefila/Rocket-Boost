using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;

    private void OnEnable()
    {
        thrust.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (thrust.IsPressed())
        {
            Debug.Log("Tombol Ditekan");
        }
    }
}
