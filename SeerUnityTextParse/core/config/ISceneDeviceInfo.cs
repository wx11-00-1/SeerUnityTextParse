using System;

namespace core.config
{
	// Token: 0x02001E08 RID: 7688
	public class ISceneDeviceInfo : IConfigItem
	{
		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600E31A RID: 58138 RVA: 0x003DCAB8 File Offset: 0x003DACB8
		// (set) Token: 0x0600E31B RID: 58139 RVA: 0x003DCAC0 File Offset: 0x003DACC0
		public string FuncDes { get; set; }

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600E31C RID: 58140 RVA: 0x003DCAC9 File Offset: 0x003DACC9
		// (set) Token: 0x0600E31D RID: 58141 RVA: 0x003DCAD1 File Offset: 0x003DACD1
		public string pic { get; set; }

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600E31E RID: 58142 RVA: 0x003DCADA File Offset: 0x003DACDA
		// (set) Token: 0x0600E31F RID: 58143 RVA: 0x003DCAE2 File Offset: 0x003DACE2
		public string[] time { get; set; }

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600E320 RID: 58144 RVA: 0x003DCAEB File Offset: 0x003DACEB
		// (set) Token: 0x0600E321 RID: 58145 RVA: 0x003DCAF3 File Offset: 0x003DACF3
		public int FuncType { get; set; }

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600E322 RID: 58146 RVA: 0x003DCAFC File Offset: 0x003DACFC
		// (set) Token: 0x0600E323 RID: 58147 RVA: 0x003DCB04 File Offset: 0x003DAD04
		public int id { get; set; }

		// Token: 0x0600E324 RID: 58148 RVA: 0x003DCB10 File Offset: 0x003DAD10
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.FuncDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.FuncType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.time = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.time[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
