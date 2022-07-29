using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Various : MonoBehaviour
{
    private float timer;
    public Image stateImage;
    public Sprite[] stateIcon;
    // Start is called before the first frame update
    void Start() //���η�ƾ
    {
        //StartCoroutine(Cotest());
        //Test();
        //InvokeRepeating :Ư���Լ� 1�ʵ� ������ 3�ʸ��� �ݺ��ϰ��ϴ��Լ�
        InvokeRepeating("Position", 1, 3);

        StartCoroutine(Paint());
    }

    /*public void Test()
    {
        for(int i=0;i<3;i++)
        {
            Debug.Log("[Sub]");
        }
    }*/
   /* IEnumerator Cotest()
    {
        Debug.Log("[Co1]");
        yield return new WaitForSeconds(1);
        Debug.Log("[Co2]");
        Debug.Log("[Co3]");
    }*/
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 5.0f)
        {
            Invoke("ChangeSprite", 0);

            timer = 0.0f;
        }
    }
    public IEnumerator Paint()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);

            gameObject.GetComponent<Renderer>().material.color = new Color
            (
                Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2)
            );
                
            
        }
    }
    public void ChangeSprite()

    {
        switch (Random.Range(0,3))
        {
            case 0: stateImage.sprite = stateIcon[0];
                break;
            case 1:
                stateImage.sprite = stateIcon[1];
                break;
            case 2:
                stateImage.sprite = stateIcon[2];
                break;
        }
    }

    public void Position()
    {
        transform.position = new Vector3
            (Random.Range(-2.5f, 2.5f), 0, Random.Range(-2.5f, 2.5f));
    }
}
