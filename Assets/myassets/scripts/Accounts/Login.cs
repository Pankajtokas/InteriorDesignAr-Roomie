using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
    public InputField Username;
    public InputField Password;
    public Text info;
    private int logged;
    void Start(){
        PlayerPrefs.SetInt("loggedin",0);
    }

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Username.isFocused)
            {
                Password.Select();
            }
        }
    }

    public void CallLoginin()
    {
        if(Username.text=="" || Password.text=="")
        {
            info.color = Color.red;
            info.text="Please fill up all the fields";
            return;
        }
        StartCoroutine(Loginin());
    }

    

    // Update is called once per frame



    IEnumerator Loginin()
    {   
        
        WWWForm form = new WWWForm();
        form.AddField("name", Username.text);
        form.AddField("password", Password.text);
        string[] data; 
        WWW www = new WWW("http://192.168.1.3/AR/Login.php", form);

        yield return www;
        if (!string.IsNullOrEmpty(www.error)){
                Debug.Log(www.error);
                info.color = Color.red;
                info.text="Connection error";
        } else {
                string Playerdata = www.text;
                data = Playerdata.Split(',');
        
                if(Playerdata == "1")
                {
                    info.color = Color.red;
                    info.text="Incorrect username or password. Please try again.";
                }
                else
                {
                    info.color = Color.green;
                    info.text = "Login Successful";
                    int id = int.Parse(data[0].Split(':')[1]);
                    PlayerPrefs.SetInt("userid",id );
                    PlayerPrefs.SetString("username",data[1].Split(':')[1] );
                    PlayerPrefs.SetInt("loggedin",1);
                    yield return new WaitForSeconds(1);
                    UnityEngine.SceneManagement.SceneManager.LoadScene(3);
                }
        }
    }

   
}

