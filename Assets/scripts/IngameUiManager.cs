using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class IngameUiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu;
    public GameObject winpannel;
    public GameObject Losepannel;
    public GameObject winRoundspannel;
    public GameObject LoseRoundspannel;

    void Start()
    {
    PlayerPrefs.GetInt("RoundsCleared", 0);

        if (PlayerPrefs.GetInt("RoundsCleared") == 5)
        {
            PlayerPrefs.SetInt("RoundsCleared", 0);
        }   
        

    }
    public void onTaptostartpress()
    {
        Menu.SetActive(false);
    }
    public void onNextbuttonpress()
    {
        //FindObjectOfType<AdManager>().ShowAd();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void onretrybuttonpress()
    {
        //FindObjectOfType<AdManager>().ShowAd();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void win()
    {
        if (!winpannel.activeInHierarchy)
        {
            winpannel.SetActive(true);
            PlayerPrefs.SetInt("RoundsCleared", (PlayerPrefs.GetInt("RoundsCleared") + 1));
            for(int i = 1; i <= PlayerPrefs.GetInt("RoundsCleared"); i++)
            {
                winRoundspannel.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
                winRoundspannel.transform.GetChild(i).transform.GetChild(3).gameObject.SetActive(true);
            }
            

            FindObjectOfType<player>().gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            FindObjectOfType<Enemy>().gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            if (PlayerPrefs.GetInt("RoundsCleared") == 5)
            {
                PlayerPrefs.SetInt("RoundsCleared", 0);
            }

        }

    }
    public void lose()
    {
        if (!Losepannel.activeInHierarchy)
        {
            Losepannel.SetActive(true);
            LoseRoundspannel.transform.GetChild(PlayerPrefs.GetInt("RoundsCleared")+1).transform.GetChild(1).gameObject.SetActive(true);
            LoseRoundspannel.transform.GetChild(PlayerPrefs.GetInt("RoundsCleared")+1).transform.GetChild(3).gameObject.SetActive(true);

            FindObjectOfType<player>().gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            FindObjectOfType<Enemy>().gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            PlayerPrefs.SetInt("RoundsCleared", 0);
            //AdManager.instance.ShowAd();
        }
       
    }

}
