using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSystem : MonoBehaviour
{
    [SerializeField] private GameObject Alternance;
    [SerializeField] private GameObject Stage;
    public void ButtonClick()
    {
        string TagObjet = gameObject.tag;
        switch (TagObjet)
        {
            case "RetourStage":
                Stage.SetActive(false);
                Alternance.SetActive(true);
                break;

            case "FermerExperience": 
                //Debug.Log("click");
                SceneManager.LoadScene("CV");

                break;

            case "SuivantAlternance":
                Alternance.SetActive(false);
                Stage.SetActive(true);
                break;

            case "Experience" :
                SceneManager.LoadScene("CV_experience");
                break;

            default:
                break;
        }
    }
}
