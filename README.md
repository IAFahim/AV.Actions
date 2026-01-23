# AV.Actions

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

Type-safe action identification system using `BovineLabs.Core` keys.

## ✨ Features

- **Action Keys**: Define generic action identifiers (e.g., "Attack", "Jump") in a centralized settings asset.
- **Type Safety**: Uses `ActionMonitor` scriptable objects to prevent string-based errors.
- **Performance**: Optimized key lookup via `BovineLabs.Core`.

## 📦 Installation

Install via Unity Package Manager (git URL).

### Dependencies
- **BovineLabs.Core**: Required for `KSettingsBase` and key management.

## 🚀 Usage

1. Open project settings or `BovineLabs` settings window.
2. Navigate to **Action** settings.
3. Create new `ActionMonitor` keys.
4. Reference `ActionMonitor` in your scripts instead of strings.

```csharp
[SerializeField] private ActionMonitor jumpAction;

public void PerformAction(ActionMonitor action)
{
    if (action == jumpAction) { ... }
}
```

## ⚠️ Status

- 🚧 **WIP**: Foundation package.
- 🧪 **Tests**: Missing.
- 📘 **Samples**: Included in `Samples~`.
