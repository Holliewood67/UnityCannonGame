using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public bool hasBeenScored = false;
    public WaterSplash waterSplash;

    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void CountAsScored ()
    {
        hasBeenScored = true;
    }

    //Spawns splash particles
    public IEnumerator MakeSplash ()
    {
        WaterSplash splashInstance = Instantiate(waterSplash);
        splashInstance.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        audioSource.pitch = Random.Range(0.7f, 1.3f);
        audioSource.volume = Random.Range(0.01f, 0.10f);
        audioSource.PlayOneShot(audioClips[Random.Range(0, 7)]);
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ScoreLine"))
        {
            int flipCoin = Random.Range(1, 2);
            if (flipCoin == 1)
            {
                StartCoroutine(MakeSplash());
            }
            
        }
    }
}
