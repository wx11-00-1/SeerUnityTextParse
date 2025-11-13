// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// ConfigBase<T>
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using common;
using core.config;
//using core.manager;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;
//using res;

public abstract class ConfigBase<T> : ResetableSingleTon<T>, IConfigRoot where T : IResetable, new()
{

	protected bool m_IsLoaded;

	public abstract string fileName { get; }

	public bool IsLoaded => m_IsLoaded;

    public bool isNeedUpdate()
    {
        throw new NotImplementedException();
    }

    public abstract void Parse(byte[] bytes);

}
