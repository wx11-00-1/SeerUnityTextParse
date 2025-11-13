using System;

namespace core.config
{
	// Token: 0x02001CD6 RID: 7382
	public class IBraveTowerReverseDefenseTrainInfo : IConfigItem
	{
		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x0600D656 RID: 54870 RVA: 0x003CCC40 File Offset: 0x003CAE40
		// (set) Token: 0x0600D657 RID: 54871 RVA: 0x003CCC48 File Offset: 0x003CAE48
		public string des { get; set; }

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x0600D658 RID: 54872 RVA: 0x003CCC51 File Offset: 0x003CAE51
		// (set) Token: 0x0600D659 RID: 54873 RVA: 0x003CCC59 File Offset: 0x003CAE59
		public string name { get; set; }

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x0600D65A RID: 54874 RVA: 0x003CCC62 File Offset: 0x003CAE62
		// (set) Token: 0x0600D65B RID: 54875 RVA: 0x003CCC6A File Offset: 0x003CAE6A
		public int id { get; set; }

		// Token: 0x0600D65C RID: 54876 RVA: 0x003CCC73 File Offset: 0x003CAE73
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
