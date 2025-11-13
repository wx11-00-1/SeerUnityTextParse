using System;

namespace core.config.moves
{
	// Token: 0x02001FA7 RID: 8103
	public class IMovesTbl
	{
		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600F3A4 RID: 62372 RVA: 0x003F8B6E File Offset: 0x003F6D6E
		// (set) Token: 0x0600F3A5 RID: 62373 RVA: 0x003F8B76 File Offset: 0x003F6D76
		public IMoves Moves { get; set; }

		// Token: 0x0600F3A6 RID: 62374 RVA: 0x003F8B7F File Offset: 0x003F6D7F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Moves = new IMoves();
				this.Moves.Parse(bytes, ref byteIndex);
			}
		}
	}
}
