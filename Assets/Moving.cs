using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public bool moved = false;


    // Start is called before the first frame update
    void Start()
    {
        ExampleCoroutine();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = transform.position;
        //Debug.Log(startPos);
    }

     
     IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
