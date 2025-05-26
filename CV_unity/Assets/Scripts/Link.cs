using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Link : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text textMeshPro;

    void Awake()
    {
        if (textMeshPro == null)
            textMeshPro = GetComponent<TMP_Text>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(textMeshPro, Input.mousePosition, Camera.main);
        
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = textMeshPro.textInfo.linkInfo[linkIndex];
            string linkID = linkInfo.GetLinkID();
            // Debug.Log("Lien cliqué : " + linkID);

            if (linkID == "publication")
            {
                Application.OpenURL("https://ieeexplore.ieee.org/abstract/document/10390043");
            }
        }
    }
}