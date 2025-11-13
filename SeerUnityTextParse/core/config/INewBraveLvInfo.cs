using System;

namespace core.config
{
	// Token: 0x02001DA2 RID: 7586
	public class INewBraveLvInfo : IConfigItem
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x0600DEAA RID: 57002 RVA: 0x003D71DC File Offset: 0x003D53DC
		// (set) Token: 0x0600DEAB RID: 57003 RVA: 0x003D71E4 File Offset: 0x003D53E4
		public string[] stepname { get; set; }

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600DEAC RID: 57004 RVA: 0x003D71ED File Offset: 0x003D53ED
		// (set) Token: 0x0600DEAD RID: 57005 RVA: 0x003D71F5 File Offset: 0x003D53F5
		public string storehouse { get; set; }

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x003D71FE File Offset: 0x003D53FE
		// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x003D7206 File Offset: 0x003D5406
		public int id { get; set; }

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600DEB0 RID: 57008 RVA: 0x003D720F File Offset: 0x003D540F
		// (set) Token: 0x0600DEB1 RID: 57009 RVA: 0x003D7217 File Offset: 0x003D5417
		public int stepnum { get; set; }

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x003D7220 File Offset: 0x003D5420
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.stepname = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.stepname[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.stepnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.storehouse = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
