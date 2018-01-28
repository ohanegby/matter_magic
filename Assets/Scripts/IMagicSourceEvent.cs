using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IMagicSourceEvent : IEventSystemHandler
{
    void MagicSourceEnergy();
    void MagicSourceEnergyExit();
    void MagicSourceType(string magicType);
}
