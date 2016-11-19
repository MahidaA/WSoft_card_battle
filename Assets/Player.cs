using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int player_number;
    string h_axis, v_axis;

    CharacterController cc;
    BoxCollider foot_collider;

    public float gravity;  //In units/s^2
    public float speed;

    float x_vel, y_vel, z_vel;
    Vector3 move;

    public bool grounded;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
        foot_collider = transform.FindChild("Feet").GetComponent<BoxCollider>();

        grounded = false;
        x_vel = 0;
        y_vel = 0;
        z_vel = 0;

        h_axis = "Horizontal" + player_number;
        v_axis = "Vertical" + player_number;
	}
	
	// Update is called once per frame
	void Update () {
        read_controls();
        update_motion();
	}

    void update_motion()
    {
        if (!grounded)
            y_vel -= gravity * Time.deltaTime;
        else
            y_vel = 0;

        move.x = x_vel;
        move.y = y_vel;
        move.z = z_vel;

        grounded = cc.SimpleMove(move);
    }

    void read_controls()
    {
        x_vel = Input.GetAxis(h_axis) * speed;
        z_vel = Input.GetAxis(v_axis) * speed;
    }
}
