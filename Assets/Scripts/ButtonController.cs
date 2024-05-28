using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject objectToShow;
    public GameObject mostrarCanvas;
    public GameObject button3;
    public GameObject button4;
    // Object to show when button1 is clicked



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            button1.SetActive(true);
            button2.SetActive(true);
            objectToShow.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            button1.SetActive(false);
            button2.SetActive(false);
            objectToShow.SetActive(false);
            mostrarCanvas.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
        }
    }

    
}

    