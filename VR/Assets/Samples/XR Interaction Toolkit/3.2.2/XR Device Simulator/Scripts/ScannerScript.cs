using UnityEngine;

public class ScannerScript : MonoBehaviour
{
    [SerializeField] private DoorMovement door;
    [SerializeField] private Renderer display;
    [SerializeField] private Material greenMaterial;
    [SerializeField] private Material redMaterial;
    [SerializeField] private AudioClip scanSound;

    private bool isScanning = false;

    void Start()
    {
        display.material = redMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Badge") && !isScanning)
        {
            isScanning = true;

            display.material = greenMaterial;

            AudioSource.PlayClipAtPoint(scanSound, transform.position);

            door.SetOpen(true);

            StartCoroutine(CloseAfterDelay(5f));
        }
    }

    private System.Collections.IEnumerator CloseAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        display.material = redMaterial;

        door.SetOpen(false);

        isScanning = false;
    }
}