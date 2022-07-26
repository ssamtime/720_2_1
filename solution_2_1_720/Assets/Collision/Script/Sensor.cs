
using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }
    //OnTriggerEnter: �������� ������ ���������ʰ� �浹 ���� �� �����ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        video.Play();
    }
    //OnTriggerStay: �������� ����ʰ� �浹 ���� �� �����ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    //OnTriggerExit: �������� ���ϰ� �浹�� ����� �� �����ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
