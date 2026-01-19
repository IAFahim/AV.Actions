using System;
using System.Collections.Generic;
using System.Linq;
using BovineLabs.Core.Keys;
using BovineLabs.Core.Settings;
using UnityEngine;

namespace AV.Actions.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.Actions")]
    [SettingsGroup("Action")]
    public class ActionMonitorSettings : KSettingsBase<ActionMonitorSettings, int>
    {
        [SerializeField] private ActionMonitor[] keys = Array.Empty<ActionMonitor>();

        public override IEnumerable<NameValue<int>> Keys =>
            keys.Select(k => new NameValue<int>(k.friendlyName, (byte)k.ID));
    }
}