using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0f, 5f, -7f);
    bool isFontView;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isFontView)
            {
                offset = new Vector3(0f, 2.5f, 1f);
                isFontView = false;
            }else if(!isFontView)
            {
                offset = new Vector3(0f, 5f, -7f);
                isFontView = true;
            }

        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camaera behide the player by adding the player's position 
        transform.position = player.transform.position + offset;

        
    }
}
