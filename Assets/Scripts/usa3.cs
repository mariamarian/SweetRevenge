using UnityEngine;
using System.Collections;

public class usa3 : MonoBehaviour
{
    public GameObject VideoFalse;   
    public float durata = 5f;   
    private bool ruleaza = false;

    void Start()
    {
        if (VideoFalse != null)
            VideoFalse.SetActive(false);  
    }

    void OnMouseDown()
    {
        if (!ruleaza)
            StartCoroutine(AfiseazaVideo());
    }

    IEnumerator AfiseazaVideo()
    {
        ruleaza = true;
        VideoFalse.SetActive(true);

        yield return new WaitForSeconds(durata);

        VideoFalse.SetActive(false);
        ruleaza = false;
    }
}