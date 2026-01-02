using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private bool isOpen = false;
    [SerializeField] private float openHeight = 2f;
    [SerializeField] private float openSpeed = 3f;

    private Vector3 originalPosition;
    private Vector3 targetPosition;

    void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + Vector3.up * openHeight;
    }

    void Update()
    {
        Vector3 target = isOpen ? targetPosition : originalPosition;
        transform.position = Vector3.Lerp(transform.position, target, openSpeed * Time.deltaTime);
    }

    public void SetOpen(bool open)
    {
        isOpen = open;
    }
}