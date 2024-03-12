using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacterBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //print("player entered in trigger!");
        if (other.attachedRigidbody != null && other.attachedRigidbody.tag == "Boss")
        {
            print("trigger is a boss");
            SceneManager.LoadScene("Scenes/GameOver");
        }
    }
}
