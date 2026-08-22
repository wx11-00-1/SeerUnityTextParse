

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.SuitXMLInfo
using common;
using core.config;
using core.config.clothpos;
using core.config.suit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
//using UnityEngine;

public class SuitXMLInfo : ConfigManagerSingleton<SuitXMLInfo>
{

    private Dictionary<int, IItemItem> s_DataMap;

    private Dictionary<int, IItemItem> s_MapClothIdToSuitId = new Dictionary<int, IItemItem>(1931);

    public Dictionary<int, ClothposData> ClothposDic;

    protected void OnReset()
    {
        s_DataMap?.Clear();
        s_MapClothIdToSuitId.Clear();
        ClothposDic?.Clear();
    }


    public int getSuitID(List<int> clothIDs)
    {
        int num = 0;
        IItemItem value = null;
        for (int i = 0; i < clothIDs.Count; i++)
        {
            if (value == null)
            {
                if (!s_MapClothIdToSuitId.TryGetValue(clothIDs[i], out value))
                {
                    if (!ResetableSingleTon<ItemXMLInfo>.Ins.gettype(clothIDs[i]).Equals("bg"))
                    {
                        return 0;
                    }
                    num = 1;
                }
            }
            else if (!value.cloths.Contains(clothIDs[i]))
            {
                if (num != 0 || !ResetableSingleTon<ItemXMLInfo>.Ins.gettype(clothIDs[i]).Equals("bg"))
                {
                    return 0;
                }
                num = 1;
            }
        }
        if (value != null && clothIDs.Count == value.cloths.Length + num)
        {
            return value.id;
        }
        return 0;
    }

    public List<int> getSuitIDs(List<int> clothIDs)
    {
        if (clothIDs == null)
        {
            return null;
        }
        List<int> list = new List<int>();
        int num = 0;
        foreach (int clothID in clothIDs)
        {
            num = 0;
            if (!s_MapClothIdToSuitId.TryGetValue(clothID, out var value) || list.IndexOf(value.id) > -1 || value.cloths.Length == 0 || clothIDs.Count < value.cloths.Length)
            {
                continue;
            }
            int[] cloths = value.cloths;
            foreach (int item in cloths)
            {
                if (clothIDs.IndexOf(item) == -1)
                {
                    break;
                }
                num++;
            }
            if (num == value.cloths.Length)
            {
                list.Add(value.id);
            }
        }
        return list;
    }

    public bool getIsTransform(int id)
    {
        if (s_DataMap.TryGetValue(id, out var value))
        {
            return value.transform == 1;
        }
        return false;
    }

    public int[] getCloths(int id)
    {
        if (!s_DataMap.TryGetValue(id, out var value))
        {
            return null;
        }
        return value.cloths;
    }

    public float getSuitTranSpeed(int id)
    {
        if (!s_DataMap.TryGetValue(id, out var value))
        {
            return 4f;
        }
        return value.tranSpeed;
    }

    public string getName(int id)
    {
        if (!s_DataMap.TryGetValue(id, out var value))
        {
            return string.Empty;
        }
        return value.name;
    }

    public string getSuitNormalDesc(int id)
    {
        if (!s_DataMap.TryGetValue(id, out var value))
        {
            return string.Empty;
        }
        return value.suitdes;
    }

    public int getSuitIdByClothId(int clothId)
    {
        if (!s_MapClothIdToSuitId.TryGetValue(clothId, out var value))
        {
            return 0;
        }
        return value.id;
    }

    public List<int> getSuitIdByClothId(int[] arrClothId)
    {
        List<int> list = new List<int>();
        foreach (int key in arrClothId)
        {
            if (s_MapClothIdToSuitId.TryGetValue(key, out var value) && !list.Contains(value.id))
            {
                list.Add(value.id);
            }
        }
        return list;
    }

    public int[] getAllSuitIds()
    {
        return s_DataMap.Keys.ToArray();
    }
}