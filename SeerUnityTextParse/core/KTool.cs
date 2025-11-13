using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using common;
using core;
using core.config;
//using core.manager;
using core.model;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;
//using DG.Tweening;
//using DG.Tweening.Core;
//using socket;
//using UnityEngine;

public class KTool
{
	public static int getBit(int value, int bit)
{
    return (value >> bit - 1) & 1;
}

public static int getByte(int value, int bit)
{
    if (bit > 0)
    {
        return (value >> 8 * bit) & 0xFF;
    }
    return value & 0xFF;
}

public static int readBits(int value, int start, int end)
{
    int num = end - start + 1;
    int num2 = (1 << num) - 1;
    return (value >> start - 1) & num2;
}

public static T clone<T>(T obj)
{
    if (obj is string || obj.GetType().IsValueType)
    {
        return obj;
    }
        //return JsonUtility.FromJson<T>(JsonUtility.ToJson((object)obj));
        return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj));
}

public static void getPlayerInfo(int[] infoArr, Action<int[]> listener = null)
{
    getInfoByCommomd(CommandID.GAME_GET_PLAYER_INFO, infoArr, listener);
}

public static void getMultiValue(int[] foreverArr, Action<int[]> listener = null)
{
    getInfoByCommomd(CommandID.GET_MULTI_FOREVER, foreverArr, listener);
}

public static void getMultiValueByDB(int[] foreverArr, Action<int[]> listener = null)
{
    getInfoByCommomd(CommandID.GET_MULTI_FOREVER_BY_DB, foreverArr, listener);
}

private static void getInfoByCommomd(int commondId, int[] foreverArr, Action<int[]> listener = null)
{
    //if (foreverArr == null || foreverArr.Length == 0)
    //{
    //    listener?.Invoke(new int[0]);
    //    return;
    //}
    //ByteArray byteArray = ByteArrayPool.GetByteArray();
    //byteArray.WriteUnsignedInt((uint)foreverArr.Length);
    //foreach (int value in foreverArr)
    //{
    //    byteArray.WriteSignedInt(value);
    //}
    //SocketConnection.sendByQueue(commondId, byteArray, delegate (SocketEvent e)
    //{
    //    ByteArray data = e.Data;
    //    data.position = 0;
    //    int num = data.ReadSignedInt();
    //    int[] array = new int[num];
    //    for (int j = 0; j < num; j++)
    //    {
    //        array[j] = data.ReadSignedInt();
    //    }
    //    listener?.Invoke(array);
    //});
}

public static void getBitSet(int[] paramArr, Action<int[]> listener = null)
{
    //if (paramArr == null || paramArr.Length == 0)
    //{
    //    listener?.Invoke(new int[0]);
    //    return;
    //}
    //ByteArray byteArray = ByteArrayPool.GetByteArray();
    //byteArray.WriteSignedInt(paramArr.Length);
    //for (int i = 0; i < paramArr.Length; i++)
    //{
    //    byteArray.WriteSignedInt(paramArr[i]);
    //}
    //SocketConnection.sendByQueue(CommandID.BATCH_GET_BITSET, byteArray, delegate (SocketEvent e)
    //{
    //    ByteArray data = e.Data;
    //    data.position = 0;
    //    uint num = data.ReadUnsignedInt();
    //    int[] array = new int[num];
    //    for (int j = 0; j < num; j++)
    //    {
    //        array[j] = data.ReadUnsignedByte();
    //    }
    //    listener?.Invoke(array);
    //});
}

//[AsyncStateMachine(typeof(< getBitSetAsync > d__9))]
//public static UniTask<int[]> getBitSetAsync(int[] paramArr)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getBitSetAsync > d__9 < getBitSetAsync > d__ = default(< getBitSetAsync > d__9);

//        < getBitSetAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < getBitSetAsync > d__.paramArr = paramArr;

//        < getBitSetAsync > d__.<> 1__state = -1;

//        < getBitSetAsync > d__.<> t__builder.Start << getBitSetAsync > d__9 > (ref < getBitSetAsync > d__);
//    return < getBitSetAsync > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getFloatAsync > d__10))]
//public static UniTask<float[]> getFloatAsync(int[] floatArr)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getFloatAsync > d__10 < getFloatAsync > d__ = default(< getFloatAsync > d__10);

//        < getFloatAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<float[]>.Create();

//        < getFloatAsync > d__.floatArr = floatArr;

//        < getFloatAsync > d__.<> 1__state = -1;

