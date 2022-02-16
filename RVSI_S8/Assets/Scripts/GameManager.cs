using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField] private Animator lockerDoor = null;
    [SerializeField] private Animator exitDoor = null;
    [SerializeField] private GameObject key;
    private bool end = false;
 
    //On crée un singleton, et s'il existe déjà on détruit l'instance immédiatement
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        Invoke("gameOver", 600.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        if(end == false)
        {
            Debug.Log("Fin du jeu");
            SceneManager.LoadScene("Game Over");
        }
    }

    public void OuverturePorteLocker()
    {
        lockerDoor.SetTrigger("open");
    }

    public void ApparitionClef()
    {
        key.SetActive(true);
    }

    public void OuverturePorteSortie()
    {
        exitDoor.SetBool("isOpen", true);
        end = true;
    }
}
