using System;

namespace core.config
{
	// Token: 0x02001C94 RID: 7316
	public class IAdAstraConditionInfo : IConfigItem
	{
		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x003C9AB0 File Offset: 0x003C7CB0
		// (set) Token: 0x0600D3B5 RID: 54197 RVA: 0x003C9AB8 File Offset: 0x003C7CB8
		public string btldesc { get; set; }

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600D3B6 RID: 54198 RVA: 0x003C9AC1 File Offset: 0x003C7CC1
		// (set) Token: 0x0600D3B7 RID: 54199 RVA: 0x003C9AC9 File Offset: 0x003C7CC9
		public int id { get; set; }

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x003C9AD2 File Offset: 0x003C7CD2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.btldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