//        < getFloatAsync > d__.<> t__builder.Start << getFloatAsync > d__10 > (ref < getFloatAsync > d__);
//    return < getFloatAsync > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getMultiValueAsync > d__11))]
//public static UniTask<int[]> getMultiValueAsync(int[] foreverArr)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getMultiValueAsync > d__11 < getMultiValueAsync > d__ = default(< getMultiValueAsync > d__11);

//        < getMultiValueAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < getMultiValueAsync > d__.foreverArr = foreverArr;

//        < getMultiValueAsync > d__.<> 1__state = -1;

//        < getMultiValueAsync > d__.<> t__builder.Start << getMultiValueAsync > d__11 > (ref < getMultiValueAsync > d__);
//    return < getMultiValueAsync > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getMultiValueByDBAsync > d__12))]
//public static UniTask<int[]> getMultiValueByDBAsync(int[] foreverArr)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getMultiValueByDBAsync > d__12 < getMultiValueByDBAsync > d__ = default(< getMultiValueByDBAsync > d__12);

//        < getMultiValueByDBAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < getMultiValueByDBAsync > d__.foreverArr = foreverArr;

//        < getMultiValueByDBAsync > d__.<> 1__state = -1;

//        < getMultiValueByDBAsync > d__.<> t__builder.Start << getMultiValueByDBAsync > d__12 > (ref < getMultiValueByDBAsync > d__);
//    return < getMultiValueByDBAsync > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getPlayerInfoValueAsync > d__13))]
//public static UniTask<int[]> getPlayerInfoValueAsync(int[] playerInfoArry)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getPlayerInfoValueAsync > d__13 < getPlayerInfoValueAsync > d__ = default(< getPlayerInfoValueAsync > d__13);

//        < getPlayerInfoValueAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < getPlayerInfoValueAsync > d__.playerInfoArry = playerInfoArry;

//        < getPlayerInfoValueAsync > d__.<> 1__state = -1;

//        < getPlayerInfoValueAsync > d__.<> t__builder.Start << getPlayerInfoValueAsync > d__13 > (ref < getPlayerInfoValueAsync > d__);
//    return < getPlayerInfoValueAsync > d__.<> t__builder.Task;
//}

public static int subByte(int value, int start, int length)
{
    if (length + start > 32)
    {
        throw new Exception("超出 int 上限！");
    }
    if (length > 16)
    {
        int num = subByte(value, start, 16);
        return num + (subByte(value - num, start + 16, length - 16) << 16);
    }
    return (65535 >> 16 - length) & (value >> start);
}

//public static void getHasEverGotPet(int[] petArr, Action<bool[]> func)
//{
//    if (petArr == null || petArr.Length == 0)
//    {
//        return;
//    }
//    ByteArray byteArray = ByteArrayPool.GetByteArray();
//    byteArray.WriteSignedInt(petArr.Length);
//    foreach (int value in petArr)
//    {
//        byteArray.WriteSignedInt(value);
//    }
//    SocketConnection.sendByQueue(CommandID.HAS_EVER_GET_PET_OR_JINGYUAN, byteArray, delegate (SocketEvent e)
//    {
//        ByteArray data = e.Data;
//        if (e.IsSuccess && data != null)
//        {
//            uint num = data.ReadUnsignedInt();
//            bool[] array = new bool[num];
//            for (int j = 0; j < num; j++)
//            {
//                array[j] = data.ReadUnsignedInt() != 0;
//            }
//            func?.Invoke(array);
//        }
//    });
//}

//[AsyncStateMachine(typeof(< checkMultiPetsClassAsync > d__16))]
//public static UniTask<int[]> checkMultiPetsClassAsync(int[] ids)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < checkMultiPetsClassAsync > d__16 < checkMultiPetsClassAsync > d__ = default(< checkMultiPetsClassAsync > d__16);

//        < checkMultiPetsClassAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < checkMultiPetsClassAsync > d__.ids = ids;

//        < checkMultiPetsClassAsync > d__.<> 1__state = -1;

//        < checkMultiPetsClassAsync > d__.<> t__builder.Start << checkMultiPetsClassAsync > d__16 > (ref < checkMultiPetsClassAsync > d__);
//    return < checkMultiPetsClassAsync > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< checkMultiPetClass > d__17))]
//public static UniTask<byte[]> checkMultiPetClass(int[] pets)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < checkMultiPetClass > d__17 < checkMultiPetClass > d__ = default(< checkMultiPetClass > d__17);

