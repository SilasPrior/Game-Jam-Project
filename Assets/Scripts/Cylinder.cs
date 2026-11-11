using System.Collections.Generic;
using UnityEngine;

public class Cylinder
{
    public const int ChamberCount = 7;

    private bool[] _chambers = new bool[ChamberCount];

    private int _activeChamber;

    public int ActiveChamber
    {
        get => _activeChamber;

        private set
        {
            if (value < 0)
            {
                _activeChamber = 0;
            }
            else _activeChamber = value % ChamberCount;
        }
    }
    public List<int> GetLiveRounds()
    {
        List<int> liveRounds = new List<int>();
        for (int i = 0; i < ChamberCount; i++)
        {
            if (_chambers[i])
            {
                liveRounds.Add(i);
            }
        }
        return liveRounds;
    }
    public bool IsChamberLoaded(int chamberIndex)
    {
        if (chamberIndex < 0 || chamberIndex >= ChamberCount)
        {
            return false;
        }
        return _chambers[chamberIndex];
    }
    public void LoadChamber(int chamberIndex, bool value = true)
    {
        if (chamberIndex < 0 || chamberIndex >= ChamberCount)
        {
            return;
        }
        _chambers[chamberIndex] = value;
    }

    public void LoadRandomChamber()
    {
        List<int> emptyChambers = new List<int>();

        for (int i = 0; i < ChamberCount; i++)
        {
            if (!_chambers[i])
            {
                emptyChambers.Add(i);
            }
        }

        if (emptyChambers.Count == 0) return;

        int randomIndex = Random.Range(0, emptyChambers.Count);
        LoadChamber(emptyChambers[randomIndex], true);
    }
    public void EmptyCylinder()
    {
        _chambers = new bool[ChamberCount];
    }

    public void SpinCylinder()
    {
        _activeChamber = Random.Range(0, ChamberCount);
    }
    public bool Fire()
    {
        bool fired = IsChamberLoaded(_activeChamber);

        if (fired)
        {
            LoadChamber(_activeChamber, false);
        }

        ActiveChamber++;

        return fired;
    }

    public void ResetCylinder()
    {
        EmptyCylinder();
        SpinCylinder();
    }

    public Cylinder(int liveRounds)
    {

        ResetCylinder();
        for (int i = 0; i < liveRounds; i++)
        {
            LoadRandomChamber();
        }
    }

}
