using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using common;
using core.model;
//using core.view;

//using socket;



namespace core.manager
{
	// Token: 0x0200180D RID: 6157
	public class MainManager : ResetableSingleTon<MainManager>
	{
		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600C09C RID: 49308 RVA: 0x003838E5 File Offset: 0x00381AE5
		// (set) Token: 0x0600C09D RID: 49309 RVA: 0x003838ED File Offset: 0x00381AED
		public bool isOnArena
		{
			get
			{
				return this._isOnArena;
			}
			set
			{
				this._isOnArena = value;
				//PetFightModel.mode = (value ? FightModel.SINGLE_MODE : FightModel.MULTI_MODE);
			}
		}

		// Token: 0x0600C09E RID: 49310 RVA: 0x00383904 File Offset: 0x00381B04
		//public UniTask updateArean()
		//{
		//	MainManager.<updateArean>d__18 <updateArean>d__;
		//	<updateArean>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		//	<updateArean>d__.<>1__state = -1;
		//	<updateArean>d__.<>t__builder.Start<MainManager.<updateArean>d__18>(ref <updateArean>d__);
		//	return <updateArean>d__.<>t__builder.Task;
		//}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600C09F RID: 49311 RVA: 0x0038393F File Offset: 0x00381B3F
		// (set) Token: 0x0600C0A0 RID: 49312 RVA: 0x00383947 File Offset: 0x00381B47
		public int actorState
		{
			get
			{
				return this.s_actorState;
			}
			set
			{
				this.s_actorPrevState = this.s_actorState;
				this.s_actorState = value;
			}
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x0038395C File Offset: 0x00381B5C
		public override void Reset()
		{
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x0038395E File Offset: 0x00381B5E
		// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x00383966 File Offset: 0x00381B66
		public int actorPrevState
		{
			get
			{
				return this.s_actorPrevState;
			}
			set
			{
				this.s_actorPrevState = value;
			}
		}


		// Token: 0x0600C0A5 RID: 49317 RVA: 0x00383996 File Offset: 0x00381B96
		//public void setup(ByteArray data)
		//{
		//	this.s_actorInfo = new UserInfo();
		//	UserInfo.setForLoginInfo(this.s_actorInfo, data);
		//	SocketConnection.mainSocket.userID = (uint)this.s_actorInfo.userID;
		//	SystemTimerManager.queryTime();
		//	ServerCloseNoticeController.getInstance().setup();
		//}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x003839D4 File Offset: 0x00381BD4
		//public UniTask loadSeer()
		//{
		//	MainManager.<loadSeer>d__35 <loadSeer>d__;
		//	<loadSeer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		//	<loadSeer>d__.<>4__this = this;
		//	<loadSeer>d__.<>1__state = -1;
		//	<loadSeer>d__.<>t__builder.Start<MainManager.<loadSeer>d__35>(ref <loadSeer>d__);
		//	return <loadSeer>d__.<>t__builder.Task;
		//}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x00383A17 File Offset: 0x00381C17
		//public void UpdateActorModelPos(Vector2 pos)
		//{
		//	if (this.actorModel != null)
		//	{
		//		this.actorModel.pos = pos;
		//	}
		//}

		//// Token: 0x0600C0A8 RID: 49320 RVA: 0x00383A2D File Offset: 0x00381C2D
		//public Vector2 GetActorModelPos()
		//{
		//	if (this.actorModel != null)
		//	{
		//		return this.actorModel.pos;
		//	}
		//	return Vector2.zero;
		//}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x00383A48 File Offset: 0x00381C48
		public ByteArray getTopLeftTmcid()
		{
			ByteArray byteArray = new ByteArray();
			if (this.tad != null && this.tad != "none" && this.tad != "")
			{
				if (this.tad.Length > 63)
				{
					this.tad = this.tad.Substring(0, 63);
				}
				byteArray.WriteUTFBytes(this.tad, 0);
			}
			else
			{
				byteArray.WriteUTFBytes("\0", 0);
			}
			byteArray.Length = 64;
			return byteArray;
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x00383AD0 File Offset: 0x00381CD0
		//public void upDateForPeoleInfo(UserInfo info)
		//{
		//	this.s_actorInfo.actionType = info.actionType;
		//	this.s_actorInfo.sysTime = info.sysTime;
		//	this.s_actorInfo.userID = info.userID;
		//	this.s_actorInfo.nick = info.nick;
		//	this.s_actorInfo.color = info.color;
		//	this.s_actorInfo.texture = info.texture;
		//	this.s_actorInfo.vip = info.vip;
		//	this.s_actorInfo.isExtremeNono = info.isExtremeNono;
		//	this.s_actorInfo.action = info.action;
		//	this.s_actorInfo.direction = info.direction;
		//	this.s_actorInfo.spiritID = info.spiritID;
		//	this.s_actorInfo.fightFlag = info.fightFlag;
		//	this.s_actorInfo.teacherID = info.teacherID;
		//	this.s_actorInfo.studentID = info.studentID;
		//	this.s_actorInfo.nonoState = info.nonoState.GetRange(0, info.nonoState.Count);
		//	if (this.s_actorInfo.nonoState.Count < 2)
		//	{
		//		Debug.LogError(string.Format("MainManager.upDateForPeoleInfo nonoState.Count error:{0}", this.s_actorInfo.nonoState.Count));
		//	}
		//	this.s_actorInfo.nonoColor = info.nonoColor;
		//	this.s_actorInfo.nonoNick = info.nonoNick;
		//	this.s_actorInfo.superNono = info.superNono;
		//	this.s_actorInfo.clothes = info.clothes.GetRange(0, info.clothes.Count);
		//	SystemTimerManager.setTime(info.sysTime);
		//}


		// Token: 0x0600C0AC RID: 49324 RVA: 0x00383CFA File Offset: 0x00381EFA
		public void testTakeOffCloth()
		{
		}

		// Token: 0x0600C0AD RID: 49325 RVA: 0x00383CFC File Offset: 0x00381EFC
		private void testAddMonster(int bossId)
		{
		}

		// Token: 0x0600C0AE RID: 49326 RVA: 0x00383D00 File Offset: 0x00381F00
		public void reloadGame()
		{
			//MainManager.<reloadGame>d__43 <reloadGame>d__;
			//<reloadGame>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<reloadGame>d__.<>4__this = this;
			//<reloadGame>d__.<>1__state = -1;
			//<reloadGame>d__.<>t__builder.Start<MainManager.<reloadGame>d__43>(ref <reloadGame>d__);
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x00383D38 File Offset: 0x00381F38
		//private void login(RectTransform rect)
		//{
		//	MainManager.<login>d__44 <login>d__;
		//	<login>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<login>d__.rect = rect;
		//	<login>d__.<>1__state = -1;
		//	<login>d__.<>t__builder.Start<MainManager.<login>d__44>(ref <login>d__);
		//}

		//// Token: 0x0600C0B0 RID: 49328 RVA: 0x00383D70 File Offset: 0x00381F70
		//private UniTask<RectTransform> initLoginGameObject()
		//{
		//	MainManager.<initLoginGameObject>d__45 <initLoginGameObject>d__;
		//	<initLoginGameObject>d__.<>t__builder = AsyncUniTaskMethodBuilder<RectTransform>.Create();
		//	<initLoginGameObject>d__.<>4__this = this;
		//	<initLoginGameObject>d__.<>1__state = -1;
		//	<initLoginGameObject>d__.<>t__builder.Start<MainManager.<initLoginGameObject>d__45>(ref <initLoginGameObject>d__);
		//	return <initLoginGameObject>d__.<>t__builder.Task;
		//}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x00383DB4 File Offset: 0x00381FB4
		//private UniTask<GameObject> loadPrefab(string path, Transform parent)
		//{
		//	MainManager.<loadPrefab>d__46 <loadPrefab>d__;
		//	<loadPrefab>d__.<>t__builder = AsyncUniTaskMethodBuilder<GameObject>.Create();
		//	<loadPrefab>d__.path = path;
		//	<loadPrefab>d__.parent = parent;
		//	<loadPrefab>d__.<>1__state = -1;
		//	<loadPrefab>d__.<>t__builder.Start<MainManager.<loadPrefab>d__46>(ref <loadPrefab>d__);
		//	return <loadPrefab>d__.<>t__builder.Task;
		//}

		// Token: 0x0400D941 RID: 55617
		private int s_hashCode = new object().GetHashCode();

		// Token: 0x0400D942 RID: 55618
		private int s_actorPrevState;

		// Token: 0x0400D943 RID: 55619
		private int s_actorState;

		// Token: 0x0400D944 RID: 55620
		public int actorID = 1;

		// Token: 0x0400D945 RID: 55621
		//private UserInfo s_actorInfo;

		// Token: 0x0400D946 RID: 55622
		public int GAMEW = 1136;

		// Token: 0x0400D947 RID: 55623
		public int GAMEH = 640;

		// Token: 0x0400D948 RID: 55624
		public string tad;

		// Token: 0x0400D949 RID: 55625
		public ByteArray session;

		// Token: 0x0400D94A RID: 55626
		public bool isClothHalfDay;

		// Token: 0x0400D94B RID: 55627
		public bool isRoomHalfDay;

		// Token: 0x0400D94C RID: 55628
		public bool iFortressHalfDay;

		// Token: 0x0400D94D RID: 55629
		public bool isHQHalfDay;

		// Token: 0x0400D94E RID: 55630
		private bool _isOnArena;

		// Token: 0x0400D94F RID: 55631
		public bool wasOnAreanFight;

		// Token: 0x0400D950 RID: 55632
		public double DefSpeed = 4.6;

		// Token: 0x0400D951 RID: 55633
		public int serverID;

		// Token: 0x0400D952 RID: 55634
		//public MyPeopleModel actorModel;

		// Token: 0x0400D953 RID: 55635
		public Action onReloadGame;

		// Token: 0x0400D954 RID: 55636
		public bool isEnterView;

		// Token: 0x0400D955 RID: 55637
		//public Dictionary<int, SkeletonDataAsset> seerDefalutBody;
	}
}
