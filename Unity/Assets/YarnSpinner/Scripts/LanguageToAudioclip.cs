﻿using System;
using UnityEngine;

/// <summary>
/// A voiceover AudioClip and its associated language
/// </summary>
[Serializable]
public class LanguageToAudioclip {
    public LanguageToAudioclip(string Language, AudioClip AudioClip = null) {
        language = Language;
        audioClip = AudioClip;
    }

    public string language;
    public AudioClip audioClip;
}