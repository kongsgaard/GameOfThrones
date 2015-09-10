using UnityEngine;
using System.Collections;

public abstract class SupplyTrackBehaviorObserver : MonoBehaviour 
{
    public abstract void NotifySupplyChanged();
}
