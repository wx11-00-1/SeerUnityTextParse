using System;
using System.Collections.Generic;
//using core.view;
//using module.achieve;
//using module.achieveNotice;
//using module.activityCenter;
//using module.activityListPreview;
//using module.adAstra;
//using module.adAstraActivity;
//using module.advancedPetBackStore;
//using module.angerDilke;
//using module.anHunSuoBiLaTe;
//using module.anniversary15thMarkSell;
//using module.anniversaryVault;
//using module.aoliaFeatureUpgrade;
//using module.aresAlliance;
//using module.artemisComplete;
//using module.artemisSkin;
//using module.autoFight;
//using module.awakeActivity;
//using module.awakeMain;
//using module.backflow;
//using module.badboyswork;
//using module.bagStorageSwitchChoosePanel;
//using module.battleFirePanel;
//using module.battleResultPanel;
//using module.battleTestFight;
//using module.bilibili;
//using module.blackEvo;
//using module.blakeSpecialTraining;
//using module.blessOfDivineAnimals;
//using module.BlueMoon;
//using module.braveTowerReverseDefense;
//using module.bruteSorensen;
//using module.canglan;
//using module.canglanCompleteActivityCenter;
//using module.cangyueShadowLegendSkinSale;
//using module.cassiusSpecialTraining;
//using module.cassiusSuperEvo;
//using module.castleSeriesSkinSales;
//using module.castleSeriesSkinSalesPop;
//using module.cdkey;
//using module.chaoticBlake;
//using module.chessGameActivity;
//using module.chessGameArena;
//using module.choosePetPop;
//using module.colderEvolution;
//using module.colourmatchGame;
//using module.comic;
//using module.communityCenter;
//using module.contractCall;
//using module.contractPet;
//using module.createAvatar;
//using module.crewHandbook;
//using module.DangerousDataCabinPanel;
//using module.darkArenaLegends;
//using module.deathblackenergy;
//using module.deepSea;
//using module.deepSeaMonsterFight;
//using module.deepSpaceSubsidium;
//using module.demonKingGirod;
//using module.destinyWheel;
//using module.destroyMecha;
//using module.devilZax;
//using module.diamondMonthlyCard;
//using module.diamondTask;
//using module.dihuangzhiyuSummerSkinSell;
//using module.divineDomain4Kings;
//using module.dragonbingoGame;
//using module.dreamyHotSpringRoad;
//using module.eggWarehouse;
//using module.elderHelkasOutput;
//using module.energyResearchStation;
//using module.epicTreasurePanel;
//using module.evilKingWesk;
//using module.ExchangeDiamond;
//using module.exploreLuciou;
//using module.exploreMysteriousRealm;
//using module.exploreUndergroundCaves;
//using module.fightlab;
//using module.fightmousepanel;
//using module.fightshark;
//using module.fightWorldBossZacks;
//using module.firstPay;
//using module.firstPayPopUp;
//using module.fixCloth;
//using module.flyingKingVans;
//using module.Friend;
//using module.gaiyaSecondOrder;
//using module.gaiyaSpecialTraining;
//using module.gaoKaoSupport;
//using module.gearAndStarBrilliant;
//using module.gearAndStarKrefeld;
//using module.getAncientdragonking;
//using module.getDaNaoTianGong;
//using module.getDS001;
//using module.getLiumengSkin;
//using module.getReinhardtSkinPanel;
//using module.getTOH;
//using module.getYouNaSiSkin;
//using module.giantDuel;
//using module.godEmperorHuting;
//using module.godOfDream;
//using module.godOfEarthCassius;
//using module.godOfFear;
//using module.godOfNightDemonBlake;
//using module.godOfStorm;
//using module.godOfThunderRay;
//using module.godOfWarGaia;
//using module.godofWarGaiaSuperevo;
//using module.godReay;
//using module.godWeaponKenzhate;
//using module.godWeaponKenzhateRec;
//using module.goldenLightPegasusSuperEvolution;
//using module.goldShiningPegasusNationalBroadcasting;
//using module.gotoChannel2Act;
//using module.gotoChannelAct;
//using module.guideAresAllianceOutPut;
//using module.guideFeturePetsOutPut;
//using module.guideJimiOutPut;
//using module.guideMainPetsOutPut;
//using module.guideSuitOutPut;
//using module.handbook;
//using module.happyBingoSofy;
//using module.headFrame;
//using module.helpBook;
//using module.hideMovesShop;
//using module.holyCassius;
//using module.holyGaia;
//using module.holyHowBaiHu;
//using module.holyHowlBless;
//using module.holyKylin;
//using module.holyLightMonica;
//using module.holyMuse;
//using module.holyPuni;
//using module.holyWarCompleteBody;
//using module.huangMeiPetSellPanel;
//using module.huangMeiSkinSellPanel;
//using module.hunDunDiWang;
//using module.iceContractAksia;
//using module.industryAndMagic;
//using module.interstellarArena;
//using module.interstellarPrivilege;
//using module.itemRecycle;
//using module.itemWarehouse;
//using module.jianBiMecha;
//using module.jiangHuSkinSellPanel;
//using module.journeyWithTheStarlight;
//using module.kaBuDaEvolvePanel;
//using module.kabutackAppointmentPanel;
//using module.kabutackSportsMeeting;
//using module.keleibeiliOldSkin;
//using module.kingCassius;
//using module.kingGaia;
//using module.kingHamorLevel;
//using module.kingHamorPop;
//using module.kingMuse;
//using module.kingRay;
//using module.kuixingjieqiao;
//using module.KulatakeSkinPanel;
//using module.laidashenMain;
//using module.langlangMountainPreSign;
//using module.langlangshanArtCourse;
//using module.langlangshanCyberWoodenFish;
//using module.langlangshanEmoji;
//using module.langlangshanfightpanel;
//using module.latestActivities;
//using module.learningAbilityInputPop;
//using module.legendOfDice;
//using module.LeiyiGaiya;
//using module.leiyiSecondOrder;
//using module.leiyiSpecialTraining;
//using module.lightUpHandBook;
//using module.limitedAdastraActivity;
//using module.liumengClassicsSkinPanel;
//using module.llsDuel;
//using module.llsFarm;
//using module.llsTrip;
//using module.llsWorking;
//using module.luckyrocketGameEntry;
//using module.luoKaiShop;
//using module.luolinkaCommunicate;
//using module.luoLinKaFuKe;
//using module.luolinkaPreviewPanel;
//using module.mail;
//using module.mainLineDeepSeaDragon;
//using module.mainStoryLine;
//using module.mall;
//using module.mapChangeSelectPanel;
//using module.MarkBacktrack;
//using module.markCenter;
//using module.markDraw;
//using module.markWheel;
//using module.mechSharpedo;
//using module.memoryArchivesPanel;
//using module.memoryArchivesPet;
//using module.memoryArchivesPop;
//using module.midAutumnSkin;
//using module.militaryInfo;
//using module.mingYi;
//using module.mintStoneSell;
//using module.misticSuperevolution;
//using module.mixiuliNewForm;
//using module.moleculeIntensification;
//using module.moonShiningStarSoul;
//using module.museSpecialTraining;
//using module.museSuperEvo;
//using module.nadoresJourneyofRecovery;
//using module.newBrave;
//using module.newFightSuit;
//using module.newPlayerGuild;
//using module.newSeasonTask;
//using module.newSeer7Sign;
//using module.newSeerGift;
//using module.newSeerGuide;
//using module.newSeerWelfare;
//using module.newVip;
//using module.nonoMgrPanel;
//using module.npcDialogPanel;
//using module.obtLoginSign;
//using module.oceanPlanetCook;
//using module.oceanPlanetHermit;
//using module.oceanStarGame;
//using module.officialGroup;
//using module.oneKeyBestDiscountMain;
//using module.oneKeyBestLimitDiscount;
//using module.OnekeyUltimate;
//using module.oracleAdvance;
//using module.oreProspectEntryPanel;
//using module.originRecall;
//using module.peaceMedalMark;
//using module.peakAssemblySale;
//using module.peakJihad6V6BanPickModePanel;
//using module.peakJihadAutoOpen;
//using module.peakJihadExpertModeBanPickPanel;
//using module.peakJihadFirstPage;
//using module.peakJihadFreeWar;
//using module.peakJihadHonorPantheon;
//using module.peakJihadMatchWaitModePanel;
//using module.peakJihadNewTask;
//using module.peakJihadOrderPanel;
//using module.peakJihadRankPanel;
//using module.peakJihadShopPanel;
//using module.peakWeeklyReward;
//using module.personalInformation;
//using module.personalInformation.Card;
//using module.perviousYearvip;
//using module.petBag;
//using module.petBattle;
//using module.petBattleActivity;
//using module.petbookAttRelationShip;
//using module.petCompetitorInfo;
//using module.petEffect;
//using module.petGetPop;
//using module.petHandbookInfo;
//using module.petInfoPop;
//using module.petKingBattle;
//using module.petKingBattleActivity;
//using module.petLevelPanel;
//using module.petMonthlyLoginGift;
//using module.petNewSkillPanel;
//using module.petRecruit;
//using module.phoenixPassPanel;
//using module.piGodJump;
//using module.piGodLevel;
//using module.powerSupportGame;
//using module.privateSign;
//using module.puniFight;
//using module.puniGodChallenge;
//using module.puniGodChallengeEntry;
//using module.pveAiXiaLa;
//using module.pveAoliaPanel;
//using module.pveDragonKillerAiMoLiSha;
//using module.pveElvenKingTrial;
//using module.pveEncarlose;
//using module.pveEnterPanel;
//using module.pveExpTraining;
//using module.pveJieHuang;
//using module.pveJiehuangPowerup;
//using module.pveLanLu;
//using module.pveMainPet;
//using module.pveNinjutsuClub;
//using module.pvePetYinzi;
//using module.pveSorensen;
//using module.pveSpt;
//using module.pveStarTrek;
//using module.pveTitanHole;
//using module.pveXTeamRoom;
//using module.pveYiFuLiSha;
//using module.pveYingKaLuoSi;
//using module.pveZhanZhiKuangRe;
//using module.qianShang;
//using module.qingLong;
//using module.qiQiaoXinYuSkinSell;
//using module.qunxingSkinSell;
//using module.rapidMecha;
//using module.rayGaiaPetSkin;
//using module.redPupilMuse;
//using module.repairSpaceStation;
//using module.resistanceItemShop;
//using module.resistPirateAttacks;
//using module.roadConnectionGame;
//using module.roomEditPop;
//using module.roomShop;
//using module.roomVisitPop;
//using module.s67NihunPTFD;
//using module.s86AnkaMainPanel;
//using module.securityCheck;
//using module.seer16thAnniversaryHelpsGetGift;
//using module.seerClothesWarehouse;
//using module.seerComplain;
//using module.seerFactory;
//using module.seerInterstellarPassport;
//using module.seerPainting;
//using module.seerSuitClothesView;
//using module.seerTitleChangeVIew;
//using module.sharkMouthCleaning;
//using module.shawnsMission;
//using module.shawnsMissionActivity;
//using module.shayulajiaoSellPanel;
//using module.ShengTingReay;
//using module.shengzhanRuiersi;
//using module.shenHaiGuLong;
//using module.shenluoShenghuaSkin;
//using module.shizulingshouNewFrom;
//using module.shuoxingCeremony;
//using module.signIn7Days;
//using module.signInActivityPopUpPanel;
//using module.sixGod;
//using module.sixRealmsGodKingHall;
//using module.sixteenThMarkSell;
//using module.sixteenYearsEntrance;
//using module.sixteenYearsLoginReward;
//using module.skinGetPop;
//using module.skinShopActivity;
//using module.sorensenFinal;
//using module.spacecraftManual;
//using module.sPetMoeraeMain;
//using module.spiderDetectiveMoneyBox;
//using module.starlightHidden;
//using module.starlightHiddenAward;
//using module.stgBossshare;
//using module.stgstage;
//using module.studytraining;
//using module.summerDrinkSupply;
//using module.summerHolidaySign;
//using module.summerSkin;
//using module.Survey;
//using module.sweetOsmanthus;
//using module.systemSet;
//using module.taikongzhanFight;
//using module.team;
//using module.teamCreate;
//using module.teamDefence;
//using module.templeHeroesBuyPetPop;
//using module.templeHeroesBuySkinPop;
//using module.templeHeroesCommonPanel;
//using module.templeHeroesDrawPanel;
//using module.templeHeroesMain;
//using module.thirteenYearSkin;
//using module.tiejiaxiaobaoBattlePass;
//using module.tortoisePassPanel;
//using module.towerOfCouragePanel;
//using module.treasureOfBamPanel;
//using module.turma;
//using module.universalModule;
//using module.unusPayReturn;
//using module.vehicleDiscountedSales;
//using module.vipMonthPet;
//using module.vipPetSale;
//using module.wanzilong;
//using module.warehouse;
//using module.webglToApp;
//using module.weeklyUpdateGuidelines;
//using module.wishFloating;
//using module.wishList;
//using module.worldMap;
//using module.wrenchBroSellPanel;
//using module.wujishengwu;
//using module.xingguangpetskin;
//using module.xitalunAstronautSkinSell;
//using module.yearvip2025;
//using module.yifuPveLevel;
//using module.yinKaLuoShiSkin;
//using module.yuehuaGainPanel;
//using module.zhakesiSellPanel;
//using module.zhenshiQTLD;
//using module.zhenXinGongMingSkinSell;
//using module.zhiMingActivity;
//using module.zhiMingActivityMain;
//using newSeerToolbarGuide;

