using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snakeBite : MonoBehaviour
{
    public GameObject EndDialog;

  

    void OntriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
           
            StartCoroutine(WaitBeforeShow());
        }

        IEnumerator WaitBeforeShow()
        {
            EndDialog.SetActive(true);
            yield return new WaitForSeconds(7);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


 


}
