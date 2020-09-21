/*
 * Copyright (c) 2015 Allan Pichardo
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using UnityEngine;
using System;


public class BeatSideLines : MonoBehaviour
{
    public float Size = 1f;
    public float DirRandEsely = 2f;
    public float SzorzoForgas = 20000f;
    public int irany = 0;
    public float forog1 = 0f;
    public float forog2 = 0f;
    public float zenemeretes = 0;
    void Start()
    {
        //Select the instance of AudioProcessor and pass a reference
        //to this object
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);
        processor.onSpectrum.AddListener(onSpectrum);
    }

    //this event will be called every time a beat is detected.
    //Change the threshold parameter in the inspector
    //to adjust the sensitivity
    void onOnbeatDetected()
    {
        if (irany == 1) { transform.Rotate(Vector3.forward * Time.deltaTime * SzorzoForgas); }
        if (irany == 2) { transform.Rotate(Vector3.up * Time.deltaTime * SzorzoForgas); }
        if (irany == 3) { transform.Rotate(Vector3.left * Time.deltaTime * SzorzoForgas); }
        if (UnityEngine.Random.Range(1, 10) < DirRandEsely)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * SzorzoForgas);
        }

        
    }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum)
    {
        //The spectrum is logarithmically averaged
        //to 12 bands
        transform.Translate(Vector3.forward * Time.deltaTime * spectrum[2]*100f);
        transform.Rotate(Vector3.left * Time.deltaTime * forog1);
        transform.Rotate(Vector3.up * Time.deltaTime * forog2);
        if (zenemeretes == 0f)
        {
            transform.localScale = new Vector3(Size + Mathf.Abs(spectrum[2] * 0.1f), Size + Mathf.Abs(spectrum[2] * 0.1f), Size + Mathf.Abs(spectrum[2] * 0.1f));
        }
        else { transform.localScale = new Vector3(Size + Mathf.Abs(spectrum[2] * zenemeretes), Size + Mathf.Abs(spectrum[2] * zenemeretes), Size + Mathf.Abs(spectrum[2] * zenemeretes)); }
        /*for (int i = 0; i < spectrum.Length; ++i)
        {

        }*/
    }
}
