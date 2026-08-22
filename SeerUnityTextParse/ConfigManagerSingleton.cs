using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using common;
using core.config;

public abstract class ConfigManagerSingleton<T> : ResetableSingleTon<T> where T : IResetable, new()
{

    protected bool m_isNeedUpdate = true;

    private List<IConfigRoot> m_ConfigList;

    public override void Reset() { }
}

