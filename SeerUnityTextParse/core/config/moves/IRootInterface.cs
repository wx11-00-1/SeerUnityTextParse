using System;

namespace core.config.moves
{
	// Token: 0x02001FA8 RID: 8104
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600F3A8 RID: 62376 RVA: 0x003F8BAA File Offset: 0x003F6DAA
		public override string fileName
		{
			get
			{
				return "moves";
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600F3A9 RID: 62377 RVA: 0x003F8BB1 File Offset: 0x003F6DB1
		// (set) Token: 0x0600F3AA RID: 62378 RVA: 0x003F8BB9 File Offset: 0x003F6DB9
		public IMovesTbl MovesTbl { get; set; }

		// Token: 0x0600F3AB RID: 62379 RVA: 0x003F8BC2 File Offset: 0x003F6DC2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.MovesTbl = new IMovesTbl();
				this.MovesTbl.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x003F8BE8 File Offset: 0x003F6DE8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
