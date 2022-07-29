using UnityEngine.UI;
using UnityEngine;

public class Switching : MonoBehaviour
{
    public Image buttonImage;
    public Sprite[] buttonSprite;
    public bool state;
   
    public void Behaviour()
    {
        
        state = !state;

        if(state)
        {
            Time.timeScale = 0; //게임속시간 0으로 일시정지
            buttonImage.sprite = buttonSprite[0];
        }
        else
        {
            Time.timeScale = 1;
            buttonImage.sprite = buttonSprite[1];
        }
    }
}
