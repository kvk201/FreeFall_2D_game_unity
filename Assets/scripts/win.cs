
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("win");

        SceneManager.LoadScene("credits");
    }
}


/*TO DO
 -----------

-2. 
-1.  dialogues 
 //0.  Menu system
 1.  HUD
 2.  interactible objects? coins?
 3.  Music (different)
 4.  GDD
 5.  Game Instructions (Must be included inside game and as a text document in the repository wiki, and in the GDD. )
 6.  splash/title/credits
 7.  sources (readme?)
 8.  executable file (release directory)
    */
