using System;

namespace core.config
{
	// Token: 0x02001CF4 RID: 7412
	public class IChessGameBuffInfo : IConfigItem
	{
		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600D79E RID: 55198 RVA: 0x003CE640 File Offset: 0x003CC840
		// (set) Token: 0x0600D79F RID: 55199 RVA: 0x003CE648 File Offset: 0x003CC848
		public string adddesc { get; set; }

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x003CE651 File Offset: 0x003CC851
		// (set) Token: 0x0600D7A1 RID: 55201 RVA: 0x003CE659 File Offset: 0x003CC859
		public string buffeffect { get; set; }

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600D7A2 RID: 55202 RVA: 0x003CE662 File Offset: 0x003CC862
		// (set) Token: 0x0600D7A3 RID: 55203 RVA: 0x003CE66A File Offset: 0x003CC86A
		public string buffparam { get; set; }

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x003CE673 File Offset: 0x003CC873
		// (set) Token: 0x0600D7A5 RID: 55205 RVA: 0x003CE67B File Offset: 0x003CC87B
		public string desc { get; set; }

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x003CE684 File Offset: 0x003CC884
		// (set) Token: 0x0600D7A7 RID: 55207 RVA: 0x003CE68C File Offset: 0x003CC88C
		public string icon { get; set; }

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x0600D7A8 RID: 55208 RVA: 0x003CE695 File Offset: 0x003CC895
		// (set) Token: 0x0600D7A9 RID: 55209 RVA: 0x003CE69D File Offset: 0x003CC89D
		public string name { get; set; }

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600D7AA RID: 55210 RVA: 0x003CE6A6 File Offset: 0x003CC8A6
		// (set) Token: 0x0600D7AB RID: 55211 RVA: 0x003CE6AE File Offset: 0x003CC8AE
		public string reddesc { get; set; }

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x0600D7AC RID: 55212 RVA: 0x003CE6B7 File Offset: 0x003CC8B7
		// (set) Token: 0x0600D7AD RID: 55213 RVA: 0x003CE6BF File Offset: 0x003CC8BF
		public int addtype { get; set; }

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600D7AE RID: 55214 RVA: 0x003CE6C8 File Offset: 0x003CC8C8
		// (set) Token: 0x0600D7AF RID: 55215 RVA: 0x003CE6D0 File Offset: 0x003CC8D0
		public int bufftype { get; set; }

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600D7B0 RID: 55216 RVA: 0x003CE6D9 File Offset: 0x003CC8D9
		// (set) Token: 0x0600D7B1 RID: 55217 RVA: 0x003CE6E1 File Offset: 0x003CC8E1
		public int id { get; set; }

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600D7B2 RID: 55218 RVA: 0x003CE6EA File Offset: 0x003CC8EA
		// (set) Token: 0x0600D7B3 RID: 55219 RVA: 0x003CE6F2 File Offset: 0x003CC8F2
		public int isshow { get; set; }

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600D7B4 RID: 55220 RVA: 0x003CE6FB File Offset: 0x003CC8FB
		// (set) Token: 0x0600D7B5 RID: 55221 RVA: 0x003CE703 File Offset: 0x003CC903
		public int taketime { get; set; }

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x003CE70C File Offset: 0x003CC90C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.adddesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.addtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.buffeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.buffparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bufftype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reddesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taketime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
