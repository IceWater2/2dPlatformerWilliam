using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

public class Sundowner : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer mySpriteRender;
    public Sprite badBoss;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mySpriteRender.sprite = badBoss;
    }