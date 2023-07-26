using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LinkedIn(){
        Application.OpenURL("https://www.linkedin.com/in/ashirika-bhardwaj-2a6930230");
    }
    public void mail(){
        Application.OpenURL("ashirikabhardwaj@gmail.com");
    }
    public void Github(){
        Application.OpenURL("https://github.com/Ashirika21");
    }
}