//        < checkMultiPetClass > d__.<> t__builder = AsyncUniTaskMethodBuilder<byte[]>.Create();

//        < checkMultiPetClass > d__.pets = pets;

//        < checkMultiPetClass > d__.<> 1__state = -1;

//        < checkMultiPetClass > d__.<> t__builder.Start << checkMultiPetClass > d__17 > (ref < checkMultiPetClass > d__);
//    return < checkMultiPetClass > d__.<> t__builder.Task;
//}

public static byte[] intTo4Unsignedbyte(int num)
{
    byte[] array = new byte[4];
    ByteArray byteArray = ByteArrayPool.GetByteArray();
    byteArray.WriteUnsignedInt((uint)num);
    array[0] = byteArray.ReadUnsignedByte();
    array[1] = byteArray.ReadUnsignedByte();
    array[2] = byteArray.ReadUnsignedByte();
    array[3] = byteArray.ReadUnsignedByte();
    ByteArrayPool.release(byteArray);
    return array;
}

//public static void getOnlineUsersForeverOrDailyVal(int[] arg, Action<int> func)
//{
//    if (arg == null || arg.Length == 0)
//    {
//        return;
//    }
//    SocketConnection.sendByQueue(CommandID.USER_FOREVER_VALUE, arg, delegate (SocketEvent e)
//    {
//        ByteArray data = e.Data;
//        data.position = 0;
//        int obj = 0;
//        if (data != null)
//        {
//            obj = data.ReadSignedInt();
//        }
//        func?.Invoke(obj);
//    });
//}

//[AsyncStateMachine(typeof(< getOnlineUsersForeverOrDailyValAsync > d__20))]
//public static UniTask<int> getOnlineUsersForeverOrDailyValAsync(int[] arg)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getOnlineUsersForeverOrDailyValAsync > d__20 < getOnlineUsersForeverOrDailyValAsync > d__ = default(< getOnlineUsersForeverOrDailyValAsync > d__20);

//        < getOnlineUsersForeverOrDailyValAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int>.Create();

//        < getOnlineUsersForeverOrDailyValAsync > d__.arg = arg;

//        < getOnlineUsersForeverOrDailyValAsync > d__.<> 1__state = -1;

//        < getOnlineUsersForeverOrDailyValAsync > d__.<> t__builder.Start << getOnlineUsersForeverOrDailyValAsync > d__20 > (ref < getOnlineUsersForeverOrDailyValAsync > d__);
//    return < getOnlineUsersForeverOrDailyValAsync > d__.<> t__builder.Task;
//}

//public static void getForeverNum(int param, Action<int> func)
//{
//    if (param != 0)
//    {
//        SocketConnection.sendByQueue(41080, param, delegate (SocketEvent e)
//        {
//            ByteArray data = e.Data;
//            func?.Invoke(data.ReadSignedInt());
//        });
//    }
//}

//[AsyncStateMachine(typeof(< getForeverNumAsync > d__22))]
//public static UniTask<int> getForeverNumAsync(int param)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
//        < getForeverNumAsync > d__22 < getForeverNumAsync > d__ = default(< getForeverNumAsync > d__22);

//        < getForeverNumAsync > d__.<> t__builder = AsyncUniTaskMethodBuilder<int>.Create();

//        < getForeverNumAsync > d__.param = param;

//        < getForeverNumAsync > d__.<> 1__state = -1;

//        < getForeverNumAsync > d__.<> t__builder.Start << getForeverNumAsync > d__22 > (ref < getForeverNumAsync > d__);
//    return < getForeverNumAsync > d__.<> t__builder.Task;
//}

//public static void doExchange(int id, int count, Action callback = null, Action errorFun = null)
//{
//    new ExchangeHelper(id, count, callback, errorFun).doExchange();
//}

//[AsyncStateMachine(typeof(< getRankListLength > d__24))]
//public static UniTask<int> getRankListLength(int key, int subKey)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0039: Unknown result type (might be due to invalid IL or missing references)
//        < getRankListLength > d__24 < getRankListLength > d__ = default(< getRankListLength > d__24);

//        < getRankListLength > d__.<> t__builder = AsyncUniTaskMethodBuilder<int>.Create();

//        < getRankListLength > d__.key = key;

//        < getRankListLength > d__.subKey = subKey;

//        < getRankListLength > d__.<> 1__state = -1;

