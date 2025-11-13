using System;

namespace core.config
{
	// Token: 0x02001DF8 RID: 7672
	public class IRetrieveInfo : IConfigItem
	{
		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x0600E280 RID: 57984 RVA: 0x003DBC00 File Offset: 0x003D9E00
		// (set) Token: 0x0600E281 RID: 57985 RVA: 0x003DBC08 File Offset: 0x003D9E08
		public string money { get; set; }

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x003DBC11 File Offset: 0x003D9E11
		// (set) Token: 0x0600E283 RID: 57987 RVA: 0x003DBC19 File Offset: 0x003D9E19
		public int[] num { get; set; }

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x0600E284 RID: 57988 RVA: 0x003DBC22 File Offset: 0x003D9E22
		// (set) Token: 0x0600E285 RID: 57989 RVA: 0x003DBC2A File Offset: 0x003D9E2A
		public int id { get; set; }

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600E286 RID: 57990 RVA: 0x003DBC33 File Offset: 0x003D9E33
		// (set) Token: 0x0600E287 RID: 57991 RVA: 0x003DBC3B File Offset: 0x003D9E3B
		public int ratio { get; set; }

		// Token: 0x0600E288 RID: 57992 RVA: 0x003DBC44 File Offset: 0x003D9E44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.money = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.num = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.num[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.ratio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
