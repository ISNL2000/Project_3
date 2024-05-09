using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundData_", menuName = "UnitData/Sound")]
public class SoundData : ScriptableObject
{
    [Header("Header 1")]
    [SerializeField] private AudioSource _audioSource;
    [SerializeField][Range(0, 100)] private int _volume;
    [SerializeField][Tooltip("Thing that does a thing")] private float toolTipDemo;


    [SerializeField] private int range = 10;

    [SerializeField] private TrackList _tracks = TrackList.Intro;


    public int Volume => _volume;
    public int Range => range;
}
