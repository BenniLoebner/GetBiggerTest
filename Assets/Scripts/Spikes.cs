using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] GameObject spikesOut;
    [SerializeField] float timeOutIn = 5f;
    [SerializeField] float timeInOut = 5f;
    [SerializeField] float volume = 1f;
    [SerializeField] AudioClip bladeOutSFX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpikesOut());
    }
    IEnumerator SpikesOut()
    {
        while(true)
        {
            AudioSource.PlayClipAtPoint(bladeOutSFX, transform.position, volume);
            GameObject mySpikesOut = Instantiate(spikesOut, transform.position, transform.rotation);
            yield return new WaitForSeconds(timeOutIn);
            Destroy(mySpikesOut);
            AudioSource.PlayClipAtPoint(bladeOutSFX, transform.position, volume);
            yield return new WaitForSeconds(timeInOut);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
