using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{

    public GameObject savePanel;
    public GameObject SendEmailPanel;
    public GameObject SendSmsPanel;
    public GameObject ThankyouPanel;
    // Start is called before the first frame update
    void Start()
    {
        savePanel.SetActive(true);
    }

    public void SendEmailbutton()
    {
        savePanel.SetActive(false);
        SendEmailPanel.SetActive(true);
    }
    public void SendSmSButton() 
    {
        savePanel.SetActive(false);
        SendSmsPanel.SetActive(true);
    }
    public void BackFromEmail()
    {
        savePanel.SetActive(true);
        SendEmailPanel.SetActive(false);
    }
    public void BackFromSmS()
    {
        savePanel.SetActive(true);
        SendSmsPanel.SetActive(false);
    }
    public void submit()
    {
        SendEmailPanel.SetActive(false);
        SendSmsPanel.SetActive(false);
        ThankyouPanel.SetActive(true);
        StartCoroutine(Thankyou());
    }
    IEnumerator Thankyou()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}