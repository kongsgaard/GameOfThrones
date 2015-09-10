using UnityEngine;
using System.Collections;

public abstract class TerritoryBehaviorObserver : MonoBehaviour
{
    public abstract void UpdateUnits();

    public abstract void UpdatePowerToken();

	public virtual void UpdateOrderToken() { }
}
