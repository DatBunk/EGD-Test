using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Positive;
    //public GameObject Negative;
    public float x = 0.5f;

    private bool Touch = false;

    private Vector3 OGposition;

    /*if(x>0 && transform.position.x<Positive.transform.position.x){
            transform.position = transform.position + new Vector3(x/20, 0, 0);
        }else if(transform.position.x == Positive.transform.position.x){
            Touch = true;
        }then{
            x = -x;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
        OGposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Touch == false){
            if(x>0 && transform.position.x<Positive.transform.position.x){
                transform.position = transform.position + new Vector3(x/20, 0, 0);
            }else{
                Touch = true;
            }
        }

        if(Touch == true){
            if(transform.position.x > OGposition.x){
                transform.position = transform.position - new Vector3(x/20, 0, 0);
            }else{
                Touch = false;
            }
        }
        
    }
}