namespace core.config
{
	// Token: 0x02001EAB RID: 7851
	public class ModuleClazzInfo
	{
		// Token: 0x0600EA9E RID: 60062 RVA: 0x003E8928 File Offset: 0x003E6B28
		public static void addModuleClazzService(IModuleClazzService moduleClazzService)
		{
			if (ModuleClazzInfo.moduleClazzServices.Contains(moduleClazzService))
			{
				return;
			}
			ModuleClazzInfo.moduleClazzServices.Add(moduleClazzService);
		}

		// Token: 0x0600EA9F RID: 60063 RVA: 0x003E8944 File Offset: 0x003E6B44
		//public static BaseModule getModuleIns(int id)
		//{
		//	BaseModule baseModule = null;
		//	switch (id)
		//	{
		//	case 3:
		//		baseModule = new pveExpTraining();
		//		break;
		//	case 4:
		//		baseModule = new Warehouse();
		//		break;
		//	case 5:
		//		baseModule = new MarkCenterModule();
		//		break;
		//	case 6:
		//		baseModule = new Mail();
		//		break;
		//	case 7:
		//		baseModule = new Handbook();
		//		break;
		//	case 8:
		//		baseModule = new PeakJihadFirstPage();
		//		break;
		//	case 10:
		//		baseModule = new PetBag();
		//		break;
		//	case 12:
		//		baseModule = new PersonalinformationIdCard();
		//		break;
		//	case 13:
		//		baseModule = new PeakJihadNewTask();
		//		break;
		//	case 14:
		//		baseModule = new towerOfCouragePanel();
		//		break;
		//	case 15:
		//		baseModule = new ItemWarehouse();
		//		break;
		//	case 16:
		//		baseModule = new pveTitanHole();
		//		break;
		//	case 17:
		//		baseModule = new studytraining();
		//		break;
		//	case 18:
		//		baseModule = new PveEnterPanel();
		//		break;
		//	case 19:
		//		baseModule = new PveElvenKingTrial();
		//		break;
		//	case 20:
		//		baseModule = new PveXTeamRoom();
		//		break;
		//	case 23:
		//		baseModule = new PveNinjutsuClub();
		//		break;
		//	case 24:
		//		baseModule = new Friend();
		//		break;
		//	case 25:
		//		baseModule = new StarTrekModule();
		//		break;
		//	case 26:
		//		baseModule = new EggWarehouse();
		//		break;
		//	case 27:
		//		baseModule = new PersonalInformation();
		//		break;
		//	case 35:
		//		baseModule = new HeadFrame();
		//		break;
		//	case 43:
		//		baseModule = new PeakJihadMatchWaitModePanel();
		//		break;
		//	case 48:
		//		baseModule = new BagStorageSwitchChoose();
		//		break;
		//	case 50:
		//		baseModule = new Achieve();
		//		break;
		//	case 51:
		//		baseModule = new SeerTitleChangeVIew();
		//		break;
		//	case 52:
		//		baseModule = new SeerSuitClothesView();
		//		break;
		//	case 54:
		//		baseModule = new SeerClothesWarehouse();
		//		break;
		//	case 56:
		//		baseModule = new PveSpt();
		//		break;
		//	case 58:
		//		baseModule = new PuniFightModule();
		//		break;
		//	case 59:
		//		baseModule = new WishFloating();
		//		break;
		//	case 63:
		//		baseModule = new Mall();
		//		break;
		//	case 64:
		//		baseModule = new MapChangeSelectPanel();
		//		break;
		//	case 65:
		//		baseModule = new PveJieHuang();
		//		break;
		//	case 66:
		//		baseModule = new PveJiehuangPowerup();
		//		break;
		//	case 68:
		//		baseModule = new PveAYaPanel();
		//		break;
		//	case 69:
		//		baseModule = new KingHamorPopModule();
		//		break;
		//	case 70:
		//		baseModule = new KingHamorLevelModule();
		//		break;
		//	case 71:
		//		baseModule = new ComicModule();
		//		break;
		//	case 72:
		//		baseModule = new SystemSet();
		//		break;
		//	case 73:
		//		baseModule = new TeamCreate();
		//		break;
		//	case 74:
		//		baseModule = new Team();
		//		break;
		//	case 77:
		//		baseModule = new Team();
		//		break;
		//	case 78:
		//		baseModule = new Team();
		//		break;
		//	case 79:
		//		baseModule = new Team();
		//		break;
		//	case 80:
		//		baseModule = new TeamTask();
		//		break;
		//	case 81:
		//		baseModule = new PveYiFuLiSha();
		//		break;
		//	case 83:
		//		baseModule = new PveEncarloseJustin();
		//		break;
		//	case 84:
		//		baseModule = new NonoMgrPanel();
		//		break;
		//	case 85:
		//		baseModule = new PveSorensenModule();
		//		break;
		//	case 87:
		//		baseModule = new HolyPuni();
		//		break;
		//	case 88:
		//		baseModule = new BruteSorensenModule();
		//		break;
		//	case 90:
		//		baseModule = new PveLanLu();
		//		break;
		//	case 91:
		//		baseModule = new PveMainPet();
		//		break;
		//	case 92:
		//		baseModule = new SorensenFinal();
		//		break;
		//	case 93:
		//		baseModule = new PveYingKaLuoSi();
		//		break;
		//	case 94:
		//		baseModule = new PveZhanZhiKuangRe();
		//		break;
		//	case 95:
		//		baseModule = new PveAiXiaLa();
		//		break;
		//	case 97:
		//		baseModule = new DestroyMecha();
		//		break;
		//	case 99:
		//		baseModule = new jianBiMecha();
		//		break;
		//	case 101:
		//		baseModule = new DevilZax();
		//		break;
		//	case 102:
		//		baseModule = new DemonKingGirod();
		//		break;
		//	case 103:
		//		baseModule = new DivineDomain4Kings();
		//		break;
		//	case 104:
		//		baseModule = new EvilKingWesk();
		//		break;
		//	case 105:
		//		baseModule = new PveDragonKillerAiMoLiSha();
		//		break;
		//	case 106:
		//		baseModule = new MingYi();
		//		break;
		//	case 107:
		//		baseModule = new GodEmperorHuting();
		//		break;
		//	case 109:
		//		baseModule = new IceContractAksia();
		//		break;
		//	case 110:
		//		baseModule = new ActivityCenter();
		//		break;
		//	case 112:
		//		baseModule = new ShengTingReay();
		//		break;
		//	case 113:
		//		baseModule = new QianShang();
		//		break;
		//	case 114:
		//		baseModule = new SixRealmsGodKingHall();
		//		break;
		//	case 116:
		//		baseModule = new HolyLightMonica();
		//		break;
		//	case 117:
		//		baseModule = new CreateAvatar();
		//		break;
		//	case 118:
		//		baseModule = new MoonShiningStarSoul();
		//		break;
		//	case 119:
		//		baseModule = new GodOfDreamModule();
		//		break;
		//	case 120:
		//		baseModule = new GodOfStorm();
		//		break;
		//	case 121:
		//		baseModule = new GodOfFear();
		//		break;
		//	case 122:
		//		baseModule = new WorldMap();
		//		break;
		//	case 123:
		//		baseModule = new RapidMecha();
		//		break;
		//	case 124:
		//		baseModule = new PetLevelModule();
		//		break;
		//	case 125:
		//		baseModule = new PveAliYaPanel();
		//		break;
		//	case 126:
		//		baseModule = new PveAoliaPanel();
		//		break;
		//	case 127:
		//		baseModule = new PveEncarloseEvo();
		//		break;
		//	case 128:
		//		baseModule = new GuideMainPetsOutPut();
		//		break;
		//	case 129:
		//		baseModule = new GuideJimiOutPut();
		//		break;
		//	case 130:
		//		baseModule = new GuideSuitOutPut();
		//		break;
		//	case 131:
		//		baseModule = new GuideAresAllianceOutPut();
		//		break;
		//	case 132:
		//		baseModule = new GuideFeturePetsOutPut();
		//		break;
		//	case 135:
		//		baseModule = new MarkDraw();
		//		break;
		//	case 136:
		//		baseModule = new NewSeerToolbarGuide();
		//		break;
		//	case 137:
		//		baseModule = new NewVip();
		//		break;
		//	case 139:
		//		baseModule = new fightlab();
		//		break;
		//	case 141:
		//		baseModule = new NewSeerWelfare();
		//		break;
		//	case 142:
		//		baseModule = new NewSeer7Sign();
		//		break;
		//	case 144:
		//		baseModule = new PetRecruit();
		//		break;
		//	case 146:
		//		baseModule = new FirstPay();
		//		break;
		//	case 147:
		//		baseModule = new FirstPayPopUp();
		//		break;
		//	case 148:
		//		baseModule = new MarkWheel();
		//		break;
		//	case 149:
		//		baseModule = new DiamondTask();
		//		break;
		//	case 150:
		//		baseModule = new BattlefirePanel();
		//		break;
		//	case 151:
		//		baseModule = new PvePetYinzi();
		//		break;
		//	case 153:
		//		baseModule = new RoomEditPop();
		//		break;
		//	case 154:
		//		baseModule = new SeerComplain();
		//		break;
		//	case 155:
		//		baseModule = new RoomVisitPop();
		//		break;
		//	case 158:
		//		baseModule = new RoomShop();
		//		break;
		//	case 159:
		//		baseModule = new TeamBoss();
		//		break;
		//	case 160:
		//		baseModule = new TeamTrader();
		//		break;
		//	case 163:
		//		baseModule = new SpacecraftManual();
		//		break;
		//	case 164:
		//		baseModule = new ContractCall();
		//		break;
		//	case 166:
		//		baseModule = new SeerFactory();
		//		break;
		//	case 167:
		//		baseModule = new TempleHeroesMain();
		//		break;
		//	case 168:
		//		baseModule = new PetMonthlyLoginGift();
		//		break;
		//	case 169:
		//		baseModule = new TempleHeroesCommonPanel();
		//		break;
		//	case 175:
		//		baseModule = new OnekeyUltimate();
		//		break;
		//	case 176:
		//		baseModule = new TempleHeroesDrawPanel();
		//		break;
		//	case 177:
		//		baseModule = new TempleHeroesBuyPetPop();
		//		break;
		//	case 178:
		//		baseModule = new TempleHeroesBuySkinPop();
		//		break;
		//	case 181:
		//		baseModule = new LearningAbilityInput();
		//		break;
		//	case 182:
		//		baseModule = new ExchangeDiamond();
		//		break;
		//	case 183:
		//		baseModule = new LatestActivities();
		//		break;
		//	case 185:
		//		baseModule = new BlessOfDivineAnimals();
		//		break;
		//	case 187:
		//		baseModule = new OracleAdvance();
		//		break;
		//	case 188:
		//		baseModule = new EnergyResearchStation();
		//		break;
		//	case 189:
		//		baseModule = new Backflow();
		//		break;
		//	case 194:
		//		baseModule = new PeakWeeklyReward();
		//		break;
		//	case 197:
		//		baseModule = new ChoosePetPop();
		//		break;
		//	case 198:
		//		baseModule = new FixCloth();
		//		break;
		//	case 199:
		//		baseModule = new Yearvip2025();
		//		break;
		//	case 200:
		//		baseModule = new AresAlliance();
		//		break;
		//	case 202:
		//		baseModule = new HolyMuseModule();
		//		break;
		//	case 204:
		//		baseModule = new HolyGaia();
		//		break;
		//	case 205:
		//		baseModule = new HolyCassius();
		//		break;
		//	case 206:
		//		baseModule = new ChaoticBlake();
		//		break;
		//	case 207:
		//		baseModule = new KingGaia();
		//		break;
		//	case 208:
		//		baseModule = new AchieveNotice();
		//		break;
		//	case 209:
		//		baseModule = new SignInActivityPopUpPanel();
		//		break;
		//	case 210:
		//		baseModule = new KingMuseModule();
		//		break;
		//	case 211:
		//		baseModule = new PeakJihadOrderPanel();
		//		break;
		//	case 212:
		//		baseModule = new PeakJihadOrderPanel();
		//		break;
		//	case 213:
		//		baseModule = new NewSeerGift();
		//		break;
		//	case 214:
		//		baseModule = new KingCassius();
		//		break;
		//	case 216:
		//		baseModule = new KingRay();
		//		break;
		//	case 217:
		//		baseModule = new CommunityCenter();
		//		break;
		//	case 218:
		//		baseModule = new RedPupilMuseModule();
		//		break;
		//	case 219:
		//		baseModule = new GodOfWarGaia();
		//		break;
		//	case 220:
		//		baseModule = new GodOfEarthCassius();
		//		break;
		//	case 221:
		//		baseModule = new PhoenixPassPanel();
		//		break;
		//	case 222:
		//		baseModule = new MilitaryInfo();
		//		break;
		//	case 223:
		//		baseModule = new TortoisePassPanel();
		//		break;
		//	case 224:
		//		baseModule = new MemoryArchivesPop();
		//		break;
		//	case 225:
		//		baseModule = new module.memoryArchivesPanel.MemoryArchivesPanel();
		//		break;
		//	case 226:
		//		baseModule = new MemoryArchivesPet();
		//		break;
		//	case 227:
		//		baseModule = new PetInfoPop();
		//		break;
		//	case 228:
		//		baseModule = new HolyHowBaiHu();
		//		break;
		//	case 229:
		//		baseModule = new GodOfNightDemonBlake();
		//		break;
		//	case 230:
		//		baseModule = new GodOfThunderRay();
		//		break;
		//	case 231:
		//		baseModule = new CassiusSuperEvo();
		//		break;
		//	case 232:
		//		baseModule = new MuseSuperEvoModule();
		//		break;
		//	case 233:
		//		baseModule = new GodReay();
		//		break;
		//	case 234:
		//		baseModule = new HolyKylin();
		//		break;
		//	case 238:
		//		baseModule = new museSpecialTrainingModule();
		//		break;
		//	case 239:
		//		baseModule = new BlackEvo();
		//		break;
		//	case 240:
		//		baseModule = new BlakeSpecialTraining();
		//		break;
		//	case 241:
		//		baseModule = new LeiyiSpecialTraining();
		//		break;
		//	case 242:
		//		baseModule = new CassiusSpecialTraining();
		//		break;
		//	case 243:
		//		baseModule = new GaiyaSpecialTraining();
		//		break;
		//	case 246:
		//		baseModule = new GodofWarGaiaSuperevo();
		//		break;
		//	case 247:
		//		baseModule = new QingLong();
		//		break;
		//	case 248:
		//		baseModule = new SixGod();
		//		break;
		//	case 249:
		//		baseModule = new HelpBook();
		//		break;
		//	case 251:
		//		baseModule = new HolyHowlBless();
		//		break;
		//	case 253:
		//		baseModule = new PetGetPop();
		//		break;
		//	case 254:
		//		baseModule = new SkinGetPop();
		//		break;
		//	case 255:
		//		baseModule = new PeakJihadShopPanel();
		//		break;
		//	case 256:
		//		baseModule = new PeakJihadRankPanel();
		//		break;
		//	case 257:
		//		baseModule = new peakJihad6V6BanPickModePanel();
		//		break;
		//	case 258:
		//		baseModule = new peakJihadFreeWar();
		//		break;
		//	case 260:
		//		baseModule = new BattleResult();
		//		break;
		//	case 261:
		//		baseModule = new NpcDialogPanel();
		//		break;
		//	case 262:
		//		baseModule = new PetHandbookInfo();
		//		break;
		//	case 264:
		//		baseModule = new AdvancedPetBackStore();
		//		break;
		//	case 265:
		//		baseModule = new PetbookAttRelationShip();
		//		break;
		//	case 268:
		//		baseModule = new TeamDefence();
		//		break;
		//	case 269:
		//		baseModule = new PetNewSkillPanel();
		//		break;
		//	case 271:
		//		baseModule = new ContractPet();
		//		break;
		//	case 272:
		//		baseModule = new PetEffect();
		//		break;
		//	case 274:
		//		baseModule = new CrewHandbook();
		//		break;
		//	case 275:
		//		baseModule = new PeakJihadExpertModeBanPickPanel();
		//		break;
		//	case 276:
		//		baseModule = new Survey();
		//		break;
		//	case 277:
		//		baseModule = new BilibiliModule();
		//		break;
		//	case 278:
		//		baseModule = new OfficialGroupModule();
		//		break;
		//	case 280:
		//		baseModule = new AdAstra();
		//		break;
		//	case 281:
		//		baseModule = new PetCompetitorInfo();
		//		break;
		//	case 282:
		//		baseModule = new MainStoryLine();
		//		break;
		//	case 283:
		//		baseModule = new AdAstraActivity();
		//		break;
		//	case 284:
		//		baseModule = new StarlightHidden();
		//		break;
		//	case 285:
		//		baseModule = new StarlightHiddenAward();
		//		break;
		//	case 286:
		//		baseModule = new MarkBacktrack();
		//		break;
		//	case 287:
		//		baseModule = new AwakeActivity();
		//		break;
		//	case 288:
		//		baseModule = new AwakeMain();
		//		break;
		//	case 289:
		//		baseModule = new SeerInterstellarPassport();
		//		break;
		//	case 290:
		//		baseModule = new VipMonthPet();
		//		break;
		//	case 291:
		//		baseModule = new AnHunSuoBiLaTe();
		//		break;
		//	case 292:
		//		baseModule = new ElderHelkasOutput();
		//		break;
		//	case 293:
		//		baseModule = new WeeklyUpdateGuidelinesModule();
		//		break;
		//	case 294:
		//		baseModule = new PiGodLevel();
		//		break;
		//	case 295:
		//		baseModule = new PiGodJump();
		//		break;
		//	case 296:
		//		baseModule = new SignIn7Days();
		//		break;
		//	case 297:
		//		baseModule = new BattleTestFightModule();
		//		break;
		//	case 299:
		//		baseModule = new LaidashenMain();
		//		break;
		//	case 300:
		//		baseModule = new LightUpHandBook();
		//		break;
		//	case 301:
		//		baseModule = new GetDaNaoTianGongModule();
		//		break;
		//	case 302:
		//		baseModule = new HappyBingoSofy();
		//		break;
		//	case 303:
		//		baseModule = new DreamyHotSpringRoad();
		//		break;
		//	case 304:
		//		baseModule = new AngerDilke();
		//		break;
		//	case 305:
		//		baseModule = new CangyueShadowLegendSkinSale();
		//		break;
		//	case 306:
		//		baseModule = new OneKeyBestLimitDiscount();
		//		break;
		//	case 307:
		//		baseModule = new OneKeyBestDiscountMain();
		//		break;
		//	case 308:
		//		baseModule = new NadoresJourneyofRecovery();
		//		break;
		//	case 309:
		//		baseModule = new ExploreUndergroundCaves();
		//		break;
		//	case 400:
		//		baseModule = new ZhiMingActivity();
		//		break;
		//	case 401:
		//		baseModule = new zhiMingActivityMain();
		//		break;
		//	case 402:
		//		baseModule = new NewFightSuit();
		//		break;
		//	case 403:
		//		baseModule = new artemisCompletePop();
		//		break;
		//	case 404:
		//		baseModule = new ArtemisCompletePanel();
		//		break;
		//	case 405:
		//		baseModule = new ArtemisSkin();
		//		break;
		//	case 406:
		//		baseModule = new SkinShopJumpActivity();
		//		break;
		//	case 407:
		//		baseModule = new GotoChannelAct();
		//		break;
		//	case 408:
		//		baseModule = new GotoChannel2Act();
		//		break;
		//	case 409:
		//		baseModule = new PeakJihadAutoOpen();
		//		break;
		//	case 410:
		//		baseModule = new NewSeasonTask();
		//		break;
		//	case 411:
		//		baseModule = new RepairSpaceStationEntry();
		//		break;
		//	case 412:
		//		baseModule = new RepairSpaceStationMain();
		//		break;
		//	case 413:
		//		baseModule = new HideMovesShop();
		//		break;
		//	case 414:
		//		baseModule = new ActivityListPreview();
		//		break;
		//	case 415:
		//		baseModule = new PerviousYearvip();
		//		break;
		//	case 416:
		//		baseModule = new ShawnsMissionModule();
		//		break;
		//	case 417:
		//		baseModule = new DangerousDataCabinEntry();
		//		break;
		//	case 418:
		//		baseModule = new ShawnsMissionActivityModule();
		//		break;
		//	case 419:
		//		baseModule = new DangerousDataCabinMain();
		//		break;
		//	case 420:
		//		baseModule = new BraveTowerReverseDefense();
		//		break;
		//	case 421:
		//		baseModule = new LuoKaiShop();
		//		break;
		//	case 422:
		//		baseModule = new CastleSeriesSkinSales();
		//		break;
		//	case 423:
		//		baseModule = new CastleSeriesSkinSalesPop();
		//		break;
		//	case 424:
		//		baseModule = new PetBattle();
		//		break;
		//	case 425:
		//		baseModule = new TaiKongZhanFight();
		//		break;
		//	case 426:
		//		baseModule = new YinKaLuoShiSkin();
		//		break;
		//	case 427:
		//		baseModule = new PuniGodChallengeEntry();
		//		break;
		//	case 428:
		//		baseModule = new PuniGodChallenge();
		//		break;
		//	case 429:
		//		baseModule = new privateSign();
		//		break;
		//	case 430:
		//		baseModule = new GodWeaponKenzhate();
		//		break;
		//	case 431:
		//		baseModule = new PetBattleActivity();
		//		break;
		//	case 432:
		//		baseModule = new DarkArenaLegends();
		//		break;
		//	case 433:
		//		baseModule = new ShizulingshouNewFrom();
		//		break;
		//	case 434:
		//		baseModule = new ShizulingshouNewFromPop();
		//		break;
		//	case 435:
		//		baseModule = new NewPlayerGuild();
		//		break;
		//	case 436:
		//		baseModule = new InterstellarArena();
		//		break;
		//	case 437:
		//		baseModule = new GodWeaponKenzhateRec();
		//		break;
		//	case 438:
		//		baseModule = new StarThreeMainPetChoose();
		//		break;
		//	case 439:
		//		baseModule = new HolyWarCompleteBody();
		//		break;
		//	case 440:
		//		baseModule = new PetKingBattleActivity();
		//		break;
		//	case 441:
		//		baseModule = new PetKingBattle();
		//		break;
		//	case 442:
		//		baseModule = new FirstPayPopUp();
		//		break;
		//	case 443:
		//		baseModule = new NewBrave();
		//		break;
		//	case 444:
		//		baseModule = new DestinyWheel();
		//		break;
		//	case 445:
		//		baseModule = new UniversalModule();
		//		break;
		//	case 446:
		//		baseModule = new VipPetSale();
		//		break;
		//	case 447:
		//		baseModule = new ResistPirateAttacks();
		//		break;
		//	case 448:
		//		baseModule = new VehicleDiscountedSales();
		//		break;
		//	case 449:
		//		baseModule = new PowerSupportGame();
		//		break;
		//	case 450:
		//		baseModule = new LimitedAdastraActivity();
		//		break;
		//	case 451:
		//		baseModule = new SeerPainting();
		//		break;
		//	case 452:
		//		baseModule = new CDKey();
		//		break;
		//	case 453:
		//		baseModule = new OriginRecall();
		//		break;
		//	case 454:
		//		baseModule = new AnniversaryVaultEntry();
		//		break;
		//	case 455:
		//		baseModule = new AnniversaryVaultMall();
		//		break;
		//	case 456:
		//		baseModule = new ExploreMysteriousRealmEntry();
		//		break;
		//	case 457:
		//		baseModule = new ExploreMysteriousRealmGame();
		//		break;
		//	case 458:
		//		baseModule = new JourneyWithTheStarlight();
		//		break;
		//	case 459:
		//		baseModule = new WishList();
		//		break;
		//	case 471:
		//		baseModule = new StgBossShareModule();
		//		break;
		//	case 472:
		//		baseModule = new StgModule();
		//		break;
		//	case 474:
		//		baseModule = new LegendOfDiceEntrance();
		//		break;
		//	case 475:
		//		baseModule = new LegendOfDice();
		//		break;
		//	case 476:
		//		baseModule = new SixteenYearsEntrance();
		//		break;
		//	case 477:
		//		baseModule = new LeiyiGaiyaEntry();
		//		break;
		//	case 478:
		//		baseModule = new LeiyiGaiyaMain();
		//		break;
		//	case 479:
		//		baseModule = new ObtLoginSign();
		//		break;
		//	case 480:
		//		baseModule = new XingGuangPetSkin();
		//		break;
		//	case 484:
		//		baseModule = new InterstellarPrivilege();
		//		break;
		//	case 485:
		//		baseModule = new GaoKaoSupport();
		//		break;
		//	case 486:
		//		baseModule = new GetLiumengSkin();
		//		break;
		//	case 487:
		//		baseModule = new ZhakesiSellPanelEntry();
		//		break;
		//	case 488:
		//		baseModule = new Seer16thAnniversaryHelpsGetGift();
		//		break;
		//	case 489:
		//		baseModule = new SixteenYearsLoginReward();
		//		break;
		//	case 490:
		//		baseModule = new ZhakesiSellPanelOpenPop();
		//		break;
		//	case 491:
		//		baseModule = new FightWorldBossZacks();
		//		break;
		//	case 492:
		//		baseModule = new LeiyiSecondOrder();
		//		break;
		//	case 493:
		//		baseModule = new YouNaSiSkin();
		//		break;
		//	case 494:
		//		baseModule = new ExploreLuciouEntry();
		//		break;
		//	case 495:
		//		baseModule = new ExploreLuciouMain();
		//		break;
		//	case 496:
		//		baseModule = new GaiyaSecondOrderMain();
		//		break;
		//	case 498:
		//		baseModule = new UnusPayReturn();
		//		break;
		//	case 499:
		//		baseModule = new RayGaiaPetSkin();
		//		break;
		//	case 502:
		//		baseModule = new YueHuaGainModule();
		//		break;
		//	case 503:
		//		baseModule = new SixteenThMarkSell();
		//		break;
		//	case 504:
		//		baseModule = new MintStoneSell();
		//		break;
		//	case 505:
		//		baseModule = new liumengClassicsSkinPanel();
		//		break;
		//	case 506:
		//		baseModule = new GetTOH();
		//		break;
		//	case 507:
		//		baseModule = new ThirteenYearSkin();
		//		break;
		//	case 508:
		//		baseModule = new DiamondMonthlyCard();
		//		break;
		//	case 509:
		//		baseModule = new SummerDrinkSupply();
		//		break;
		//	case 510:
		//		baseModule = new SharkMouthCleaningEntry();
		//		break;
		//	case 511:
		//		baseModule = new SharkMouthCleaningGame();
		//		break;
		//	case 512:
		//		baseModule = new ItemRecycle();
		//		break;
		//	case 513:
		//		baseModule = new OceanStarGame();
		//		break;
		//	case 514:
		//		baseModule = new SummerSkinEntry();
		//		break;
		//	case 515:
		//		baseModule = new SummerSkinMain();
		//		break;
		//	case 516:
		//		baseModule = new DeepSeaMonsterFight();
		//		break;
		//	case 517:
		//		baseModule = new ColderEvolution();
		//		break;
		//	case 518:
		//		baseModule = new KulatakeSkinPanel();
		//		break;
		//	case 519:
		//		baseModule = new OreProspect();
		//		break;
		//	case 520:
		//		baseModule = new DihuangzhiyuSummerSkinSell();
		//		break;
		//	case 521:
		//		baseModule = new TurmaModule();
		//		break;
		//	case 522:
		//		baseModule = new BagCompensationModule();
		//		break;
		//	case 523:
		//		baseModule = new OceanPlanetHermit();
		//		break;
		//	case 524:
		//		baseModule = new OceanPlanetCook();
		//		break;
		//	case 525:
		//		baseModule = new DeepSeaMainModule();
		//		break;
		//	case 526:
		//		baseModule = new DeepSeaGamePlayModule();
		//		break;
		//	case 527:
		//		baseModule = new HunDunDiWang();
		//		break;
		//	case 528:
		//		baseModule = new AutoFightModule();
		//		break;
		//	case 529:
		//		baseModule = new ResistanceItemShop();
		//		break;
		//	case 530:
		//		baseModule = new MechSharpedo();
		//		break;
		//	case 531:
		//		baseModule = new SummerHolidaySign();
		//		break;
		//	case 532:
		//		baseModule = new DragonbingoGame();
		//		break;
		//	case 533:
		//		baseModule = new GetReinhardtSkin();
		//		break;
		//	case 534:
		//		baseModule = new WebglToApp();
		//		break;
		//	case 535:
		//		baseModule = new MoleculeIntensification();
		//		break;
		//	case 536:
		//		baseModule = new ShenHaiGuLong();
		//		break;
		//	case 537:
		//		baseModule = new Fightshark();
		//		break;
		//	case 538:
		//		baseModule = new MainLineDeepSeaDragon();
		//		break;
		//	case 539:
		//		baseModule = new GetDS001Module();
		//		break;
		//	case 540:
		//		baseModule = new LangLangMountainPreSign();
		//		break;
		//	case 541:
		//		baseModule = new LLSWorkingModule();
		//		break;
		//	case 542:
		//		baseModule = new LanglangshanArtCourseModule();
		//		break;
		//	case 543:
		//		baseModule = new s86Anka();
		//		break;
		//	case 544:
		//		baseModule = new LlsFarm();
		//		break;
		//	case 545:
		//		baseModule = new LlsTrip();
		//		break;
		//	case 546:
		//		baseModule = new jiangHuSkinSell();
		//		break;
		//	case 547:
		//		baseModule = new LanglangshanEmoji();
		//		break;
		//	case 548:
		//		baseModule = new MisticSuperevolution();
		//		break;
		//	case 549:
		//		baseModule = new HuangMeiPetSell();
		//		break;
		//	case 550:
		//		baseModule = new HuangMeiSkinSell();
		//		break;
		//	case 551:
		//		baseModule = new llsDuelEntrance();
		//		break;
		//	case 552:
		//		baseModule = new llsDuelGameMain();
		//		break;
		//	case 553:
		//		baseModule = new CanglanComplete();
		//		break;
		//	case 554:
		//		baseModule = new Fightmousepanel();
		//		break;
		//	case 555:
		//		baseModule = new CanglanCompleteActivityCenter();
		//		break;
		//	case 556:
		//		baseModule = new LLSBattleModule();
		//		break;
		//	case 557:
		//		baseModule = new LLSCyberWoodenFishModule();
		//		break;
		//	case 558:
		//		baseModule = new TeamBossActivityCenter();
		//		break;
		//	case 559:
		//		baseModule = new GetAncientdragonkingModule();
		//		break;
		//	case 560:
		//		baseModule = new TeamTraderActivityCenter();
		//		break;
		//	case 561:
		//		baseModule = new Kuixingjieqiao();
		//		break;
		//	case 562:
		//		baseModule = new ZhenXinGongMingSkinSellModule();
		//		break;
		//	case 563:
		//		baseModule = new LuolinkaPreview();
		//		break;
		//	case 564:
		//		baseModule = new ShengZhanRuiersi();
		//		break;
		//	case 565:
		//		baseModule = new ShengZhanRuiersiActivityCenter();
		//		break;
		//	case 566:
		//		baseModule = new MixiuliNewForm();
		//		break;
		//	case 567:
		//		baseModule = new QiQiaoXinYuSkinSell();
		//		break;
		//	case 568:
		//		baseModule = new RoadConnectionActivity();
		//		break;
		//	case 569:
		//		baseModule = new RoadConnectionGame();
		//		break;
		//	case 570:
		//		baseModule = new LuoLinKaFuKe();
		//		break;
		//	case 571:
		//		baseModule = new FlyingKingVansModule();
		//		break;
		//	case 572:
		//		baseModule = new FlyingKingVansMainModule();
		//		break;
		//	case 573:
		//		baseModule = new IndustryAndMagic();
		//		break;
		//	case 574:
		//		baseModule = new EpicTreasure();
		//		break;
		//	case 575:
		//		baseModule = new ColourmatchGame();
		//		break;
		//	case 576:
		//		baseModule = new AoliaFeatureUpgradeModule();
		//		break;
		//	case 577:
		//		baseModule = new PeakAssemblySale();
		//		break;
		//	case 578:
		//		baseModule = new GoldShiningPegasusNationalBroadcasting();
		//		break;
		//	case 579:
		//		baseModule = new GoldShiningPegasusNationalBroadcastingEnter();
		//		break;
		//	case 580:
		//		baseModule = new GoldenLightPegasusSuperEvolution();
		//		break;
		//	case 581:
		//		baseModule = new GoldenLightPegasusSuperEvolutionEnter();
		//		break;
		//	case 582:
		//		baseModule = new WrenchBroSell();
		//		break;
		//	case 583:
		//		baseModule = new LuolinkaCommunicate();
		//		break;
		//	case 584:
		//		baseModule = new DeepSpaceModule();
		//		break;
		//	case 585:
		//		baseModule = new shenluoShenghuaSkin();
		//		break;
		//	case 586:
		//		baseModule = new shenluoShenghuaSkin3();
		//		break;
		//	case 588:
		//		baseModule = new SecurityCheck();
		//		break;
		//	case 589:
		//		baseModule = new SecurityCheckEnter();
		//		break;
		//	case 590:
		//		baseModule = new BlueMoonModule();
		//		break;
		//	case 591:
		//		baseModule = new ShuoxingCeremony();
		//		break;
		//	case 597:
		//		baseModule = new xitalunAstronautSkinSell();
		//		break;
		//	case 598:
		//		baseModule = new wujishengwuModule();
		//		break;
		//	case 599:
		//		baseModule = new LuckyrockeModule();
		//		break;
		//	case 604:
		//		baseModule = new SweetOsmanthusEnterModule();
		//		break;
		//	case 605:
		//		baseModule = new SweetOsmanthusModule();
		//		break;
		//	case 606:
		//		baseModule = new S67NihunPTFD();
		//		break;
		//	case 607:
		//		baseModule = new Anniversary15thMarkSell();
		//		break;
		//	case 608:
		//		baseModule = new YifuPveLevel();
		//		break;
		//	case 609:
		//		baseModule = new YifuPveLevelEnter();
		//		break;
		//	case 610:
		//		baseModule = new GearAndStarBuyBrilliantModule();
		//		break;
		//	case 611:
		//		baseModule = new GearAndStarBuyKrefeldModule();
		//		break;
		//	case 612:
		//		baseModule = new QunxingSkinSell();
		//		break;
		//	case 613:
		//		baseModule = new KeLeiBeiLiOldModule();
		//		break;
		//	case 615:
		//		baseModule = new DeathBlackEnergy();
		//		break;
		//	case 616:
		//		baseModule = new TreasureOfBamModule();
		//		break;
		//	case 617:
		//		baseModule = new MidAutumnSkin();
		//		break;
		//	case 620:
		//		baseModule = new PeakJihadHonorPantheon();
		//		break;
		//	case 621:
		//		baseModule = new SPetMoeraeMainModule();
		//		break;
		//	case 623:
		//		baseModule = new Badboyswork();
		//		break;
		//	case 624:
		//		baseModule = new giantDuelModule();
		//		break;
		//	case 625:
		//		baseModule = new spiderDetectiveMoneyBox();
		//		break;
		//	case 650:
		//		baseModule = new ChessGameArena();
		//		break;
		//	case 651:
		//		baseModule = new ChessGameActivity();
		//		break;
		//	case 652:
		//		baseModule = new KabutackAppointmentModule();
		//		break;
		//	case 653:
		//		baseModule = new TiejiaxiaobaoBattlePass();
		//		break;
		//	case 654:
		//		baseModule = new kaBuDaEvolveModule();
		//		break;
		//	case 655:
		//		baseModule = new shayulajiaoSellModule();
		//		break;
		//	case 656:
		//		baseModule = new WanziLongCellModule();
		//		break;
		//	case 657:
		//		baseModule = new KabutackSportsMeeting();
		//		break;
		//	case 658:
		//		baseModule = new peaceMedalMarkModule();
		//		break;
		//	case 660:
		//		baseModule = new ZhenShiQTLDModule();
		//		break;
		//	}
		//	if (baseModule == null)
		//	{
		//		foreach (IModuleClazzService moduleClazzService in ModuleClazzInfo.moduleClazzServices)
		//		{
		//			baseModule = moduleClazzService.getModuleIns(id);
		//			if (baseModule != null)
		//			{
		//				break;
		//			}
		//		}
		//	}
		//	return baseModule;
		//}

		// Token: 0x0400ED6E RID: 60782
		public static List<IModuleClazzService> moduleClazzServices = new List<IModuleClazzService>();
	}
}
