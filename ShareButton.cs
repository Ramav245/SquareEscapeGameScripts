using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 

public class ShareButton : MonoBehaviour
{

    private string shareMessage; 


    private IEnumerator TakeScreenshotAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
        ss.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
        ss.Apply();

        string filePath = Path.Combine( Application.temporaryCachePath, "shared img.png" );
        File.WriteAllBytes( filePath, ss.EncodeToPNG() );

        // To avoid memory leaks
        Destroy( ss );

        new NativeShare().AddFile( filePath )
            .SetSubject( "SquareEscape!" ).SetText( shareMessage ).SetUrl( "https://github.com/yasirkula/UnityNativeShare" )
            .SetCallback( ( result, shareTarget ) => Debug.Log( "Share result: " + result + ", selected app: " + shareTarget ) )
            .Share();
    }

    public void ClickShareButton() 
    {
        shareMessage = "Check out this really cool game I found on the app store!";
        StartCoroutine(TakeScreenshotAndShare());
    }

}