//        < getRankListLength > d__.<> t__builder.Start << getRankListLength > d__24 > (ref < getRankListLength > d__);
//    return < getRankListLength > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getRangeRankList > d__25))]
//public static UniTask<List<RankInfo>> getRangeRankList(int key, int subkey, int start, int end, Action<List<RankInfo>> func = null)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0052: Unknown result type (might be due to invalid IL or missing references)
//        < getRangeRankList > d__25 < getRangeRankList > d__ = default(< getRangeRankList > d__25);

//        < getRangeRankList > d__.<> t__builder = AsyncUniTaskMethodBuilder<List<RankInfo>>.Create();

//        < getRangeRankList > d__.key = key;

//        < getRangeRankList > d__.subkey = subkey;

//        < getRangeRankList > d__.start = start;

//        < getRangeRankList > d__.end = end;

//        < getRangeRankList > d__.func = func;

//        < getRangeRankList > d__.<> 1__state = -1;

//        < getRangeRankList > d__.<> t__builder.Start << getRangeRankList > d__25 > (ref < getRangeRankList > d__);
//    return < getRangeRankList > d__.<> t__builder.Task;
//}

//[AsyncStateMachine(typeof(< getRankInfos > d__26))]
//public static UniTask<List<RankInfo>> getRankInfos(int key, int subkey, List<int> idArr, Action<List<RankInfo>> func = null, int order = 1)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0052: Unknown result type (might be due to invalid IL or missing references)
//        < getRankInfos > d__26 < getRankInfos > d__ = default(< getRankInfos > d__26);

//        < getRankInfos > d__.<> t__builder = AsyncUniTaskMethodBuilder<List<RankInfo>>.Create();

//        < getRankInfos > d__.key = key;

//        < getRankInfos > d__.subkey = subkey;

//        < getRankInfos > d__.idArr = idArr;

//        < getRankInfos > d__.func = func;

//        < getRankInfos > d__.order = order;

//        < getRankInfos > d__.<> 1__state = -1;

//        < getRankInfos > d__.<> t__builder.Start << getRankInfos > d__26 > (ref < getRankInfos > d__);
//    return < getRankInfos > d__.<> t__builder.Task;
//}

//public static void getMyRankAndScore(int key, int subkey, bool ascend, Action<(int, int)> func = null)
//{
//    if (key >= 0)
//    {
//        SocketConnection.sendByQueue(CommandID.PETWAR_GET_USER_RANK, new int[3]
//        {
//                key,
//                subkey,
//                ascend ? 1 : 0
//        }, delegate (SocketEvent e)
//        {
//            ByteArray data = e.Data;
//            func?.Invoke((data.ReadSignedInt(), data.ReadSignedInt()));
//        });
//    }
//}

//public static async void getMultiMemberRankAndScore(List<int> arg, int key, int subkey, bool ascend, Action<List<RankInfo>> func = null)
//{
//    if (arg.Count <= 0 || key < 0 || arg == null)
//    {
//        return;
//    }
//    ByteArray byteArray = ByteArrayPool.GetByteArray();
//    foreach (int item2 in arg)
//    {
//        byteArray.WriteSignedInt(item2);
//    }
//    SocketEvent socketEvent = await SocketConnection.sendAsync(46348, new ArrayList
//        {
//            key,
//            subkey,
//            ascend ? 1 : 0,
//            arg.Count,
//            byteArray
//        });
//    if (!socketEvent.IsSuccess)
//    {
//        func?.Invoke(new List<RankInfo>());
//        return;
//    }
//    ByteArray data = socketEvent.Data;
//    data.position = 0;
//    data.ReadUnsignedInt();
//    uint num = data.ReadUnsignedInt();
//    List<RankInfo> list = new List<RankInfo>();
//    for (int i = 0; i < num; i++)
//    {
//        RankInfo item = new RankInfo
//        {
//            rank = data.ReadSignedInt(),
//            score = data.ReadSignedInt()
//        };
//        list.Add(item);
//    }
//    func?.Invoke(list);
//}

//[AsyncStateMachine(typeof(< buyProductByCallback > d__29))]
//public static UniTask buyProductByCallback(int pid, int cnt = 1, Action fun = null, bool checkItem = true, int hashCodeKey = 0, bool skipAlert = false)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_005b: Unknown result type (might be due to invalid IL or missing references)
//        < buyProductByCallback > d__29 < buyProductByCallback > d__ = default(< buyProductByCallback > d__29);

//        < buyProductByCallback > d__.<> t__builder = AsyncUniTaskMethodBuilder.Create();

//        < buyProductByCallback > d__.pid = pid;

