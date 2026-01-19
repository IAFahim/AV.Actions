using BovineLabs.Core.Keys;
using UnityEngine;

namespace AV.Actions.Integration.Monitor
{
    [HelpURL("https://github.com/IAFahim/AV.Actions")]
    [AddComponentMenu("AV/Actions/ActionMonitor")]
    public class ActionMonitor : MonoBehaviour
    {
        [K("ActionMonitorSettings")]
        public int ids;
    }
}