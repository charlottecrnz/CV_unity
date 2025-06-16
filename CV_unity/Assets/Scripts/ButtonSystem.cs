using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSystem : MonoBehaviour
{
    [SerializeField] private GameObject Alternance;
    [SerializeField] private GameObject Stage;
    [SerializeField] private GameObject Bouton_Scolaire;
    [SerializeField] private GameObject Bouton_Perso;
    [SerializeField] private GameObject Scolaire;
    [SerializeField] private GameObject Perso;
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

            case "Experience":
                SceneManager.LoadScene("CV_experience");
                break;

            case "Scolaire":
                Scolaire.SetActive(true);
                Perso.SetActive(false);
                Bouton_Scolaire.SetActive(false);
                Bouton_Perso.SetActive(false);
                break;

            case "Perso":
                Scolaire.SetActive(false);
                Perso.SetActive(true);
                Bouton_Scolaire.SetActive(false);
                Bouton_Perso.SetActive(false);
                break;



            default:
                break;
        }
    }
}
