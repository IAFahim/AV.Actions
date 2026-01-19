using BovineLabs.Core.ObjectManagement;
using UnityEngine;

namespace AV.Actions.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.Actions")]
    public class ActionMonitor : ScriptableObject, IUID
    {
        public string friendlyName;
        [SerializeField] private byte id;

        public int ID
        {
            get => id;
            set => id = (byte)value;
        }
    }
}