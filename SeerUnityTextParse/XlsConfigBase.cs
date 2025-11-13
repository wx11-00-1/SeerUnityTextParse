using System;
using System.Collections.Generic;
using common;
using core.config;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200004D RID: 77
public abstract class XlsConfigBase<T, ItemT> : ConfigBase<T> where T : IResetable, new() where ItemT : IConfigItem
{
    // Token: 0x06000280 RID: 640 RVA: 0x0000CE54 File Offset: 0x0000B054
    public ItemT[] getItems()
    {
        return this.data;
    }

    // Token: 0x06000283 RID: 643 RVA: 0x0000CEEC File Offset: 0x0000B0EC
    public ItemT getItem(int id)
    {
        if (this.m_ItemsDic == null)
        {
            this.m_ItemsDic = new Dictionary<int, int>(this.data.Length);
            for (int i = 0; i < this.data.Length; i++)
            {
                this.m_ItemsDic.TryAdd(this.data[i].id, i);
            }
        }
        int num;
        if (this.m_ItemsDic.TryGetValue(id, out num))
        {
            return this.data[num];
        }
        return default(ItemT);
    }

    // Token: 0x040002B2 RID: 690
    protected ItemT[] data;

    // Token: 0x040002B3 RID: 691
    private Dictionary<int, int> m_ItemsDic;
}
