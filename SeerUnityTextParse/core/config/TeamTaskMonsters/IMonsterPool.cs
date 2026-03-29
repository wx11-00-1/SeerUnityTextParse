using System;

namespace core.config.TeamTaskMonsters
{
	// Token: 0x02002489 RID: 9353
	public class IMonsterPool
	{
		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06012170 RID: 74096 RVA: 0x004B1FF2 File Offset: 0x004B01F2
		// (set) Token: 0x06012171 RID: 74097 RVA: 0x004B1FFA File Offset: 0x004B01FA
		public ITypeItem[] Type { get; set; }

		// Token: 0x06012172 RID: 74098 RVA: 0x004B2004 File Offset: 0x004B0204
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Type = new ITypeItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Type[i] = new ITypeItem();
					this.Type[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
