using System;
//using core.manager;

namespace common
{
    // Token: 0x02002105 RID: 8453
    public class ResetableSingleTon<T> : IResetable where T : IResetable, new()
    {
        // Token: 0x1700218D RID: 8589
        // (get) Token: 0x060101FA RID: 66042 RVA: 0x0041445A File Offset: 0x0041265A
        public static T Ins
        {
            get
            {
                if (ResetableSingleTon<T>.s_Instance == null)
                {
                    ResetableSingleTon<T>.s_Instance = Activator.CreateInstance<T>();
                    //SingletonBase<GameResetableManager>.Ins.addSingleton(ResetableSingleTon<T>.s_Instance);
                }
                return ResetableSingleTon<T>.s_Instance;
            }
        }

        // Token: 0x060101FB RID: 66043 RVA: 0x0041448B File Offset: 0x0041268B
        public virtual void Reset()
        {
            ResetableSingleTon<T>.s_Instance = default(T);
        }

        // Token: 0x0400F976 RID: 63862
        protected static T s_Instance;
    }
}
