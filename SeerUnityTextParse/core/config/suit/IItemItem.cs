using System;

namespace core.config.suit
{
	// Token: 0x02001F12 RID: 7954
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x0600EE2E RID: 60974 RVA: 0x003F21C8 File Offset: 0x003F03C8
		// (set) Token: 0x0600EE2F RID: 60975 RVA: 0x003F21D0 File Offset: 0x003F03D0
		public string name { get; set; }

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x0600EE30 RID: 60976 RVA: 0x003F21D9 File Offset: 0x003F03D9
		// (set) Token: 0x0600EE31 RID: 60977 RVA: 0x003F21E1 File Offset: 0x003F03E1
		public string suitdes { get; set; }

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x0600EE32 RID: 60978 RVA: 0x003F21EA File Offset: 0x003F03EA
		// (set) Token: 0x0600EE33 RID: 60979 RVA: 0x003F21F2 File Offset: 0x003F03F2
		public int[] cloths { get; set; }

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x0600EE34 RID: 60980 RVA: 0x003F21FB File Offset: 0x003F03FB
		// (set) Token: 0x0600EE35 RID: 60981 RVA: 0x003F2203 File Offset: 0x003F0403
		public int id { get; set; }

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x003F220C File Offset: 0x003F040C
		// (set) Token: 0x0600EE37 RID: 60983 RVA: 0x003F2214 File Offset: 0x003F0414
		public int transform { get; set; }

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x0600EE38 RID: 60984 RVA: 0x003F221D File Offset: 0x003F041D
		// (set) Token: 0x0600EE39 RID: 60985 RVA: 0x003F2225 File Offset: 0x003F0425
		public float tranSpeed { get; set; }

		// Token: 0x0600EE3A RID: 60986 RVA: 0x003F2230 File Offset: 0x003F0430
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.cloths = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.cloths[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.suitdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tranSpeed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
