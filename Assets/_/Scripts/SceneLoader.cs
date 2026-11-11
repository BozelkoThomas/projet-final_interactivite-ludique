using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public string nomDeLaScene = "Introduction";
    public float delaiAvantChangement = 0.4f; // Ajuste ce chiffre si tu veux que ce soit plus long ou plus court

    public void ChangeLaScene()
    {
        StartCoroutine(AttendreEtChanger());
    }

    IEnumerator AttendreEtChanger()
    {
        // Attend le nombre de secondes spécifié
        yield return new WaitForSeconds(delaiAvantChangement);

        // Change de scène après le délai
        SceneManager.LoadScene(nomDeLaScene);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}