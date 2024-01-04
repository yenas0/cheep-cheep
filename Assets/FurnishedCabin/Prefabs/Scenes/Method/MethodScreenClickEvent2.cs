using UnityEngine;
using UnityEngine.SceneManagement;

public class MethodScreenClickEvent2 : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Notebook Clicked!"); // 클릭 이벤트 발생 확인용 로그

        // 화면 전환 또는 다른 동작을 여기에 구현
        // 예를 들어, 다른 Scene으로 전환하는 경우:
        SceneManager.LoadScene("presub"); // "YourSceneName"은 전환할 Scene의 이름으로 변경해야 합니다.
    }
}