using UnityEngine;

public class coinScript : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Transform>().Rotate(2f, 0f, 0f);
    }
}
