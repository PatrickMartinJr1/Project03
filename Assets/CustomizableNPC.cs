using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableNPC : MonoBehaviour
{
    [Header("NPC Type")]
    [SerializeField] private bool _enemy;
    [SerializeField] private bool _villager;
    [SerializeField] private bool _guard;

    [Header("Health")]
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _currentHealth;

    [Header("Movement")]
    [SerializeField] private int _movementSpeed;

    [Header("FOV and Detection")]
    [SerializeField] private float _radius;
    [SerializeField] [Range(0, 360)] private float _angle;
    [SerializeField] private LayerMask _targetMask;
    [SerializeField] private LayerMask _obstructionMask;


    [Header("Dialogue and SFX")]
    [SerializeField] private AudioClip[] _passingDialogueSFX;
    [SerializeField] private AudioClip[] _tookDamageSFX;
    [SerializeField] private AudioClip[] _deathSFX;

    [Header("VFX")]
    [SerializeField] private ParticleSystem _tookDamageParticles;
    [SerializeField] private ParticleSystem _deathPaticles;

}
