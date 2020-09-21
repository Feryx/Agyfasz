﻿/*
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

public class size_2 : MonoBehaviour
{

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
        int x = UnityEngine.Random.Range(1, 2);
        if (UnityEngine.Random.Range(1, 10) < 2)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * 400000f);
        }


    }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum)
    {
        //The spectrum is logarithmically averaged
        //to 12 bands
        //        transform.Translate(0, 0, spectrum[1]);
        transform.localScale = new Vector3(1.6825213f + Mathf.Abs(spectrum[2] * 0.1f), 1.6825213f + Mathf.Abs(spectrum[2] * 0.001f), 1.6825213f + Mathf.Abs(spectrum[2] * 0.1f));
        for (int i = 0; i < spectrum.Length; ++i)
        {

        }
    }
}
