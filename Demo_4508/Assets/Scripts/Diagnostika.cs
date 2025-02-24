using Immersal.AR;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Diagnostika : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointCloudVisualizerText;

    private bool areVisualizersActive = true;
    public Material[] materials;
    public GameObject gameObject;

    private void Start()
    {
        ToggleVisualizations(); // set them to false by default

    }

    public void ToggleVisualizations()
    {
        areVisualizersActive = !areVisualizersActive;
        pointCloudVisualizerText.text = !areVisualizersActive ? "Включить диагностику" : "Выключить диагностику";
        if (areVisualizersActive == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }
        if (areVisualizersActive == false)
        {
            gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }
    }
}