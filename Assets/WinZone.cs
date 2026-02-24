using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winPanel; 
    void Start()
    {
      if (winPanel != null)
          winPanel.SetActive(false); 
          
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (winPanel != null)
                winPanel.SetActive(true); // Show "You are win"

            // Stop the ball
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.isKinematic = true;
            }

        }
    }


}
