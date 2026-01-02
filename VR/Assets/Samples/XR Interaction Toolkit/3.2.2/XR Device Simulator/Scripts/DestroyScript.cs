using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public AudioClip suono;

    public void Destroy()
    {

        // Se il suono è presente si tratta di una moneta, altrimenti della sfera sul tavolo
        if(suono != null){
            UIManager uiManager = FindFirstObjectByType<UIManager>();
            uiManager.UpdateScore();
            AudioSource.PlayClipAtPoint(suono, transform.position);
        }

        Destroy(gameObject);
    }
}
