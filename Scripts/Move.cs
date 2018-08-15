using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField]
    private float moveSpeed = 5.0f;//移動速度
    private Vector3 velocity;   //移動方向
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            velocity.z -= 1;
        if (Input.GetKey(KeyCode.A))
            velocity.x += 1;
        if (Input.GetKey(KeyCode.S))
            velocity.z += 1;
        if (Input.GetKey(KeyCode.D))
            velocity.x -= 1;

        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            //プレイヤー位置の更新
            transform.position += velocity;
        }
    }
}
