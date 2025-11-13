using System;


namespace core.model
{
	// Token: 0x02001916 RID: 6422
	public struct AimatInfo
	{
		// Token: 0x0600CA15 RID: 51733 RVA: 0x003AE818 File Offset: 0x003ACA18
		public void Decode(ByteArray byteArray)
		{
			this.userID = byteArray.ReadSignedInt();
			this.itemID = byteArray.ReadSignedInt();
			this.aimatID = byteArray.ReadSignedInt();
			this.posX = byteArray.ReadSignedInt();
			this.posY = byteArray.ReadSignedInt();
		}

		// Token: 0x0600CA16 RID: 51734 RVA: 0x003AE856 File Offset: 0x003ACA56
		public ByteArray Encode()
		{
			ByteArray byteArray = ByteArrayPool.GetByteArray(0);
			byteArray.WriteSignedInt(this.itemID);
			byteArray.WriteSignedInt(this.aimatID);
			byteArray.WriteSignedInt(this.posX);
			byteArray.WriteSignedInt(this.posY);
			return byteArray;
		}

		// Token: 0x0400DEB7 RID: 57015
		public int userID;

		// Token: 0x0400DEB8 RID: 57016
		public int itemID;

		// Token: 0x0400DEB9 RID: 57017
		public int aimatID;

		// Token: 0x0400DEBA RID: 57018
		//public Vector2 startPos;

		// Token: 0x0400DEBB RID: 57019
		public int posX;

		// Token: 0x0400DEBC RID: 57020
		public int posY;
	}
}
