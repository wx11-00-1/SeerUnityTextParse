using System;

namespace core.config.typesRelation
{
	// Token: 0x02001F06 RID: 7942
	public class IRoot
	{
		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600EDCC RID: 60876 RVA: 0x003F1A42 File Offset: 0x003EFC42
		// (set) Token: 0x0600EDCD RID: 60877 RVA: 0x003F1A4A File Offset: 0x003EFC4A
		public IRelationItem[] Relation { get; set; }

		// Token: 0x0600EDCE RID: 60878 RVA: 0x003F1A54 File Offset: 0x003EFC54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Relation = new IRelationItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Relation[i] = new IRelationItem();
					this.Relation[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
