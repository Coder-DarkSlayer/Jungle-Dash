using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isWalking = false, normalHit = false , frontHit = false , backHit = false , throwItem = false , upHit = false , downHit = false , isAlive = true;

    private BGScroller VarySpeed;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            isWalking = true;
        }
        else{
            isWalking = false;
        }
        if(Input.GetKey(KeyCode.W)){
            upHit = true;
        }
        else{
            upHit = false;
        }
        if(Input.GetKey(KeyCode.S)){
            downHit = true;
        }
        else{
            downHit = false;
        }
        if(Input.GetKey(KeyCode.A)){
            backHit = true;
        }
        else{
            backHit = false;
        }
        if(Input.GetKey(KeyCode.D)){
            frontHit = true;
        }
        else{
            frontHit = false;
        }
        if(Input.GetKey(KeyCode.F)){
            normalHit = true;
        }
        else{
            normalHit = false;
        }
        if(Input.GetKey(KeyCode.C)){
            throwItem = true;
        }
        else{
            throwItem = false;
        }
    }
    public bool IsRunning(){
        return isWalking;
    }
    public bool Hitting(){
        return normalHit;
    }
    public bool FrontHIT(){
        return frontHit;
    }
    public bool BackHIT(){
        return backHit;
    }
    public bool ThrowITEM(){
        return throwItem;
    }
    public bool upHIT(){
        return upHit;
    }
    public bool DownHIT(){
        return downHit;
    }
}
