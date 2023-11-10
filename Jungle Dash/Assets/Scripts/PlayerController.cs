using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isWalking = false, normalHit = false , frontHit = false , backHit = false , throwItem = false , upHit = false , downHit = false , isAlive = true;
    [SerializeField] private int health = 3;
    private int currentHearts = 3;
    private int previousHearts = 3;
    private bool hitTaken = false;

    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite nullHeart;

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
        if(health == 0){
            isAlive = false;
        }
        currentHearts = health;
        foreach (Image img in hearts)
        {
            img.sprite = nullHeart;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
        if(currentHearts < previousHearts){
            hitTaken = true;
        }
        else{
            hitTaken = false;
        }
        previousHearts = currentHearts;
    }
    public bool Damage(){
        return hitTaken;
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
    public bool IsAlive(){
        return isAlive;
    }
}
