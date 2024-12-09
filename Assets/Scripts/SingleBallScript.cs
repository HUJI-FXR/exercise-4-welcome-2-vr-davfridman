using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Update()
    {        
        transform.Translate(transform.forward * Time.deltaTime * speed,
            Space.World);
		if (transform.position.z <= Camera.main.transform.position.z)
		{
			FindObjectOfType<GameManager>().EndLife();
		}
    }
	
	public void DestroyThisCurrentSphere()
    {
        GameManager.score++;
        Debug.Log(GameManager.score);
        Destroy(gameObject);		
    }
	
}
