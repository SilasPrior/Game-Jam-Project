using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class StashUI : MonoBehaviour
{
    public Transform contentGrid;
    public GameObject tarotItemUIPrefab;

    private StashClass _stash;

    public void Initialize(StashClass stash)
    {
        _stash = stash;
        RefreshGrid();
    }

    public void RefreshGrid()
    {
        if (_stash == null) return;

        foreach(Transform child in contentGrid)
        {
            GameObject.Destroy(child);
        }
        
        List<ITarotCard> tarotCards = _stash.GetCards();

        foreach(ITarotCard card in tarotCards)
        {
            if (card == null) continue;

            GameObject UI_Object = Instantiate(tarotItemUIPrefab);
            TarotItemUI itemUI = UI_Object.GetComponent<TarotItemUI>();
            itemUI.Initialize(card);
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RefreshGrid();
    }
}
