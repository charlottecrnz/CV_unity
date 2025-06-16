using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slidder;
    [SerializeField] private TextMeshProUGUI txt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slidder.onValueChanged.AddListener((v) =>
        {
            switch (v) {
                case 1:
                    txt.text = "Projet de première année";
                    break;
                case 2:
                    txt.text = "Projet de deuxième année";
                    break;
                case 3:
                    txt.text = "Projet 1 de troisième année";
                    break;
                case 4:
                    txt.text = "Projet 2 de troisième année";
                    break;
                default:
                    break;
            }
            //txt.text = v.ToString("0");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
