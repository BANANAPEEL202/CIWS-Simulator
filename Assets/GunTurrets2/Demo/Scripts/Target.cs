using UnityEngine;

public class Target : MonoBehaviour
{
    // Public variables for the target's state and fire effect
    public bool isAlive = true; // Flag to indicate whether the target is alive
    public GameObject fireEffect; // Reference to the fire GameObject
    public GameObject explosionPrefab;

    void Start()
    {
        // Ensure the fire effect is deactivated initially if the target is alive
        if (fireEffect != null)
        {
            fireEffect.SetActive(false);
        }
    }

    void Update()
    {
        // Check the target's state and toggle the fire effect
        if (!isAlive)
        {
            ShowFireEffect();
        }
        else
        {
            HideFireEffect();
        }
    }

    // Method to activate the fire effect
    private void ShowFireEffect()
    {
        if (fireEffect != null && !fireEffect.activeSelf)
        {
            fireEffect.SetActive(true);
        }
    }

    // Method to deactivate the fire effect
    private void HideFireEffect()
    {
        if (fireEffect != null && fireEffect.activeSelf)
        {
            fireEffect.SetActive(false);
        }
    }

    // Method to simulate the target being killed (can be called from other scripts)
    public void KillTarget()
    {
        isAlive = false;
        
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }

    // Method to reset the target to its alive state (optional)
    public void ResetTarget()
    {
        isAlive = true;
    }
}