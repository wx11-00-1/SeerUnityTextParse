using System;

namespace core.config.typesRelation
{
	// Token: 0x02001F05 RID: 7941
	public class IRelationItem
	{
		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600EDC6 RID: 60870 RVA: 0x003F19B1 File Offset: 0x003EFBB1
		// (set) Token: 0x0600EDC7 RID: 60871 RVA: 0x003F19B9 File Offset: 0x003EFBB9
		public IOpponentItem[] Opponent { get; set; }

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600EDC8 RID: 60872 RVA: 0x003F19C2 File Offset: 0x003EFBC2
		// (set) Token: 0x0600EDC9 RID: 60873 RVA: 0x003F19CA File Offset: 0x003EFBCA
		public string type { get; set; }

		// Token: 0x0600EDCA RID: 60874 RVA: 0x003F19D4 File Offset: 0x003EFBD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Opponent = new IOpponentItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Opponent[i] = new IOpponentItem();
					this.Opponent[i].Parse(bytes, ref byteIndex);
				}
			}
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
