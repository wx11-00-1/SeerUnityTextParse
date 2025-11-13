using System;

namespace core.config
{
	// Token: 0x02001CD2 RID: 7378
	public class IBraveTowerReverseDefenseMonsterInfo : IConfigItem
	{
		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x0600D636 RID: 54838 RVA: 0x003CC9EC File Offset: 0x003CABEC
		// (set) Token: 0x0600D637 RID: 54839 RVA: 0x003CC9F4 File Offset: 0x003CABF4
		public string name { get; set; }

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x0600D638 RID: 54840 RVA: 0x003CC9FD File Offset: 0x003CABFD
		// (set) Token: 0x0600D639 RID: 54841 RVA: 0x003CCA05 File Offset: 0x003CAC05
		public int battlevalue { get; set; }

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x0600D63A RID: 54842 RVA: 0x003CCA0E File Offset: 0x003CAC0E
		// (set) Token: 0x0600D63B RID: 54843 RVA: 0x003CCA16 File Offset: 0x003CAC16
		public int id { get; set; }

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600D63C RID: 54844 RVA: 0x003CCA1F File Offset: 0x003CAC1F
		// (set) Token: 0x0600D63D RID: 54845 RVA: 0x003CCA27 File Offset: 0x003CAC27
		public int monsterid { get; set; }

		// Token: 0x0600D63E RID: 54846 RVA: 0x003CCA30 File Offset: 0x003CAC30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battlevalue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
