using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerpoints,enemypoints;
    private int PPoints, Epoints;
    public bool Enemystoppointer;
    public bool Playerstoppointer;
    public Text playerscore, enemyscore;
    public GameObject playercrown, enemycrown;
    public ParticleSystem ps;
    void Start()
    {
        PPoints = 0;
        Epoints = 0;
        Enemystoppointer = true;
        Playerstoppointer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(PPoints== Epoints)
        {
            playercrown.SetActive(false);
            enemycrown.SetActive(false);
        }
        else if (PPoints > Epoints)
        {
            playercrown.SetActive(true);
            enemycrown.SetActive(false);
        }
        else if (PPoints < Epoints)
        {
            playercrown.SetActive(false);
            enemycrown.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player" && Playerstoppointer)
        {

            
            if (PPoints<=4)
            {
                PPoints++;
                ps.Play();
                playerscore.text = PPoints.ToString();
                if (PPoints == 5)
                {
                    FindObjectOfType<IngameUiManager>().win();
                    Debug.Log("win");
                }
            }
            playerpoints.transform.GetChild(PPoints - 1).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            Playerstoppointer = true;
        }
        if (other.gameObject.tag == "Enemy" && Enemystoppointer)
        {
            if (Epoints <= 4)
            {
                Epoints++;
                ps.Play();
                FindObjectOfType<Enemy>().gameObject.GetComponent<ConstantForce>().force = new Vector3(0, -60, 0);
                enemyscore.text = Epoints.ToString();
                if (Epoints == 5)
                {
                    FindObjectOfType<IngameUiManager>().lose();

                }
            }
            enemypoints.transform.GetChild(Epoints - 1).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            Enemystoppointer = false;

        }
    }
}
