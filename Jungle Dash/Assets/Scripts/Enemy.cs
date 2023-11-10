using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Vector2 screenBounds;
    private Rigidbody2D rigidBody;
    
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-speed , 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width , Screen.height , Camera.main.transform.position.z));
    }

    void Update()
    {
        rigidBody.velocity = new Vector2(-speed , 0);
        if(transform.position.x < -screenBounds.x*2){
            Destroy(this.gameObject);
        }
    }
    public bool HasReached(){
        float xPos = (float) transform.position.x;
        if(xPos == -3.8f){
            Debug.Log("YES");
        }
        return xPos == -3.8f;
    }
}