//        < buyProductByCallback > d__.cnt = cnt;

//        < buyProductByCallback > d__.fun = fun;

//        < buyProductByCallback > d__.checkItem = checkItem;

//        < buyProductByCallback > d__.hashCodeKey = hashCodeKey;

//        < buyProductByCallback > d__.skipAlert = skipAlert;

//        < buyProductByCallback > d__.<> 1__state = -1;
//    ((AsyncUniTaskMethodBuilder)(ref < buyProductByCallback > d__.<> t__builder)).Start << buyProductByCallback > d__29 > (ref < buyProductByCallback > d__);
//    return ((AsyncUniTaskMethodBuilder)(ref < buyProductByCallback > d__.<> t__builder)).Task;
//}

//public static void getIsHavingPet(int[] petArr, Action<int[]> func)
//{
//    if (petArr == null || petArr.Length == 0)
//    {
//        func?.Invoke(null);
//        return;
//    }
//    ByteArray byteArray = ByteArrayPool.GetByteArray();
//    byteArray.WriteSignedInt(petArr.Length);
//    foreach (int value in petArr)
//    {
//        byteArray.WriteUnsignedInt((uint)value);
//    }
//    SocketConnection.sendByQueue(CommandID.CHECK_IS_HAVING_PETS, byteArray, delegate (SocketEvent e)
//    {
//        ByteArray data = e.Data;
//        data.position = 0;
//        uint num = data.ReadUnsignedInt();
//        int[] array = new int[num];
//        for (int j = 0; j < num; j++)
//        {
//            array[j] = data.ReadSignedInt();
//        }
//        func?.Invoke(array);
//    });
//}

//[AsyncStateMachine(typeof(< getGlobalValues > d__31))]
//public static UniTask<int[]> getGlobalValues(int key, int[] arrSubKey, Action<int[]> callback = null)
//{
//        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
//        //IL_0041: Unknown result type (might be due to invalid IL or missing references)
//        < getGlobalValues > d__31 < getGlobalValues > d__ = default(< getGlobalValues > d__31);

//        < getGlobalValues > d__.<> t__builder = AsyncUniTaskMethodBuilder<int[]>.Create();

//        < getGlobalValues > d__.key = key;

//        < getGlobalValues > d__.arrSubKey = arrSubKey;

//        < getGlobalValues > d__.callback = callback;

//        < getGlobalValues > d__.<> 1__state = -1;

//        < getGlobalValues > d__.<> t__builder.Start << getGlobalValues > d__31 > (ref < getGlobalValues > d__);
//    return < getGlobalValues > d__.<> t__builder.Task;
//}

//public static Vector2 transformMapPoint(Vector2 value)
//{
//    //IL_0065: Unknown result type (might be due to invalid IL or missing references)
//    //IL_006a: Unknown result type (might be due to invalid IL or missing references)
//    //IL_006b: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0047: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0061: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0062: Unknown result type (might be due to invalid IL or missing references)
//    if ((Object)(object)LevelManager.root != (Object)null && (RoomManager.curRoomModel != null || ResetableSingleTon<MapManager>.Ins.curMapModel != null))
//    {
//        Vector2 result = default(Vector2);
//        RectTransformUtility.ScreenPointToLocalPointInRectangle((RoomManager.curRoomModel != null) ? RoomManager.curRoomModel.mainLevel : ((Component)ResetableSingleTon<MapManager>.Ins.curMapModel.walkLevel).GetComponent<RectTransform>(), value, (Camera)null, ref result);
//        result.y *= -1f;
//        return result;
//    }
//    return Vector2.zero;
//}

//public static Vector2 transformAstarPointToMapPonit(Vector2 value)
//{
//    //IL_0036: Unknown result type (might be due to invalid IL or missing references)
//    //IL_003b: Unknown result type (might be due to invalid IL or missing references)
//    //IL_003c: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0022: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0028: Unknown result type (might be due to invalid IL or missing references)
//    Vector2 zero = default(Vector2);
//    if ((Object)(object)LevelManager.root != (Object)null && (ResetableSingleTon<MapManager>.Ins.curMapModel != null || RoomManager.curRoomModel != null))
//    {
//        ((Vector2)(ref zero))..ctor(value.x, 0f - value.y);
//        return zero;
//    }
//    zero = Vector2.zero;
//    return zero;
//}

