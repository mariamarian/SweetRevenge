using UnityEngine;
using System.Collections;

public class usa2 : MonoBehaviour
{
    public GameObject GameOver;
    public float durata = 5f;

    private bool ruleaza = false;

    void Start()
    {
        if (GameOver != null)
            GameOver.SetActive(false);
    }

    void OnMouseDown()
    {
        if (!ruleaza)
            StartCoroutine(AfiseazaImagine());
    }

    IEnumerator AfiseazaImagine()
    {
        ruleaza = true;
        GameOver.SetActive(true);

        yield return new WaitForSeconds(durata);

        GameOver.SetActive(false);
        ruleaza = false;
    }
}