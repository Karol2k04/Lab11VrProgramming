using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    public InputActionProperty colorAction;
    private Renderer _renderer;

    void Start() => _renderer = GetComponent<Renderer>();

    void OnEnable() => colorAction.action.performed += ChangeColor;
    void OnDisable() => colorAction.action.performed -= colorAction.action.performed; // Poprawka: usunięcie subskrypcji

    void ChangeColor(InputAction.CallbackContext context)
    {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}