//public static Color TranslateColor(string colorStr)
//{
//    //IL_0029: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0008: Unknown result type (might be due to invalid IL or missing references)
//    if (string.IsNullOrEmpty(colorStr))
//    {
//        return Color.white;
//    }
//    colorStr = colorStr.Replace("0x", "#");
//    Color result = default(Color);
//    ColorUtility.TryParseHtmlString(colorStr, ref result);
//    return result;
//}

//public static void playRollAni(int allNum, int result, Action<int> onChange, Action onEnd, float duration = 3f, int numRound = 4, float waitTime = 0.5f, List<int> exceptArr = null)
//{
//    List<int> list = new List<int>();
//    for (int i = 1; i <= allNum; i++)
//    {
//        list.Add(i);
//    }
//    playRollAni(list, result, onChange, onEnd, duration, numRound, waitTime, exceptArr);
//}

//public static void playRollAni(List<int> dataArr, int result, Action<int> onChange, Action onEnd, float duration = 3f, int numRound = 4, float waitTime = 0.5f, List<int> exceptArr = null)
//{
//    //IL_00ce: Unknown result type (might be due to invalid IL or missing references)
//    //IL_00d8: Expected O, but got Unknown
//    LevelManager.lockStage();
//    if (exceptArr == null)
//    {
//        exceptArr = new List<int>();
//    }
//    int num = numRound * dataArr.Count + dataArr.IndexOf(result);
//    if (exceptArr != null)
//    {
//        duration *= Mathf.Clamp((float)(dataArr.Count - exceptArr.Count) / (float)dataArr.Count * 2f, 0.25f, 1f);
//    }
//    TweenSettingsExtensions.OnComplete<Tweener>(TweenSettingsExtensions.SetEase<Tweener>(DOTween.To((DOSetter<float>)delegate (float value)
//    {
//        int index = (int)value % dataArr.Count;
//        int item = dataArr[index];
//        if (exceptArr.IndexOf(item) < 0)
//        {
//            onChange?.Invoke(dataArr[index]);
//        }
//    }, 0f, (float)num, duration), (Ease)7), (TweenCallback)async delegate
//    {
//        await UniTask.Delay(TimeSpan.FromSeconds(waitTime), false, (PlayerLoopTiming)8, default(CancellationToken));
//        onEnd?.Invoke();
//        LevelManager.unlockStage();
//    });
//}

//public static Vector2 worldPointToAstarPoint(Vector3 worldPoint)
//{
//    //IL_0000: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0020: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0043: Unknown result type (might be due to invalid IL or missing references)
//    float num = worldPoint.x * (float)ResetableSingleTon<MapManager>.Ins.PixelsPerUnit + (float)(ResetableSingleTon<MapManager>.Ins.MapWidth / 2);
//    float num2 = 0f - (worldPoint.y * (float)ResetableSingleTon<MapManager>.Ins.PixelsPerUnit - (float)(ResetableSingleTon<MapManager>.Ins.MapHeight / 2));
//    return new Vector2(num, num2);
//}

//public static Vector2 astarPointToWorldPonit(Vector2 value)
//{
//    //IL_0000: Unknown result type (might be due to invalid IL or missing references)
//    //IL_0006: Unknown result type (might be due to invalid IL or missing references)
//    //IL_000c: Unknown result type (might be due to invalid IL or missing references)
//    return astarPointToWorldPonit(value.x, value.y);
//}

//public static Vector2 astarPointToWorldPonit(float px, float py)
//{
//    //IL_0039: Unknown result type (might be due to invalid IL or missing references)
//    float num = (px - (float)(ResetableSingleTon<MapManager>.Ins.MapWidth / 2)) / (float)ResetableSingleTon<MapManager>.Ins.PixelsPerUnit;
//    float num2 = (0f - py + (float)(ResetableSingleTon<MapManager>.Ins.MapHeight / 2)) / (float)ResetableSingleTon<MapManager>.Ins.PixelsPerUnit;
//    return new Vector2(num, num2);
//}

//public static Vector2 getRandomPoint()
//{
//    //IL_0036: Unknown result type (might be due to invalid IL or missing references)
//    return new Vector2((float)ResetableSingleTon<MapManager>.Ins.MapWidth * Random.Range(0f, 1f), (float)ResetableSingleTon<MapManager>.Ins.MapHeight * Random.Range(0f, 1f));
//}

public static void randomSort<T>(T[] arr)
{
    int num = arr.Length;
    Random random = new Random();
    while (num > 1)
    {
        num--;
        int num2 = random.Next(num + 1);
        T val = arr[num2];
        arr[num2] = arr[num];
        arr[num] = val;
    }
}
}
