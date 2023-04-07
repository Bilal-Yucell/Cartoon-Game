using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerTrigger : MonoBehaviour
{
    public static int cheeseCount = 0;
    public TextMeshProUGUI TM_cheese;
    public Animator animator;

    /* void Start()
    {
        
    }
    */

    /* void Update()
    {
        
    }
    */

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("Cheese"))
        {
            trigger.gameObject.transform.parent.gameObject.GetComponent<AudioSource>().Play();
            cheeseCount++;
            Debug.Log("Çarptı " + cheeseCount.ToString());
            TM_cheese.SetText(cheeseCount.ToString());
            Destroy(trigger.gameObject);
            Destroy(trigger.gameObject.transform.parent.gameObject, 1f);

        }

        if (trigger.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Engeli Gecti");
            Destroy(trigger.gameObject, 1f);
        }

        if (trigger.gameObject.CompareTag("Finish"))
        {
            animator.SetTrigger("GoToFinal");

        }
    }


}
