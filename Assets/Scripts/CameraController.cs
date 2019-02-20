using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform playerPosition;
    public Transform moveThreshold;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPosition.position.x > moveThreshold.position.x){
            // moveThreshold the camera with the player
            if(playerPosition.position.x>0){

            transform.position = new Vector3(playerPosition.position.x, transform.position.y, transform.position.z);
            }
        }
        else{

        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(moveThreshold.position, new Vector2(moveThreshold.position.x, moveThreshold.position.y+10));
        Gizmos.DrawLine(moveThreshold.position, new Vector2(moveThreshold.position.x, moveThreshold.position.y-10));
    }

}
