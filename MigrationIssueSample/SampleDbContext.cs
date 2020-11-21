using Microsoft.EntityFrameworkCore;
using MigrationIssueSample.Entities;

#nullable disable

namespace MigrationIssueSample
{
    public partial class SampleDbContext : DbContext
    {
        public SampleDbContext()
        {
        }

        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCh2> AccountCh2s { get; set; }
        public virtual DbSet<AdditionalBox> AdditionalBoxes { get; set; }
        public virtual DbSet<Agit> Agits { get; set; }
        public virtual DbSet<AgitAdena> AgitAdenas { get; set; }
        public virtual DbSet<AgitAuction> AgitAuctions { get; set; }
        public virtual DbSet<AgitBid> AgitBids { get; set; }
        public virtual DbSet<AgitDeco> AgitDecos { get; set; }
        public virtual DbSet<Alliance> Alliances { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<AuctionPayment> AuctionPayments { get; set; }
        public virtual DbSet<BannedAccount> BannedAccounts { get; set; }
        public virtual DbSet<BannedHardwareId> BannedHardwareIds { get; set; }
        public virtual DbSet<Bookmark> Bookmarks { get; set; }
        public virtual DbSet<BuilderAccount> BuilderAccounts { get; set; }
        public virtual DbSet<Castle> Castles { get; set; }
        public virtual DbSet<CastleCrop> CastleCrops { get; set; }
        public virtual DbSet<CastleTax> CastleTaxes { get; set; }
        public virtual DbSet<CastleWar> CastleWars { get; set; }
        public virtual DbSet<Ch2Temp> Ch2Temps { get; set; }
        public virtual DbSet<Ch3LottoChar> Ch3LottoChars { get; set; }
        public virtual DbSet<CharPet> CharPets { get; set; }
        public virtual DbSet<CharacterLock> CharacterLocks { get; set; }
        public virtual DbSet<ClassList> ClassLists { get; set; }
        public virtual DbSet<ControlTower> ControlTowers { get; set; }
        public virtual DbSet<DbnpcMaker> DbnpcMakers { get; set; }
        public virtual DbSet<Door> Doors { get; set; }
        public virtual DbSet<DtAdenaRankTemp> DtAdenaRankTemps { get; set; }
        public virtual DbSet<ErrItem1> ErrItem1s { get; set; }
        public virtual DbSet<ErrPet1928> ErrPet1928s { get; set; }
        public virtual DbSet<ErrPet1930> ErrPet1930s { get; set; }
        public virtual DbSet<ErrPet2928> ErrPet2928s { get; set; }
        public virtual DbSet<ErrPet2930> ErrPet2930s { get; set; }
        public virtual DbSet<ErrSkill1> ErrSkill1s { get; set; }
        public virtual DbSet<EventItem> EventItems { get; set; }
        public virtual DbSet<EventPoint> EventPoints { get; set; }
        public virtual DbSet<ItemAmount0Backup> ItemAmount0Backups { get; set; }
        public virtual DbSet<ItemClassidNormal> ItemClassidNormals { get; set; }
        public virtual DbSet<ItemDatum> ItemData { get; set; }
        public virtual DbSet<ItemDelivery> ItemDeliveries { get; set; }
        public virtual DbSet<ItemList> ItemLists { get; set; }
        public virtual DbSet<ItemMarketPrice> ItemMarketPrices { get; set; }
        public virtual DbSet<ItemTemp> ItemTemps { get; set; }
        public virtual DbSet<KillDeathStat> KillDeathStats { get; set; }
        public virtual DbSet<L2networkVote> L2networkVotes { get; set; }
        public virtual DbSet<LockedHardwareId> LockedHardwareIds { get; set; }
        public virtual DbSet<LoginAnnounce> LoginAnnounces { get; set; }
        public virtual DbSet<LottoGame> LottoGames { get; set; }
        public virtual DbSet<LottoGameBackup20050302> LottoGameBackup20050302s { get; set; }
        public virtual DbSet<LottoItem> LottoItems { get; set; }
        public virtual DbSet<ManorDataN> ManorDataNs { get; set; }
        public virtual DbSet<ManorDatum> ManorData { get; set; }
        public virtual DbSet<ManorFix> ManorFixes { get; set; }
        public virtual DbSet<ManorInfo> ManorInfos { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<Mercenary> Mercenaries { get; set; }
        public virtual DbSet<Monrace> Monraces { get; set; }
        public virtual DbSet<MonraceMon> MonraceMons { get; set; }
        public virtual DbSet<MonraceTicket> MonraceTickets { get; set; }
        public virtual DbSet<MultiSellLog> MultiSellLogs { get; set; }
        public virtual DbSet<NoblessAchievement> NoblessAchievements { get; set; }
        public virtual DbSet<NpcBoss> NpcBosses { get; set; }
        public virtual DbSet<NpcDeath> NpcDeaths { get; set; }
        public virtual DbSet<Npcname> Npcnames { get; set; }
        public virtual DbSet<ObjectDatum> ObjectData { get; set; }
        public virtual DbSet<OhecSubjob> OhecSubjobs { get; set; }
        public virtual DbSet<OhecSubjobTemp> OhecSubjobTemps { get; set; }
        public virtual DbSet<Olympiad> Olympiads { get; set; }
        public virtual DbSet<OlympiadMatch> OlympiadMatches { get; set; }
        public virtual DbSet<OlympiadResult> OlympiadResults { get; set; }
        public virtual DbSet<PetDatum> PetData { get; set; }
        public virtual DbSet<PetitionMsg> PetitionMsgs { get; set; }
        public virtual DbSet<Pledge> Pledges { get; set; }
        public virtual DbSet<PledgeAnnounce> PledgeAnnounces { get; set; }
        public virtual DbSet<PledgeContribution> PledgeContributions { get; set; }
        public virtual DbSet<PledgeCrest> PledgeCrests { get; set; }
        public virtual DbSet<PledgeExt> PledgeExts { get; set; }
        public virtual DbSet<PledgeSkill> PledgeSkills { get; set; }
        public virtual DbSet<PledgeSubpledge> PledgeSubpledges { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<PrivateStore> PrivateStores { get; set; }
        public virtual DbSet<Quest> Quests { get; set; }
        public virtual DbSet<QuestDatum> QuestData { get; set; }
        public virtual DbSet<ReqChar> ReqChars { get; set; }
        public virtual DbSet<ReqCharmove> ReqCharmoves { get; set; }
        public virtual DbSet<ReqCharmoveOld> ReqCharmoveOlds { get; set; }
        public virtual DbSet<ReqPledge> ReqPledges { get; set; }
        public virtual DbSet<ResidenceGuard> ResidenceGuards { get; set; }
        public virtual DbSet<ShortcutDatum> ShortcutData { get; set; }
        public virtual DbSet<SiegeAgitPledge> SiegeAgitPledges { get; set; }
        public virtual DbSet<SiegeStat> SiegeStats { get; set; }
        public virtual DbSet<SkillDatum> SkillData { get; set; }
        public virtual DbSet<SsqDatum> SsqData { get; set; }
        public virtual DbSet<SsqJoinDatum> SsqJoinData { get; set; }
        public virtual DbSet<SsqTopPointUser> SsqTopPointUsers { get; set; }
        public virtual DbSet<SsqUserDatum> SsqUserData { get; set; }
        public virtual DbSet<StatAccClass> StatAccClasses { get; set; }
        public virtual DbSet<StatAccLev> StatAccLevs { get; set; }
        public virtual DbSet<StatAccMlev> StatAccMlevs { get; set; }
        public virtual DbSet<StatAccRace> StatAccRaces { get; set; }
        public virtual DbSet<StatItemCnt> StatItemCnts { get; set; }
        public virtual DbSet<StatItemEnt> StatItemEnts { get; set; }
        public virtual DbSet<StatItemMent> StatItemMents { get; set; }
        public virtual DbSet<StatItemMincnt> StatItemMincnts { get; set; }
        public virtual DbSet<SubStack> SubStacks { get; set; }
        public virtual DbSet<TeamBattleAgitMember> TeamBattleAgitMembers { get; set; }
        public virtual DbSet<TeamBattleAgitPledge> TeamBattleAgitPledges { get; set; }
        public virtual DbSet<TempAccount> TempAccounts { get; set; }
        public virtual DbSet<TempInv> TempInvs { get; set; }
        public virtual DbSet<TempPetInv> TempPetInvs { get; set; }
        public virtual DbSet<TempRecipe> TempRecipes { get; set; }
        public virtual DbSet<TempSkill> TempSkills { get; set; }
        public virtual DbSet<TempSkill2> TempSkill2s { get; set; }
        public virtual DbSet<TempUpdate> TempUpdates { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TimeAttackRecord> TimeAttackRecords { get; set; }
        public virtual DbSet<TimeAttackRecordTest> TimeAttackRecordTests { get; set; }
        public virtual DbSet<TimeDatum> TimeData { get; set; }
        public virtual DbSet<TmpAlliance> TmpAlliances { get; set; }
        public virtual DbSet<TmpDieUser> TmpDieUsers { get; set; }
        public virtual DbSet<TmpLottoPriceGiven> TmpLottoPriceGivens { get; set; }
        public virtual DbSet<TmpPledge> TmpPledges { get; set; }
        public virtual DbSet<TmpRecoverUser> TmpRecoverUsers { get; set; }
        public virtual DbSet<TmpSeedDp> TmpSeedDps { get; set; }
        public virtual DbSet<TmpUserDatum> TmpUserData { get; set; }
        public virtual DbSet<TmpUserItem> TmpUserItems { get; set; }
        public virtual DbSet<TmpUserNobless> TmpUserNoblesses { get; set; }
        public virtual DbSet<UserActiveSkill> UserActiveSkills { get; set; }
        public virtual DbSet<UserBan> UserBans { get; set; }
        public virtual DbSet<UserBlocklist> UserBlocklists { get; set; }
        public virtual DbSet<UserComment> UserComments { get; set; }
        public virtual DbSet<UserDataMoved> UserDataMoveds { get; set; }
        public virtual DbSet<UserDataTemp> UserDataTemps { get; set; }
        public virtual DbSet<UserDatum> UserData { get; set; }
        public virtual DbSet<UserDeleted> UserDeleteds { get; set; }
        public virtual DbSet<UserFriend> UserFriends { get; set; }
        public virtual DbSet<UserHenna> UserHennas { get; set; }
        public virtual DbSet<UserHistory> UserHistories { get; set; }
        public virtual DbSet<UserInstance> UserInstances { get; set; }
        public virtual DbSet<UserItem> UserItems { get; set; }
        public virtual DbSet<UserJournal> UserJournals { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<UserMacro> UserMacros { get; set; }
        public virtual DbSet<UserMacroinfo> UserMacroinfos { get; set; }
        public virtual DbSet<UserMail> UserMails { get; set; }
        public virtual DbSet<UserMailReceiver> UserMailReceivers { get; set; }
        public virtual DbSet<UserMailSender> UserMailSenders { get; set; }
        public virtual DbSet<UserNameColor> UserNameColors { get; set; }
        public virtual DbSet<UserNameReserved> UserNameReserveds { get; set; }
        public virtual DbSet<UserNewbie> UserNewbies { get; set; }
        public virtual DbSet<UserNobless> UserNoblesses { get; set; }
        public virtual DbSet<UserPin> UserPins { get; set; }
        public virtual DbSet<UserProhibit> UserProhibits { get; set; }
        public virtual DbSet<UserProhibitWord> UserProhibitWords { get; set; }
        public virtual DbSet<UserPunish> UserPunishes { get; set; }
        public virtual DbSet<UserRebirth> UserRebirths { get; set; }
        public virtual DbSet<UserRecipe> UserRecipes { get; set; }
        public virtual DbSet<UserSchemeBuffer> UserSchemeBuffers { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }
        public virtual DbSet<UserSkillOld> UserSkillOlds { get; set; }
        public virtual DbSet<UserSociality> UserSocialities { get; set; }
        public virtual DbSet<UserSubjob> UserSubjobs { get; set; }
        public virtual DbSet<UserSurrender> UserSurrenders { get; set; }
        public virtual DbSet<UserVote> UserVotes { get; set; }
        public virtual DbSet<UserWarehouse> UserWarehouses { get; set; }
        public virtual DbSet<UserWedding> UserWeddings { get; set; }
        public virtual DbSet<WarDeclare> WarDeclares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCh2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("account_ch2");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<AdditionalBox>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AdditionalBox");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Agit>(entity =>
            {
                entity.ToTable("agit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AuctionDate)
                    .HasColumnName("auction_date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuctionId).HasColumnName("auction_id");

                entity.Property(e => e.AuctionPrice)
                    .HasColumnName("auction_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostFail).HasColumnName("cost_fail");

                entity.Property(e => e.Hatcher)
                    .HasColumnName("hatcher")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HpStove)
                    .HasColumnName("hp_stove")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HpStoveExpire)
                    .HasColumnName("hp_stove_expire")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastCancel).HasColumnName("last_cancel");

                entity.Property(e => e.LastPrice).HasColumnName("last_price");

                entity.Property(e => e.MpFlame)
                    .HasColumnName("mp_flame")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MpFlameExpire)
                    .HasColumnName("mp_flame_expire")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NextCost).HasColumnName("next_cost");

                entity.Property(e => e.NextWarTime)
                    .HasColumnName("next_war_time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PledgeId)
                    .HasColumnName("pledge_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopIncome).HasColumnName("shop_income");

                entity.Property(e => e.ShopIncomeTemp).HasColumnName("shop_income_temp");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.TaxChildRate).HasColumnName("tax_child_rate");

                entity.Property(e => e.TaxChildRateToChange)
                    .HasColumnName("tax_child_rate_to_change")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TaxRate).HasColumnName("tax_rate");

                entity.Property(e => e.TaxRateToChange)
                    .HasColumnName("tax_rate_to_change")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TeamBattleStatus).HasColumnName("team_battle_status");

                entity.Property(e => e.TeleportExpire)
                    .HasColumnName("teleport_expire")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeleportLevel)
                    .HasColumnName("teleport_level")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AgitAdena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agit_adena");

                entity.HasIndex(e => new { e.PledgeId, e.AuctionId, e.Reason }, "IX_agit_adena");

                entity.Property(e => e.Adena).HasColumnName("adena");

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.AuctionId).HasColumnName("auction_id");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("log_id");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.Reason).HasColumnName("reason");
            });

            modelBuilder.Entity<AgitAuction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agit_auction");

                entity.HasIndex(e => new { e.AgitId, e.AuctionTime }, "IX_agit_auction_1");

                entity.HasIndex(e => e.AuctionId, "IX_agit_auction_2");

                entity.Property(e => e.AcceptedBid).HasColumnName("accepted_bid");

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.AuctionDesc)
                    .HasMaxLength(200)
                    .HasColumnName("auction_desc")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.AuctionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("auction_id");

                entity.Property(e => e.AuctionTax).HasColumnName("auction_tax");

                entity.Property(e => e.AuctionTime).HasColumnName("auction_time");

                entity.Property(e => e.MinPrice).HasColumnName("min_price");
            });

            modelBuilder.Entity<AgitBid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agit_bid");

                entity.HasIndex(e => e.AuctionId, "IX_agit_auction");

                entity.HasIndex(e => new { e.AuctionId, e.AttendPledgeId }, "IX_agit_bid")
                    .IsUnique();

                entity.HasIndex(e => new { e.AttendPrice, e.AttendDate }, "IX_agit_price");

                entity.Property(e => e.AttendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("attend_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttendId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("attend_id");

                entity.Property(e => e.AttendPledgeId).HasColumnName("attend_pledge_id");

                entity.Property(e => e.AttendPrice).HasColumnName("attend_price");

                entity.Property(e => e.AttendTime).HasColumnName("attend_time");

                entity.Property(e => e.AuctionId).HasColumnName("auction_id");
            });

            modelBuilder.Entity<AgitDeco>(entity =>
            {
                entity.HasKey(e => new { e.AgitId, e.Type });

                entity.ToTable("agit_deco");

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Expire).HasColumnName("expire");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<Alliance>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Alliance");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CrestId).HasColumnName("crest_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MasterPledgeId).HasColumnName("master_pledge_id");

                entity.Property(e => e.OustTime).HasColumnName("oust_time");
            });

            modelBuilder.Entity<Auction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Auction");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AuctionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("auction_id");

                entity.Property(e => e.Augmentation).HasColumnName("augmentation");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.ExpireTime).HasColumnName("expire_time");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.SellerName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("seller_name")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AuctionPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuctionPayment");

                entity.Property(e => e.Buyer)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("buyer")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.ItemAmount).HasColumnName("item_amount");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.JobId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("job_id");

                entity.Property(e => e.PriceAmount).HasColumnName("price_amount");

                entity.Property(e => e.PriceId).HasColumnName("price_id");
            });

            modelBuilder.Entity<BannedAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("banned_account");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<BannedHardwareId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BannedHardwareId");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("account")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("gm")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HardwareId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("hardware_id")
                    .HasDefaultValueSql("(N'00000000000000000000000000000000')");

                entity.Property(e => e.Timeout).HasColumnName("timeout");
            });

            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookmark");

                entity.HasIndex(e => e.CharId, "ix_bookmark")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Bookmarkid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("bookmarkid");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.World).HasColumnName("world");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<BuilderAccount>(entity =>
            {
                entity.HasKey(e => e.AccountName)
                    .HasName("PK_account_builder");

                entity.ToTable("builder_account");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.DefaultBuilder).HasColumnName("default_builder");
            });

            modelBuilder.Entity<Castle>(entity =>
            {
                entity.ToTable("castle");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CropIncome).HasColumnName("crop_income");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NextWarTime).HasColumnName("next_war_time");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ShopIncome).HasColumnName("shop_income");

                entity.Property(e => e.ShopIncomeTemp).HasColumnName("shop_income_temp");

                entity.Property(e => e.SiegeElapsedTime).HasColumnName("siege_elapsed_time");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaxChildRate).HasColumnName("tax_child_rate");

                entity.Property(e => e.TaxChildRateToChange)
                    .HasColumnName("tax_child_rate_to_change")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TaxRate).HasColumnName("tax_rate");

                entity.Property(e => e.TaxRateToChange)
                    .HasColumnName("tax_rate_to_change")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CastleCrop>(entity =>
            {
                entity.HasKey(e => new { e.CastleId, e.ItemType });

                entity.ToTable("castle_crop");

                entity.Property(e => e.CastleId).HasColumnName("castle_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.DropRate).HasColumnName("dropRate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<CastleTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("castle_tax");

                entity.Property(e => e.IncomeUpdateT).HasColumnName("income_update_t");

                entity.Property(e => e.ManorResetT).HasColumnName("manor_reset_t");

                entity.Property(e => e.TaxChangeT).HasColumnName("tax_change_t");
            });

            modelBuilder.Entity<CastleWar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("castle_war");

                entity.Property(e => e.CastleId).HasColumnName("castle_id");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ProposeTime)
                    .HasColumnName("propose_time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Ch2Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ch2_temp");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login");

                entity.Property(e => e.LastWorld).HasColumnName("last_world");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<Ch3LottoChar>(entity =>
            {
                entity.HasKey(e => e.CharId)
                    .HasName("PK__ch3_lott__2D4B2339B4154CAD");

                entity.ToTable("ch3_lotto_char");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.ItemCount).HasColumnName("item_count");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.NumberFlag).HasColumnName("number_flag");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");
            });

            modelBuilder.Entity<CharPet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("char_pet");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.PetId).HasColumnName("pet_id");
            });

            modelBuilder.Entity<CharacterLock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CharacterLock");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CodeHash)
                    .IsRequired()
                    .HasMaxLength(33)
                    .HasColumnName("code_hash")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HardwareId)
                    .IsRequired()
                    .HasMaxLength(33)
                    .HasColumnName("hardware_id")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ClassList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("class_list");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Race).HasColumnName("race");
            });

            modelBuilder.Entity<ControlTower>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__control___72E12F1A05A8BA76");

                entity.ToTable("control_tower");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.ControlLevel)
                    .HasColumnName("control_level")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<DbnpcMaker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DBNpcMaker");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasDefaultValueSql("(datediff(second,'1970-01-01 00:00:00',getutcdate())+(2592000))");

                entity.Property(e => e.Heading).HasColumnName("heading");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NpcId).HasColumnName("npc_id");

                entity.Property(e => e.SpawnX).HasColumnName("spawn_x");

                entity.Property(e => e.SpawnY).HasColumnName("spawn_y");

                entity.Property(e => e.SpawnZ).HasColumnName("spawn_z");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasDefaultValueSql("(datediff(second,'1970-01-01 00:00:00',getutcdate()))");
            });

            modelBuilder.Entity<Door>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("door");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");
            });

            modelBuilder.Entity<DtAdenaRankTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dt_adena_rank_temp");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Rank)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rank");
            });

            modelBuilder.Entity<ErrItem1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_item_1");

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.EtcNum5).HasColumnName("etc_num5");

                entity.Property(e => e.StrActor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("str_actor")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<ErrPet1928>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_pet1_9_28");

                entity.Property(e => e.ActTime)
                    .HasColumnType("datetime")
                    .HasColumnName("act_time");

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.ActorAccount).HasColumnName("actor_account");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.EtcNum1).HasColumnName("etc_num1");

                entity.Property(e => e.EtcNum10).HasColumnName("etc_num10");

                entity.Property(e => e.EtcNum2).HasColumnName("etc_num2");

                entity.Property(e => e.EtcNum3).HasColumnName("etc_num3");

                entity.Property(e => e.EtcNum4).HasColumnName("etc_num4");

                entity.Property(e => e.EtcNum5).HasColumnName("etc_num5");

                entity.Property(e => e.EtcNum6).HasColumnName("etc_num6");

                entity.Property(e => e.EtcNum7).HasColumnName("etc_num7");

                entity.Property(e => e.EtcNum8).HasColumnName("etc_num8");

                entity.Property(e => e.EtcNum9).HasColumnName("etc_num9");

                entity.Property(e => e.EtcStr1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("etc_str1")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str2")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str3")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.StrActor)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrActorAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTarget)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_target")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTargetAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_target_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.TargetAccount).HasColumnName("target_account");

                entity.Property(e => e.Uiid).HasColumnName("uiid");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<ErrPet1930>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_pet1_9_30");

                entity.Property(e => e.ActTime)
                    .HasColumnType("datetime")
                    .HasColumnName("act_time");

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.ActorAccount).HasColumnName("actor_account");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.EtcNum1).HasColumnName("etc_num1");

                entity.Property(e => e.EtcNum10).HasColumnName("etc_num10");

                entity.Property(e => e.EtcNum2).HasColumnName("etc_num2");

                entity.Property(e => e.EtcNum3).HasColumnName("etc_num3");

                entity.Property(e => e.EtcNum4).HasColumnName("etc_num4");

                entity.Property(e => e.EtcNum5).HasColumnName("etc_num5");

                entity.Property(e => e.EtcNum6).HasColumnName("etc_num6");

                entity.Property(e => e.EtcNum7).HasColumnName("etc_num7");

                entity.Property(e => e.EtcNum8).HasColumnName("etc_num8");

                entity.Property(e => e.EtcNum9).HasColumnName("etc_num9");

                entity.Property(e => e.EtcStr1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("etc_str1")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str2")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str3")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.StrActor)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrActorAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTarget)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_target")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTargetAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_target_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.TargetAccount).HasColumnName("target_account");

                entity.Property(e => e.Uiid).HasColumnName("uiid");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<ErrPet2928>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_pet2_9_28");

                entity.Property(e => e.ActTime)
                    .HasColumnType("datetime")
                    .HasColumnName("act_time");

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.ActorAccount).HasColumnName("actor_account");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.EtcNum1).HasColumnName("etc_num1");

                entity.Property(e => e.EtcNum10).HasColumnName("etc_num10");

                entity.Property(e => e.EtcNum2).HasColumnName("etc_num2");

                entity.Property(e => e.EtcNum3).HasColumnName("etc_num3");

                entity.Property(e => e.EtcNum4).HasColumnName("etc_num4");

                entity.Property(e => e.EtcNum5).HasColumnName("etc_num5");

                entity.Property(e => e.EtcNum6).HasColumnName("etc_num6");

                entity.Property(e => e.EtcNum7).HasColumnName("etc_num7");

                entity.Property(e => e.EtcNum8).HasColumnName("etc_num8");

                entity.Property(e => e.EtcNum9).HasColumnName("etc_num9");

                entity.Property(e => e.EtcStr1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("etc_str1")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str2")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str3")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.StrActor)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrActorAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTarget)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_target")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTargetAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_target_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.TargetAccount).HasColumnName("target_account");

                entity.Property(e => e.Uiid).HasColumnName("uiid");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<ErrPet2930>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_pet2_9_30");

                entity.Property(e => e.ActTime)
                    .HasColumnType("datetime")
                    .HasColumnName("act_time");

                entity.Property(e => e.Actor).HasColumnName("actor");

                entity.Property(e => e.ActorAccount).HasColumnName("actor_account");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.EtcNum1).HasColumnName("etc_num1");

                entity.Property(e => e.EtcNum10).HasColumnName("etc_num10");

                entity.Property(e => e.EtcNum2).HasColumnName("etc_num2");

                entity.Property(e => e.EtcNum3).HasColumnName("etc_num3");

                entity.Property(e => e.EtcNum4).HasColumnName("etc_num4");

                entity.Property(e => e.EtcNum5).HasColumnName("etc_num5");

                entity.Property(e => e.EtcNum6).HasColumnName("etc_num6");

                entity.Property(e => e.EtcNum7).HasColumnName("etc_num7");

                entity.Property(e => e.EtcNum8).HasColumnName("etc_num8");

                entity.Property(e => e.EtcNum9).HasColumnName("etc_num9");

                entity.Property(e => e.EtcStr1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("etc_str1")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str2")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.EtcStr3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("etc_str3")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.StrActor)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrActorAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_actor_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTarget)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("STR_target")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.StrTargetAccount)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("STR_target_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.TargetAccount).HasColumnName("target_account");

                entity.Property(e => e.Uiid).HasColumnName("uiid");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<ErrSkill1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("err_skill_1");

                entity.HasIndex(e => new { e.Class, e.Lev }, "IX_err_table2");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .HasColumnName("class_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(255)
                    .HasColumnName("skill_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<EventItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("event_items");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EventPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("event_point");

                entity.HasIndex(e => e.GroupId, "IX_event_point")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupPoint)
                    .HasColumnName("group_point")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.PointId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("point_id");
            });

            modelBuilder.Entity<ItemAmount0Backup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_amount0_backup");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<ItemClassidNormal>(entity =>
            {
                entity.ToTable("item_classid_normal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ItemDatum>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Consumetype }, "IX_ItemData")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Name, "idx_itemdata_name")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Consumetype)
                    .HasMaxLength(50)
                    .HasColumnName("consumetype")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("desc")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Logdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("logdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<ItemDelivery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemDelivery");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.ItemAmount).HasColumnName("item_amount");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.JobId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("job_id");
            });

            modelBuilder.Entity<ItemList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<ItemMarketPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_market_price");

                entity.Property(e => e.AvgPrice).HasColumnName("avg_price");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.ItemType).HasColumnName("item_type");
            });

            modelBuilder.Entity<ItemTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_temp");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");
            });

            modelBuilder.Entity<KillDeathStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KillDeathStat");

                entity.Property(e => e.DeathTime).HasColumnName("death_time");

                entity.Property(e => e.KillerClassId).HasColumnName("killer_class_id");

                entity.Property(e => e.KillerCp).HasColumnName("killer_cp");

                entity.Property(e => e.KillerHp).HasColumnName("killer_hp");

                entity.Property(e => e.KillerId).HasColumnName("killer_id");

                entity.Property(e => e.KillerLevel).HasColumnName("killer_level");

                entity.Property(e => e.KillerMaxCp).HasColumnName("killer_max_cp");

                entity.Property(e => e.KillerMaxHp).HasColumnName("killer_max_hp");

                entity.Property(e => e.Pvp).HasColumnName("pvp");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.Property(e => e.VictimClassId).HasColumnName("victim_class_id");

                entity.Property(e => e.VictimId).HasColumnName("victim_id");

                entity.Property(e => e.VictimLevel).HasColumnName("victim_level");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<L2networkVote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("L2NetworkVote");

                entity.Property(e => e.Identity)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("identity")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastRewardTime).HasColumnName("last_reward_time");

                entity.Property(e => e.LastVoteTime).HasColumnName("last_vote_time");
            });

            modelBuilder.Entity<LockedHardwareId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LockedHardwareId");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.HardwareId)
                    .IsRequired()
                    .HasMaxLength(33)
                    .HasColumnName("hardware_id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LockedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("locked_by")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<LoginAnnounce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("login_announce");

                entity.Property(e => e.AnnounceId).HasColumnName("announce_id");

                entity.Property(e => e.AnnounceMsg)
                    .HasMaxLength(256)
                    .HasColumnName("announce_msg")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Interval10).HasColumnName("interval_10");
            });

            modelBuilder.Entity<LottoGame>(entity =>
            {
                entity.HasKey(e => e.RoundNumber);

                entity.ToTable("lotto_game");

                entity.Property(e => e.RoundNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("round_number");

                entity.Property(e => e.CarriedAdena).HasColumnName("carried_adena");

                entity.Property(e => e.ChosenNumberFlag).HasColumnName("chosen_number_flag");

                entity.Property(e => e.LeftTime).HasColumnName("left_time");

                entity.Property(e => e.RuleNumber).HasColumnName("rule_number");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TotalCount).HasColumnName("total_count");

                entity.Property(e => e.Winner1Count).HasColumnName("winner1_count");

                entity.Property(e => e.Winner2Count).HasColumnName("winner2_count");

                entity.Property(e => e.Winner3Count).HasColumnName("winner3_count");

                entity.Property(e => e.Winner4Count).HasColumnName("winner4_count");
            });

            modelBuilder.Entity<LottoGameBackup20050302>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lotto_game_backup_20050302");

                entity.Property(e => e.CarriedAdena).HasColumnName("carried_adena");

                entity.Property(e => e.ChosenNumberFlag).HasColumnName("chosen_number_flag");

                entity.Property(e => e.LeftTime).HasColumnName("left_time");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");

                entity.Property(e => e.RuleNumber).HasColumnName("rule_number");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TotalCount).HasColumnName("total_count");

                entity.Property(e => e.Winner1Count).HasColumnName("winner1_count");

                entity.Property(e => e.Winner2Count).HasColumnName("winner2_count");

                entity.Property(e => e.Winner3Count).HasColumnName("winner3_count");

                entity.Property(e => e.Winner4Count).HasColumnName("winner4_count");
            });

            modelBuilder.Entity<LottoItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lotto_items");

                entity.HasIndex(e => e.RoundNumber, "IX_lotto_items")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.NumberFlag).HasColumnName("number_flag");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");
            });

            modelBuilder.Entity<ManorDataN>(entity =>
            {
                entity.HasKey(e => new { e.ManorId, e.DataIndex });

                entity.ToTable("manor_data_n");

                entity.Property(e => e.ManorId).HasColumnName("manor_id");

                entity.Property(e => e.DataIndex).HasColumnName("data_index");

                entity.Property(e => e.CropBuyCountN).HasColumnName("crop_buy_count_n");

                entity.Property(e => e.CropIdN).HasColumnName("crop_id_n");

                entity.Property(e => e.CropPriceN).HasColumnName("crop_price_n");

                entity.Property(e => e.CropTypeN).HasColumnName("crop_type_n");

                entity.Property(e => e.SeedIdN).HasColumnName("seed_id_n");

                entity.Property(e => e.SeedPriceN).HasColumnName("seed_price_n");

                entity.Property(e => e.SeedSellCountN).HasColumnName("seed_sell_count_n");
            });

            modelBuilder.Entity<ManorDatum>(entity =>
            {
                entity.HasKey(e => new { e.ManorId, e.DataIndex });

                entity.ToTable("manor_data");

                entity.Property(e => e.ManorId).HasColumnName("manor_id");

                entity.Property(e => e.DataIndex).HasColumnName("data_index");

                entity.Property(e => e.CropBuyCount).HasColumnName("crop_buy_count");

                entity.Property(e => e.CropDeposit).HasColumnName("crop_deposit");

                entity.Property(e => e.CropId).HasColumnName("crop_id");

                entity.Property(e => e.CropPrice).HasColumnName("crop_price");

                entity.Property(e => e.CropRemainCount).HasColumnName("crop_remain_count");

                entity.Property(e => e.CropType).HasColumnName("crop_type");

                entity.Property(e => e.SeedId).HasColumnName("seed_id");

                entity.Property(e => e.SeedPrice).HasColumnName("seed_price");

                entity.Property(e => e.SeedRemainCount).HasColumnName("seed_remain_count");

                entity.Property(e => e.SeedSellCount).HasColumnName("seed_sell_count");
            });

            modelBuilder.Entity<ManorFix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("manor_fix");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.ErrorAmount).HasColumnName("error_amount");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.ToDec).HasColumnName("to_dec");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");
            });

            modelBuilder.Entity<ManorInfo>(entity =>
            {
                entity.HasKey(e => e.ManorId);

                entity.ToTable("manor_info");

                entity.Property(e => e.ManorId)
                    .ValueGeneratedNever()
                    .HasColumnName("manor_id");

                entity.Property(e => e.AdenaVault).HasColumnName("adena_vault");

                entity.Property(e => e.ChangeState).HasColumnName("change_state");

                entity.Property(e => e.CropBuyVault).HasColumnName("crop_buy_vault");

                entity.Property(e => e.LastChangedT).HasColumnName("last_changed_t");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("map");

                entity.Property(e => e.Map2).HasColumnName("map2");

                entity.Property(e => e.X2).HasColumnName("x2");

                entity.Property(e => e.Y2).HasColumnName("y2");
            });

            modelBuilder.Entity<Mercenary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mercenary");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mp).HasColumnName("mp");

                entity.Property(e => e.NpcId).HasColumnName("npc_id");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<Monrace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("monrace");

                entity.HasIndex(e => e.RaceId, "IX_monrace")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Lane1).HasColumnName("lane1");

                entity.Property(e => e.Lane2).HasColumnName("lane2");

                entity.Property(e => e.Lane3).HasColumnName("lane3");

                entity.Property(e => e.Lane4).HasColumnName("lane4");

                entity.Property(e => e.Lane5).HasColumnName("lane5");

                entity.Property(e => e.Lane6).HasColumnName("lane6");

                entity.Property(e => e.Lane7).HasColumnName("lane7");

                entity.Property(e => e.Lane8).HasColumnName("lane8");

                entity.Property(e => e.MakeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("make_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RaceEnd)
                    .HasColumnName("race_end")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RaceId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("race_id");

                entity.Property(e => e.Run1).HasColumnName("run1");

                entity.Property(e => e.Run2).HasColumnName("run2");

                entity.Property(e => e.Run3).HasColumnName("run3");

                entity.Property(e => e.Run4).HasColumnName("run4");

                entity.Property(e => e.Run5).HasColumnName("run5");

                entity.Property(e => e.Run6).HasColumnName("run6");

                entity.Property(e => e.Run7).HasColumnName("run7");

                entity.Property(e => e.Run8).HasColumnName("run8");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Win1)
                    .HasColumnName("win1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Win2)
                    .HasColumnName("win2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Winrate1)
                    .HasColumnName("winrate1")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Winrate2)
                    .HasColumnName("winrate2")
                    .HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<MonraceMon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("monrace_mon");

                entity.Property(e => e.InitialWin)
                    .HasColumnName("initial_win")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RunCount)
                    .HasColumnName("run_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RunnerId).HasColumnName("runner_id");

                entity.Property(e => e.WinCount)
                    .HasColumnName("win_count")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MonraceTicket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("monrace_ticket");

                entity.HasIndex(e => e.ItemId, "IX_monrace_ticket")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Monraceid, e.BetType, e.Bet1, e.Bet2 }, "IX_monrace_ticket_1")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Bet1)
                    .HasColumnName("bet_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bet2)
                    .HasColumnName("bet_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bet3).HasColumnName("bet_3");

                entity.Property(e => e.BetMoney).HasColumnName("bet_money");

                entity.Property(e => e.BetType)
                    .HasColumnName("bet_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Monraceid).HasColumnName("monraceid");

                entity.Property(e => e.Remotefee).HasColumnName("remotefee");

                entity.Property(e => e.TaxMoney)
                    .HasColumnName("tax_money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TicketId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ticket_id");
            });

            modelBuilder.Entity<MultiSellLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MultiSell_Log");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("account_name");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .HasColumnName("char_name");

                entity.Property(e => e.Price1Count).HasColumnName("price1_count");

                entity.Property(e => e.Price1Id).HasColumnName("price1_id");

                entity.Property(e => e.Price2Count).HasColumnName("price2_count");

                entity.Property(e => e.Price2Id).HasColumnName("price2_id");

                entity.Property(e => e.Price3Count).HasColumnName("price3_count");

                entity.Property(e => e.Price3Id).HasColumnName("price3_id");

                entity.Property(e => e.Price4Count).HasColumnName("price4_count");

                entity.Property(e => e.Price4Id).HasColumnName("price4_id");

                entity.Property(e => e.Price5Count).HasColumnName("price5_count");

                entity.Property(e => e.Price5Id).HasColumnName("price5_id");

                entity.Property(e => e.Reward1Count).HasColumnName("reward1_count");

                entity.Property(e => e.Reward1Id).HasColumnName("reward1_id");

                entity.Property(e => e.Reward2Count).HasColumnName("reward2_count");

                entity.Property(e => e.Reward2Id).HasColumnName("reward2_id");

                entity.Property(e => e.Reward3Count).HasColumnName("reward3_count");

                entity.Property(e => e.Reward3Id).HasColumnName("reward3_id");

                entity.Property(e => e.Reward4Count).HasColumnName("reward4_count");

                entity.Property(e => e.Reward4Id).HasColumnName("reward4_id");

                entity.Property(e => e.Reward5Count).HasColumnName("reward5_count");

                entity.Property(e => e.Reward5Id).HasColumnName("reward5_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<NoblessAchievement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nobless_achievements");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Target).HasColumnName("target");

                entity.Property(e => e.WinTime).HasColumnName("win_time");

                entity.Property(e => e.WinType).HasColumnName("win_type");
            });

            modelBuilder.Entity<NpcBoss>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("npc_boss");

                entity.HasIndex(e => e.NpcDbName, "idx_npc_boss_unique_name")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Alive).HasColumnName("alive");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.I0).HasColumnName("i0");

                entity.Property(e => e.Mp).HasColumnName("mp");

                entity.Property(e => e.NpcDbName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("npc_db_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.PosZ).HasColumnName("pos_z");

                entity.Property(e => e.TimeHigh).HasColumnName("time_high");

                entity.Property(e => e.TimeLow).HasColumnName("time_low");
            });

            modelBuilder.Entity<NpcDeath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NpcDeath");

                entity.Property(e => e.DeathTime).HasColumnName("death_time");

                entity.Property(e => e.NpcClassId).HasColumnName("npc_class_id");
            });

            modelBuilder.Entity<Npcname>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("npcname");

                entity.Property(e => e.NpcId).HasColumnName("npc_id");

                entity.Property(e => e.NpcName1)
                    .HasMaxLength(50)
                    .HasColumnName("npc_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<ObjectDatum>(entity =>
            {
                entity.ToTable("object_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.XPos).HasColumnName("x_pos");

                entity.Property(e => e.YPos).HasColumnName("y_pos");

                entity.Property(e => e.ZPos).HasColumnName("z_pos");
            });

            modelBuilder.Entity<OhecSubjob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHEC_SUBJOB");

                entity.Property(e => e.All75).HasColumnName("All_75");

                entity.Property(e => e.Server).HasColumnName("server");
            });

            modelBuilder.Entity<OhecSubjobTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHEC_SUBJOB_TEMP");

                entity.Property(e => e.All75).HasColumnName("All_75");

                entity.Property(e => e.Server).HasColumnName("server");
            });

            modelBuilder.Entity<Olympiad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("olympiad");

                entity.Property(e => e.Bonus1Sec).HasColumnName("bonus1_sec");

                entity.Property(e => e.Bonus2Sec).HasColumnName("bonus2_sec");

                entity.Property(e => e.Bonus3Sec).HasColumnName("bonus3_sec");

                entity.Property(e => e.Bonus4Sec).HasColumnName("bonus4_sec");

                entity.Property(e => e.NominateSec).HasColumnName("nominate_sec");

                entity.Property(e => e.Season)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("season");

                entity.Property(e => e.SeasonStartTime).HasColumnName("season_start_time");

                entity.Property(e => e.StartSec).HasColumnName("start_sec");

                entity.Property(e => e.Step).HasColumnName("step");
            });

            modelBuilder.Entity<OlympiadMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("olympiad_match");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.IsWinner).HasColumnName("is_winner");

                entity.Property(e => e.MatchTime).HasColumnName("match_time");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.RivalId).HasColumnName("rival_id");

                entity.Property(e => e.Season).HasColumnName("season");
            });

            modelBuilder.Entity<OlympiadResult>(entity =>
            {
                entity.HasKey(e => new { e.Season, e.Class, e.CharId });

                entity.ToTable("olympiad_result");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.MatchCount).HasColumnName("match_count");

                entity.Property(e => e.Point).HasColumnName("point");
            });

            modelBuilder.Entity<PetDatum>(entity =>
            {
                entity.HasKey(e => e.PetId);

                entity.ToTable("pet_data");

                entity.Property(e => e.PetId)
                    .ValueGeneratedNever()
                    .HasColumnName("pet_id");

                entity.Property(e => e.Expoint).HasColumnName("expoint");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Meal)
                    .HasColumnName("meal")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mp).HasColumnName("mp");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .HasColumnName("nick_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NpcClassId).HasColumnName("npc_class_id");

                entity.Property(e => e.Slot1).HasColumnName("slot1");

                entity.Property(e => e.Slot2).HasColumnName("slot2");

                entity.Property(e => e.Sp).HasColumnName("sp");
            });

            modelBuilder.Entity<PetitionMsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PetitionMsg");

                entity.HasIndex(e => e.CharId, "idx_petmsg_charid")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("Char_Id");

                entity.Property(e => e.Msg)
                    .HasMaxLength(1024)
                    .HasColumnName("msg")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<Pledge>(entity =>
            {
                entity.ToTable("Pledge");

                entity.HasIndex(e => e.Name, "IX_Pledge")
                    .IsUnique();

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.AllianceDismissTime).HasColumnName("alliance_dismiss_time");

                entity.Property(e => e.AllianceId).HasColumnName("alliance_id");

                entity.Property(e => e.AllianceOustedTime).HasColumnName("alliance_ousted_time");

                entity.Property(e => e.AllianceWithdrawTime).HasColumnName("alliance_withdraw_time");

                entity.Property(e => e.CastleId).HasColumnName("castle_id");

                entity.Property(e => e.ChallengeTime).HasColumnName("challenge_time");

                entity.Property(e => e.CrestId).HasColumnName("crest_id");

                entity.Property(e => e.DelegateClid)
                    .HasColumnName("delegate_clid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DismissReservedTime).HasColumnName("dismiss_reserved_time");

                entity.Property(e => e.EmblemId).HasColumnName("emblem_id");

                entity.Property(e => e.IsGuilty).HasColumnName("is_guilty");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NameValue).HasColumnName("name_value");

                entity.Property(e => e.NowWarId).HasColumnName("now_war_id");

                entity.Property(e => e.OustTime).HasColumnName("oust_time");

                entity.Property(e => e.PrivateFlag).HasColumnName("private_flag");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.RootNameValue).HasColumnName("root_name_value");

                entity.Property(e => e.RulerId).HasColumnName("ruler_id");

                entity.Property(e => e.SiegeDeath).HasColumnName("siege_death");

                entity.Property(e => e.SiegeKill).HasColumnName("siege_kill");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<PledgeAnnounce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pledge_announce");

                entity.Property(e => e.Content)
                    .HasMaxLength(3000)
                    .HasColumnName("content")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ShowFlag).HasColumnName("show_flag");
            });

            modelBuilder.Entity<PledgeContribution>(entity =>
            {
                entity.HasKey(e => new { e.ResidenceId, e.PledgeId });

                entity.ToTable("pledge_contribution");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.Contribution).HasColumnName("contribution");
            });

            modelBuilder.Entity<PledgeCrest>(entity =>
            {
                entity.HasKey(e => e.CrestId);

                entity.ToTable("Pledge_Crest");

                entity.Property(e => e.CrestId).HasColumnName("crest_id");

                entity.Property(e => e.Bitmap)
                    .HasMaxLength(3072)
                    .HasColumnName("bitmap");

                entity.Property(e => e.BitmapSize).HasColumnName("bitmap_size");
            });

            modelBuilder.Entity<PledgeExt>(entity =>
            {
                entity.HasKey(e => e.PledgeId);

                entity.ToTable("pledge_ext");

                entity.Property(e => e.PledgeId)
                    .ValueGeneratedNever()
                    .HasColumnName("pledge_id");

                entity.Property(e => e.ReputationPoints).HasColumnName("reputation_points");
            });

            modelBuilder.Entity<PledgeSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pledge_skill");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");
            });

            modelBuilder.Entity<PledgeSubpledge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pledge_subpledge");

                entity.Property(e => e.LeaderDbid).HasColumnName("leader_dbid");

                entity.Property(e => e.LeaderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("leader_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.PledgeType).HasColumnName("pledge_type");

                entity.Property(e => e.SubName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sub_name")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Point>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("point");

                entity.Property(e => e.Align).HasColumnName("align");

                entity.Property(e => e.Loc).HasColumnName("loc");

                entity.Property(e => e.Map).HasColumnName("map");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<PrivateStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrivateStore");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.IsOffline).HasColumnName("is_offline");

                entity.Property(e => e.Item1Count).HasColumnName("item1_count");

                entity.Property(e => e.Item1Enchant).HasColumnName("item1_enchant");

                entity.Property(e => e.Item1Id).HasColumnName("item1_id");

                entity.Property(e => e.Item1Price).HasColumnName("item1_price");

                entity.Property(e => e.Item2Count).HasColumnName("item2_count");

                entity.Property(e => e.Item2Enchant).HasColumnName("item2_enchant");

                entity.Property(e => e.Item2Id).HasColumnName("item2_id");

                entity.Property(e => e.Item2Price).HasColumnName("item2_price");

                entity.Property(e => e.Item3Count).HasColumnName("item3_count");

                entity.Property(e => e.Item3Enchant).HasColumnName("item3_enchant");

                entity.Property(e => e.Item3Id).HasColumnName("item3_id");

                entity.Property(e => e.Item3Price).HasColumnName("item3_price");

                entity.Property(e => e.Item4Count).HasColumnName("item4_count");

                entity.Property(e => e.Item4Enchant).HasColumnName("item4_enchant");

                entity.Property(e => e.Item4Id).HasColumnName("item4_id");

                entity.Property(e => e.Item4Price).HasColumnName("item4_price");

                entity.Property(e => e.Item5Count).HasColumnName("item5_count");

                entity.Property(e => e.Item5Enchant).HasColumnName("item5_enchant");

                entity.Property(e => e.Item5Id).HasColumnName("item5_id");

                entity.Property(e => e.Item5Price).HasColumnName("item5_price");

                entity.Property(e => e.Item6Count).HasColumnName("item6_count");

                entity.Property(e => e.Item6Enchant).HasColumnName("item6_enchant");

                entity.Property(e => e.Item6Id).HasColumnName("item6_id");

                entity.Property(e => e.Item6Price).HasColumnName("item6_price");

                entity.Property(e => e.Item7Count).HasColumnName("item7_count");

                entity.Property(e => e.Item7Enchant).HasColumnName("item7_enchant");

                entity.Property(e => e.Item7Id).HasColumnName("item7_id");

                entity.Property(e => e.Item7Price).HasColumnName("item7_price");

                entity.Property(e => e.Item8Count).HasColumnName("item8_count");

                entity.Property(e => e.Item8Enchant).HasColumnName("item8_enchant");

                entity.Property(e => e.Item8Id).HasColumnName("item8_id");

                entity.Property(e => e.Item8Price).HasColumnName("item8_price");

                entity.Property(e => e.StoreType).HasColumnName("store_type");

                entity.Property(e => e.XLoc).HasColumnName("x_loc");

                entity.Property(e => e.YLoc).HasColumnName("y_loc");

                entity.Property(e => e.ZLoc).HasColumnName("z_loc");
            });

            modelBuilder.Entity<Quest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("quest");

                entity.HasIndex(e => e.CharId, "IX_Quest")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.J1).HasColumnName("j1");

                entity.Property(e => e.J10).HasColumnName("j10");

                entity.Property(e => e.J11).HasColumnName("j11");

                entity.Property(e => e.J12).HasColumnName("j12");

                entity.Property(e => e.J13).HasColumnName("j13");

                entity.Property(e => e.J14).HasColumnName("j14");

                entity.Property(e => e.J15).HasColumnName("j15");

                entity.Property(e => e.J16).HasColumnName("j16");

                entity.Property(e => e.J17).HasColumnName("j17");

                entity.Property(e => e.J18).HasColumnName("j18");

                entity.Property(e => e.J19).HasColumnName("j19");

                entity.Property(e => e.J2).HasColumnName("j2");

                entity.Property(e => e.J20).HasColumnName("j20");

                entity.Property(e => e.J21).HasColumnName("j21");

                entity.Property(e => e.J22).HasColumnName("j22");

                entity.Property(e => e.J23).HasColumnName("j23");

                entity.Property(e => e.J24).HasColumnName("j24");

                entity.Property(e => e.J25).HasColumnName("j25");

                entity.Property(e => e.J26).HasColumnName("j26");

                entity.Property(e => e.J3).HasColumnName("j3");

                entity.Property(e => e.J4).HasColumnName("j4");

                entity.Property(e => e.J5).HasColumnName("j5");

                entity.Property(e => e.J6).HasColumnName("j6");

                entity.Property(e => e.J7).HasColumnName("j7");

                entity.Property(e => e.J8).HasColumnName("j8");

                entity.Property(e => e.J9).HasColumnName("j9");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10).HasColumnName("q10");

                entity.Property(e => e.Q11).HasColumnName("q11");

                entity.Property(e => e.Q12).HasColumnName("q12");

                entity.Property(e => e.Q13).HasColumnName("q13");

                entity.Property(e => e.Q14).HasColumnName("q14");

                entity.Property(e => e.Q15).HasColumnName("q15");

                entity.Property(e => e.Q16).HasColumnName("q16");

                entity.Property(e => e.Q17).HasColumnName("q17");

                entity.Property(e => e.Q18).HasColumnName("q18");

                entity.Property(e => e.Q19).HasColumnName("q19");

                entity.Property(e => e.Q2).HasColumnName("q2");

                entity.Property(e => e.Q20).HasColumnName("q20");

                entity.Property(e => e.Q21).HasColumnName("q21");

                entity.Property(e => e.Q22).HasColumnName("q22");

                entity.Property(e => e.Q23).HasColumnName("q23");

                entity.Property(e => e.Q24).HasColumnName("q24");

                entity.Property(e => e.Q25).HasColumnName("q25");

                entity.Property(e => e.Q26).HasColumnName("q26");

                entity.Property(e => e.Q3).HasColumnName("q3");

                entity.Property(e => e.Q4).HasColumnName("q4");

                entity.Property(e => e.Q5).HasColumnName("q5");

                entity.Property(e => e.Q6).HasColumnName("q6");

                entity.Property(e => e.Q7).HasColumnName("q7");

                entity.Property(e => e.Q8).HasColumnName("q8");

                entity.Property(e => e.Q9).HasColumnName("q9");

                entity.Property(e => e.S1)
                    .HasColumnName("s1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S10).HasColumnName("s10");

                entity.Property(e => e.S11).HasColumnName("s11");

                entity.Property(e => e.S12).HasColumnName("s12");

                entity.Property(e => e.S13).HasColumnName("s13");

                entity.Property(e => e.S14).HasColumnName("s14");

                entity.Property(e => e.S15).HasColumnName("s15");

                entity.Property(e => e.S16).HasColumnName("s16");

                entity.Property(e => e.S17).HasColumnName("s17");

                entity.Property(e => e.S18).HasColumnName("s18");

                entity.Property(e => e.S19).HasColumnName("s19");

                entity.Property(e => e.S2).HasColumnName("s2");

                entity.Property(e => e.S20).HasColumnName("s20");

                entity.Property(e => e.S21)
                    .HasColumnName("s2_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S210)
                    .HasColumnName("s2_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S211)
                    .HasColumnName("s2_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S212)
                    .HasColumnName("s2_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S213)
                    .HasColumnName("s2_13")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S214)
                    .HasColumnName("s2_14")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S215)
                    .HasColumnName("s2_15")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S216)
                    .HasColumnName("s2_16")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S217).HasColumnName("s21");

                entity.Property(e => e.S2171).HasColumnName("s2_17");

                entity.Property(e => e.S218).HasColumnName("s2_18");

                entity.Property(e => e.S219).HasColumnName("s2_19");

                entity.Property(e => e.S22)
                    .HasColumnName("s2_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S220).HasColumnName("s2_20");

                entity.Property(e => e.S221).HasColumnName("s22");

                entity.Property(e => e.S2211).HasColumnName("s2_21");

                entity.Property(e => e.S222).HasColumnName("s2_22");

                entity.Property(e => e.S223).HasColumnName("s2_23");

                entity.Property(e => e.S224).HasColumnName("s2_24");

                entity.Property(e => e.S225).HasColumnName("s2_25");

                entity.Property(e => e.S226).HasColumnName("s2_26");

                entity.Property(e => e.S23)
                    .HasColumnName("s2_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S231).HasColumnName("s23");

                entity.Property(e => e.S24)
                    .HasColumnName("s2_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S241).HasColumnName("s24");

                entity.Property(e => e.S25)
                    .HasColumnName("s2_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S251).HasColumnName("s25");

                entity.Property(e => e.S26)
                    .HasColumnName("s2_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S261).HasColumnName("s26");

                entity.Property(e => e.S27)
                    .HasColumnName("s2_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S28)
                    .HasColumnName("s2_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S29)
                    .HasColumnName("s2_9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.S3).HasColumnName("s3");

                entity.Property(e => e.S4).HasColumnName("s4");

                entity.Property(e => e.S5).HasColumnName("s5");

                entity.Property(e => e.S6).HasColumnName("s6");

                entity.Property(e => e.S7).HasColumnName("s7");

                entity.Property(e => e.S8).HasColumnName("s8");

                entity.Property(e => e.S9).HasColumnName("s9");
            });

            modelBuilder.Entity<QuestDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("data")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("logdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<ReqChar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_char");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.ServerId).HasColumnName("server_id");
            });

            modelBuilder.Entity<ReqCharmove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_charmove");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.IsPcBang).HasColumnName("is_pc_bang");

                entity.Property(e => e.NewCharId).HasColumnName("new_char_id");

                entity.Property(e => e.NewCharName)
                    .HasMaxLength(50)
                    .HasColumnName("new_char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NewWorldId).HasColumnName("new_world_id");

                entity.Property(e => e.OldCharId).HasColumnName("old_char_id");

                entity.Property(e => e.OldCharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("old_char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.OldWorldId).HasColumnName("old_world_id");

                entity.Property(e => e.ReqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("req_date");

                entity.Property(e => e.ReqId).HasColumnName("req_id");
            });

            modelBuilder.Entity<ReqCharmoveOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_charmove_old");

                entity.HasIndex(e => e.NewCharName, "IX_req_charmove")
                    .IsUnique();

                entity.HasIndex(e => new { e.OldCharId, e.OldWorldId }, "IX_req_charmove_1")
                    .IsUnique();

                entity.HasIndex(e => e.AccountId, "IX_req_charmove_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.NewCharName, e.NewWorldId }, "IX_req_charmove_3")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NewCharId).HasColumnName("new_char_id");

                entity.Property(e => e.NewCharName)
                    .HasMaxLength(50)
                    .HasColumnName("new_char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NewWorldId).HasColumnName("new_world_id");

                entity.Property(e => e.OldCharId).HasColumnName("old_char_id");

                entity.Property(e => e.OldCharName)
                    .HasMaxLength(50)
                    .HasColumnName("old_char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.OldWorldId).HasColumnName("old_world_id");

                entity.Property(e => e.ReqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("req_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("req_id");
            });

            modelBuilder.Entity<ReqPledge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_pledge");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ServerId).HasColumnName("server_id");
            });

            modelBuilder.Entity<ResidenceGuard>(entity =>
            {
                entity.HasKey(e => new { e.X, e.Y, e.Z })
                    .HasName("pk_residence_guard");

                entity.ToTable("residence_guard");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.CanMove).HasColumnName("can_move");

                entity.Property(e => e.GuardType).HasColumnName("guard_type");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.NpcId).HasColumnName("npc_id");

                entity.Property(e => e.ResidenceId).HasColumnName("residence_id");
            });

            modelBuilder.Entity<ShortcutDatum>(entity =>
            {
                entity.HasKey(e => new { e.CharId, e.Slotnum, e.SubjobId });

                entity.ToTable("shortcut_data");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Slotnum).HasColumnName("slotnum");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");

                entity.Property(e => e.ShortcutId).HasColumnName("shortcut_id");

                entity.Property(e => e.ShortcutMacro)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("shortcut_macro")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.ShortcutType).HasColumnName("shortcut_type");
            });

            modelBuilder.Entity<SiegeAgitPledge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("siege_agit_pledge");

                entity.HasIndex(e => new { e.AgitId, e.PledgeId }, "sap_uniq")
                    .IsUnique();

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ProposeTime).HasColumnName("propose_time");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SiegeStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SiegeStat");

                entity.Property(e => e.CastleId).HasColumnName("castle_id");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.DamageDealt).HasColumnName("damage_dealt");

                entity.Property(e => e.DamageTaken).HasColumnName("damage_taken");

                entity.Property(e => e.DeathCount).HasColumnName("death_count");

                entity.Property(e => e.KillCount).HasColumnName("kill_count");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");
            });

            modelBuilder.Entity<SkillDatum>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Lev });

                entity.HasIndex(e => e.Name, "IX_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.ActivateType)
                    .HasMaxLength(5)
                    .HasColumnName("activate_type")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.BIsMagic).HasColumnName("bIsMagic");

                entity.Property(e => e.Logdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("logdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.SkillDesc)
                    .HasMaxLength(255)
                    .HasColumnName("skill_desc")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<SsqDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssq_data");

                entity.Property(e => e.CanDropGuard).HasColumnName("can_drop_guard");

                entity.Property(e => e.CastleSnapshotTime).HasColumnName("castle_snapshot_time");

                entity.Property(e => e.EventEndTime).HasColumnName("event_end_time");

                entity.Property(e => e.EventStartTime).HasColumnName("event_start_time");

                entity.Property(e => e.LastChangedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_changed_time");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");

                entity.Property(e => e.Seal1).HasColumnName("seal1");

                entity.Property(e => e.Seal2).HasColumnName("seal2");

                entity.Property(e => e.Seal3).HasColumnName("seal3");

                entity.Property(e => e.Seal4).HasColumnName("seal4");

                entity.Property(e => e.Seal5).HasColumnName("seal5");

                entity.Property(e => e.Seal6).HasColumnName("seal6");

                entity.Property(e => e.Seal7).HasColumnName("seal7");

                entity.Property(e => e.SealEffectEndTime).HasColumnName("seal_effect_end_time");

                entity.Property(e => e.SealEffectTime).HasColumnName("seal_effect_time");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Winner).HasColumnName("winner");
            });

            modelBuilder.Entity<SsqJoinDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssq_join_data");

                entity.Property(e => e.CollectedPoint).HasColumnName("collected_point");

                entity.Property(e => e.LastChangedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_changed_time");

                entity.Property(e => e.MainEventPoint).HasColumnName("main_event_point");

                entity.Property(e => e.MemberCount).HasColumnName("member_count");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");

                entity.Property(e => e.Seal1SelectionCount).HasColumnName("seal1_selection_count");

                entity.Property(e => e.Seal2SelectionCount).HasColumnName("seal2_selection_count");

                entity.Property(e => e.Seal3SelectionCount).HasColumnName("seal3_selection_count");

                entity.Property(e => e.Seal4SelectionCount).HasColumnName("seal4_selection_count");

                entity.Property(e => e.Seal5SelectionCount).HasColumnName("seal5_selection_count");

                entity.Property(e => e.Seal6SelectionCount).HasColumnName("seal6_selection_count");

                entity.Property(e => e.Seal7SelectionCount).HasColumnName("seal7_selection_count");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SsqTopPointUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssq_top_point_user");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.LastChangedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_changed_time");

                entity.Property(e => e.RankTime).HasColumnName("rank_time");

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.SealSelectionNo).HasColumnName("seal_selection_no");

                entity.Property(e => e.SsqPart).HasColumnName("ssq_part");

                entity.Property(e => e.SsqPoint).HasColumnName("ssq_point");

                entity.Property(e => e.SsqPosition).HasColumnName("ssq_position");

                entity.Property(e => e.SsqRound).HasColumnName("ssq_round");
            });

            modelBuilder.Entity<SsqUserDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ssq_user_data");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.DawnAItemNum).HasColumnName("dawn_a_item_num");

                entity.Property(e => e.DawnBItemNum).HasColumnName("dawn_b_item_num");

                entity.Property(e => e.DawnCItemNum).HasColumnName("dawn_c_item_num");

                entity.Property(e => e.RoundNumber).HasColumnName("round_number");

                entity.Property(e => e.SealSelectionNo).HasColumnName("seal_selection_no");

                entity.Property(e => e.SsqJoinTime).HasColumnName("ssq_join_time");

                entity.Property(e => e.SsqPart).HasColumnName("ssq_part");

                entity.Property(e => e.SsqPoint).HasColumnName("ssq_point");

                entity.Property(e => e.SsqPosition).HasColumnName("ssq_position");

                entity.Property(e => e.TicketBuyCount).HasColumnName("ticket_buy_count");

                entity.Property(e => e.TwilightAItemNum).HasColumnName("twilight_a_item_num");

                entity.Property(e => e.TwilightBItemNum).HasColumnName("twilight_b_item_num");

                entity.Property(e => e.TwilightCItemNum).HasColumnName("twilight_c_item_num");
            });

            modelBuilder.Entity<StatAccClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_acc_class");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<StatAccLev>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_acc_lev");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Lev).HasColumnName("lev");
            });

            modelBuilder.Entity<StatAccMlev>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_acc_mlev");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.Race).HasColumnName("race");
            });

            modelBuilder.Entity<StatAccRace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_acc_race");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Race).HasColumnName("race");
            });

            modelBuilder.Entity<StatItemCnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_item_cnt");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<StatItemEnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_item_ent");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.Sum).HasColumnName("sum");
            });

            modelBuilder.Entity<StatItemMent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_item_ment");

                entity.Property(e => e.Builder).HasColumnName("builder");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.MaxEnt).HasColumnName("max_ent");
            });

            modelBuilder.Entity<StatItemMincnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stat_item_mincnt");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");
            });

            modelBuilder.Entity<SubStack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubStack");

                entity.Property(e => e.BaseClass0)
                    .HasColumnName("baseClass0")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.BaseClass1)
                    .HasColumnName("baseClass1")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.BaseClass2)
                    .HasColumnName("baseClass2")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.BaseClass3)
                    .HasColumnName("baseClass3")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.StackClass0)
                    .HasColumnName("stackClass0")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StackClass1)
                    .HasColumnName("stackClass1")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StackClass2)
                    .HasColumnName("stackClass2")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StackClass3)
                    .HasColumnName("stackClass3")
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<TeamBattleAgitMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_battle_agit_member");

                entity.HasIndex(e => new { e.AgitId, e.CharId }, "tbam_uniq")
                    .IsUnique();

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ProposeTime).HasColumnName("propose_time");
            });

            modelBuilder.Entity<TeamBattleAgitPledge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_battle_agit_pledge");

                entity.HasIndex(e => new { e.AgitId, e.PledgeId }, "tbap_uniq")
                    .IsUnique();

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.NpcType).HasColumnName("npc_type");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.ProposeTime).HasColumnName("propose_time");
            });

            modelBuilder.Entity<TempAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_account");

                entity.Property(e => e.RealAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("real_account")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_id")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<TempInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_inv");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TempPetInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_pet_inv");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.PetCollarId).HasColumnName("pet_collar_id");

                entity.Property(e => e.PetItemId).HasColumnName("pet_item_id");

                entity.Property(e => e.PetItemType).HasColumnName("pet_item_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<TempRecipe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_recipe");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.Recipecount).HasColumnName("recipecount");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");
            });

            modelBuilder.Entity<TempSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_skill");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e.Skill).HasColumnName("skill");

                entity.Property(e => e.Temptime).HasColumnName("temptime");
            });

            modelBuilder.Entity<TempSkill2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_skill2");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SkillLev).HasColumnName("skill_lev");

                entity.Property(e => e.Temptime).HasColumnName("temptime");
            });

            modelBuilder.Entity<TempUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_update");

                entity.Property(e => e.CharId).HasColumnName("char_id");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Lev).HasColumnName("lev");

                entity.Property(e => e._).HasColumnName("??");
            });

            modelBuilder.Entity<TimeAttackRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("time_attack_record");

                entity.Property(e => e.ElapsedTime).HasColumnName("elapsed_time");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.MemberCount).HasColumnName("member_count");

                entity.Property(e => e.MemberDbidList)
                    .HasMaxLength(128)
                    .HasColumnName("member_dbid_list")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.MemberNames)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("member_names")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.MemberRewardFlags).HasColumnName("member_reward_flags");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.RecordTime).HasColumnName("record_time");

                entity.Property(e => e.RecordType).HasColumnName("record_type");

                entity.Property(e => e.RoomNo).HasColumnName("room_no");

                entity.Property(e => e.SsqPart).HasColumnName("ssq_part");

                entity.Property(e => e.SsqRound).HasColumnName("ssq_round");
            });

            modelBuilder.Entity<TimeAttackRecordTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("time_attack_record_test");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col006)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col008)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col009)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col010)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col011)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Col012)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<TimeDatum>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_char_data2");

                entity.ToTable("time_data");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("account_id");

                entity.Property(e => e.LastLogout)
                    .HasColumnType("datetime")
                    .HasColumnName("last_logout");

                entity.Property(e => e.UsedSec).HasColumnName("used_sec");
            });

            modelBuilder.Entity<TmpAlliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_alliance");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MasterPledgeId).HasColumnName("master_pledge_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.OustTime).HasColumnName("oust_time");
            });

            modelBuilder.Entity<TmpDieUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_die_user");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.AfterResurrectExp).HasColumnName("after_resurrect_exp");

                entity.Property(e => e.BeforeDieExp).HasColumnName("before_die_exp");

                entity.Property(e => e.CharName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.DieMinusExp).HasColumnName("die_minus_exp");

                entity.Property(e => e.HasSubjob).HasColumnName("hasSubjob");

                entity.Property(e => e.ResurrectAddExp).HasColumnName("resurrect_add_exp");
            });

            modelBuilder.Entity<TmpLottoPriceGiven>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_lotto_price_given");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NewPrice).HasColumnName("new_price");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Rank).HasColumnName("rank");
            });

            modelBuilder.Entity<TmpPledge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_pledge");

                entity.Property(e => e.AgitId).HasColumnName("agit_id");

                entity.Property(e => e.AllianceId).HasColumnName("alliance_id");

                entity.Property(e => e.CastleId).HasColumnName("castle_id");

                entity.Property(e => e.DismissReservedTime).HasColumnName("dismiss_reserved_time");

                entity.Property(e => e.IsGuilty).HasColumnName("is_guilty");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.NameValue).HasColumnName("name_value");

                entity.Property(e => e.OustTime).HasColumnName("oust_time");

                entity.Property(e => e.PledgeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pledge_id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.RootNameValue).HasColumnName("root_name_value");

                entity.Property(e => e.RulerId).HasColumnName("ruler_id");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TmpRecoverUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_recover_user");

                entity.Property(e => e.AddedExp).HasColumnName("addedExp");

                entity.Property(e => e.CharName)
                    .HasMaxLength(60)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<TmpSeedDp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_seed_dp");

                entity.Property(e => e.Dp).HasColumnName("dp");

                entity.Property(e => e.SeedId).HasColumnName("seed_id");
            });

            modelBuilder.Entity<TmpUserDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_user_data");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Align).HasColumnName("align");

                entity.Property(e => e.Builder).HasColumnName("builder");

                entity.Property(e => e.CharId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Cp).HasColumnName("cp");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DropExp).HasColumnName("drop_exp");

                entity.Property(e => e.Exp).HasColumnName("EXP");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Login)
                    .HasColumnType("datetime")
                    .HasColumnName("login");

                entity.Property(e => e.Logout)
                    .HasColumnType("datetime")
                    .HasColumnName("logout");

                entity.Property(e => e.MaxCp).HasColumnName("max_cp");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.MaxMp).HasColumnName("max_mp");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Pkpardon).HasColumnName("PKpardon");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.Race).HasColumnName("race");

                entity.Property(e => e.Sp).HasColumnName("SP");

                entity.Property(e => e.Subjob0Class).HasColumnName("subjob0_class");

                entity.Property(e => e.Subjob1Class).HasColumnName("subjob1_class");

                entity.Property(e => e.Subjob2Class).HasColumnName("subjob2_class");

                entity.Property(e => e.Subjob3Class).HasColumnName("subjob3_class");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");

                entity.Property(e => e.UseTime).HasColumnName("use_time");

                entity.Property(e => e.World).HasColumnName("world");
            });

            modelBuilder.Entity<TmpUserItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_user_item");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");
            });

            modelBuilder.Entity<TmpUserNobless>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_user_nobless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.HeroType).HasColumnName("hero_type");

                entity.Property(e => e.MatchCount).HasColumnName("match_count");

                entity.Property(e => e.NoblessType).HasColumnName("nobless_type");

                entity.Property(e => e.OlympiadPoint).HasColumnName("olympiad_point");

                entity.Property(e => e.PreviousPoint).HasColumnName("previous_point");

                entity.Property(e => e.WinCount).HasColumnName("win_count");

                entity.Property(e => e.Words)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("words")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserActiveSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_ActiveSkill");

                entity.Property(e => e.C1).HasColumnName("c1");

                entity.Property(e => e.C10).HasColumnName("c10");

                entity.Property(e => e.C11).HasColumnName("c11");

                entity.Property(e => e.C12).HasColumnName("c12");

                entity.Property(e => e.C13).HasColumnName("c13");

                entity.Property(e => e.C14).HasColumnName("c14");

                entity.Property(e => e.C15).HasColumnName("c15");

                entity.Property(e => e.C16).HasColumnName("c16");

                entity.Property(e => e.C17).HasColumnName("c17");

                entity.Property(e => e.C18).HasColumnName("c18");

                entity.Property(e => e.C19).HasColumnName("c19");

                entity.Property(e => e.C2).HasColumnName("c2");

                entity.Property(e => e.C20).HasColumnName("c20");

                entity.Property(e => e.C21).HasColumnName("c21");

                entity.Property(e => e.C22).HasColumnName("c22");

                entity.Property(e => e.C23).HasColumnName("c23");

                entity.Property(e => e.C24).HasColumnName("c24");

                entity.Property(e => e.C25).HasColumnName("c25");

                entity.Property(e => e.C26).HasColumnName("c26");

                entity.Property(e => e.C27).HasColumnName("c27");

                entity.Property(e => e.C28).HasColumnName("c28");

                entity.Property(e => e.C29).HasColumnName("c29");

                entity.Property(e => e.C3).HasColumnName("c3");

                entity.Property(e => e.C30).HasColumnName("c30");

                entity.Property(e => e.C31).HasColumnName("c31");

                entity.Property(e => e.C32).HasColumnName("c32");

                entity.Property(e => e.C33).HasColumnName("c33");

                entity.Property(e => e.C34).HasColumnName("c34");

                entity.Property(e => e.C35).HasColumnName("c35");

                entity.Property(e => e.C36).HasColumnName("c36");

                entity.Property(e => e.C37).HasColumnName("c37");

                entity.Property(e => e.C38).HasColumnName("c38");

                entity.Property(e => e.C39).HasColumnName("c39");

                entity.Property(e => e.C4).HasColumnName("c4");

                entity.Property(e => e.C40).HasColumnName("c40");

                entity.Property(e => e.C5).HasColumnName("c5");

                entity.Property(e => e.C6).HasColumnName("c6");

                entity.Property(e => e.C7).HasColumnName("c7");

                entity.Property(e => e.C8).HasColumnName("c8");

                entity.Property(e => e.C9).HasColumnName("c9");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D10).HasColumnName("d10");

                entity.Property(e => e.D11).HasColumnName("d11");

                entity.Property(e => e.D12).HasColumnName("d12");

                entity.Property(e => e.D13).HasColumnName("d13");

                entity.Property(e => e.D14).HasColumnName("d14");

                entity.Property(e => e.D15).HasColumnName("d15");

                entity.Property(e => e.D16).HasColumnName("d16");

                entity.Property(e => e.D17).HasColumnName("d17");

                entity.Property(e => e.D18).HasColumnName("d18");

                entity.Property(e => e.D19).HasColumnName("d19");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D20).HasColumnName("d20");

                entity.Property(e => e.D21).HasColumnName("d21");

                entity.Property(e => e.D22).HasColumnName("d22");

                entity.Property(e => e.D23).HasColumnName("d23");

                entity.Property(e => e.D24).HasColumnName("d24");

                entity.Property(e => e.D25).HasColumnName("d25");

                entity.Property(e => e.D26).HasColumnName("d26");

                entity.Property(e => e.D27).HasColumnName("d27");

                entity.Property(e => e.D28).HasColumnName("d28");

                entity.Property(e => e.D29).HasColumnName("d29");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.D30).HasColumnName("d30");

                entity.Property(e => e.D31).HasColumnName("d31");

                entity.Property(e => e.D32).HasColumnName("d32");

                entity.Property(e => e.D33).HasColumnName("d33");

                entity.Property(e => e.D34).HasColumnName("d34");

                entity.Property(e => e.D35).HasColumnName("d35");

                entity.Property(e => e.D36).HasColumnName("d36");

                entity.Property(e => e.D37).HasColumnName("d37");

                entity.Property(e => e.D38).HasColumnName("d38");

                entity.Property(e => e.D39).HasColumnName("d39");

                entity.Property(e => e.D4).HasColumnName("d4");

                entity.Property(e => e.D40).HasColumnName("d40");

                entity.Property(e => e.D5).HasColumnName("d5");

                entity.Property(e => e.D6).HasColumnName("d6");

                entity.Property(e => e.D7).HasColumnName("d7");

                entity.Property(e => e.D8).HasColumnName("d8");

                entity.Property(e => e.D9).HasColumnName("d9");

                entity.Property(e => e.L1).HasColumnName("l1");

                entity.Property(e => e.L10).HasColumnName("l10");

                entity.Property(e => e.L11).HasColumnName("l11");

                entity.Property(e => e.L12).HasColumnName("l12");

                entity.Property(e => e.L13).HasColumnName("l13");

                entity.Property(e => e.L14).HasColumnName("l14");

                entity.Property(e => e.L15).HasColumnName("l15");

                entity.Property(e => e.L16).HasColumnName("l16");

                entity.Property(e => e.L17).HasColumnName("l17");

                entity.Property(e => e.L18).HasColumnName("l18");

                entity.Property(e => e.L19).HasColumnName("l19");

                entity.Property(e => e.L2).HasColumnName("l2");

                entity.Property(e => e.L20).HasColumnName("l20");

                entity.Property(e => e.L21).HasColumnName("l21");

                entity.Property(e => e.L22).HasColumnName("l22");

                entity.Property(e => e.L23).HasColumnName("l23");

                entity.Property(e => e.L24).HasColumnName("l24");

                entity.Property(e => e.L25).HasColumnName("l25");

                entity.Property(e => e.L26).HasColumnName("l26");

                entity.Property(e => e.L27).HasColumnName("l27");

                entity.Property(e => e.L28).HasColumnName("l28");

                entity.Property(e => e.L29).HasColumnName("l29");

                entity.Property(e => e.L3).HasColumnName("l3");

                entity.Property(e => e.L30).HasColumnName("l30");

                entity.Property(e => e.L31).HasColumnName("l31");

                entity.Property(e => e.L32).HasColumnName("l32");

                entity.Property(e => e.L33).HasColumnName("l33");

                entity.Property(e => e.L34).HasColumnName("l34");

                entity.Property(e => e.L35).HasColumnName("l35");

                entity.Property(e => e.L36).HasColumnName("l36");

                entity.Property(e => e.L37).HasColumnName("l37");

                entity.Property(e => e.L38).HasColumnName("l38");

                entity.Property(e => e.L39).HasColumnName("l39");

                entity.Property(e => e.L4).HasColumnName("l4");

                entity.Property(e => e.L40).HasColumnName("l40");

                entity.Property(e => e.L5).HasColumnName("l5");

                entity.Property(e => e.L6).HasColumnName("l6");

                entity.Property(e => e.L7).HasColumnName("l7");

                entity.Property(e => e.L8).HasColumnName("l8");

                entity.Property(e => e.L9).HasColumnName("l9");

                entity.Property(e => e.S1).HasColumnName("s1");

                entity.Property(e => e.S10).HasColumnName("s10");

                entity.Property(e => e.S11).HasColumnName("s11");

                entity.Property(e => e.S12).HasColumnName("s12");

                entity.Property(e => e.S13).HasColumnName("s13");

                entity.Property(e => e.S14).HasColumnName("s14");

                entity.Property(e => e.S15).HasColumnName("s15");

                entity.Property(e => e.S16).HasColumnName("s16");

                entity.Property(e => e.S17).HasColumnName("s17");

                entity.Property(e => e.S18).HasColumnName("s18");

                entity.Property(e => e.S19).HasColumnName("s19");

                entity.Property(e => e.S2).HasColumnName("s2");

                entity.Property(e => e.S20).HasColumnName("s20");

                entity.Property(e => e.S21).HasColumnName("s21");

                entity.Property(e => e.S22).HasColumnName("s22");

                entity.Property(e => e.S23).HasColumnName("s23");

                entity.Property(e => e.S24).HasColumnName("s24");

                entity.Property(e => e.S25).HasColumnName("s25");

                entity.Property(e => e.S26).HasColumnName("s26");

                entity.Property(e => e.S27).HasColumnName("s27");

                entity.Property(e => e.S28).HasColumnName("s28");

                entity.Property(e => e.S29).HasColumnName("s29");

                entity.Property(e => e.S3).HasColumnName("s3");

                entity.Property(e => e.S30).HasColumnName("s30");

                entity.Property(e => e.S31).HasColumnName("s31");

                entity.Property(e => e.S32).HasColumnName("s32");

                entity.Property(e => e.S33).HasColumnName("s33");

                entity.Property(e => e.S34).HasColumnName("s34");

                entity.Property(e => e.S35).HasColumnName("s35");

                entity.Property(e => e.S36).HasColumnName("s36");

                entity.Property(e => e.S37).HasColumnName("s37");

                entity.Property(e => e.S38).HasColumnName("s38");

                entity.Property(e => e.S39).HasColumnName("s39");

                entity.Property(e => e.S4).HasColumnName("s4");

                entity.Property(e => e.S40).HasColumnName("s40");

                entity.Property(e => e.S5).HasColumnName("s5");

                entity.Property(e => e.S6).HasColumnName("s6");

                entity.Property(e => e.S7).HasColumnName("s7");

                entity.Property(e => e.S8).HasColumnName("s8");

                entity.Property(e => e.S9).HasColumnName("s9");
            });

            modelBuilder.Entity<UserBan>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.ToTable("user_ban");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.BanDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ban_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BanEnd)
                    .HasColumnName("ban_end")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BanHour)
                    .HasColumnName("ban_hour")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserBlocklist>(entity =>
            {
                entity.HasKey(e => new { e.CharId, e.BlockCharId });

                entity.ToTable("user_blocklist");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.BlockCharId).HasColumnName("block_char_id");

                entity.Property(e => e.BlockCharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("block_char_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_comment");

                entity.HasIndex(e => new { e.CharId, e.Deleted, e.CommentId }, "IX_user_comment")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.CommentId, "IX_user_comment_1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .HasColumnName("comment")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("comment_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("comment_id");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Writer)
                    .HasMaxLength(50)
                    .HasColumnName("writer")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserDataMoved>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_data_moved");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Align).HasColumnName("align");

                entity.Property(e => e.Builder).HasColumnName("builder");

                entity.Property(e => e.CharId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DropExp).HasColumnName("drop_exp");

                entity.Property(e => e.FaceIndex).HasColumnName("face_index");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.HairColorIndex).HasColumnName("hair_color_index");

                entity.Property(e => e.HairShapeIndex).HasColumnName("hair_shape_index");

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Login)
                    .HasColumnType("datetime")
                    .HasColumnName("login");

                entity.Property(e => e.Logout)
                    .HasColumnType("datetime")
                    .HasColumnName("logout");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.MaxMp).HasColumnName("max_mp");

                entity.Property(e => e.Mp).HasColumnName("MP");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Pkpardon).HasColumnName("PKpardon");

                entity.Property(e => e.PledgeDismissTime).HasColumnName("pledge_dismiss_time");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.PledgeLeaveStatus).HasColumnName("pledge_leave_status");

                entity.Property(e => e.PledgeLeaveTime).HasColumnName("pledge_leave_time");

                entity.Property(e => e.PledgeOustedTime).HasColumnName("pledge_ousted_time");

                entity.Property(e => e.PledgeWithdrawTime).HasColumnName("pledge_withdraw_time");

                entity.Property(e => e.PowerFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("power_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("quest_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestMemo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("quest_memo")
                    .IsFixedLength(true)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Race).HasColumnName("race");

                entity.Property(e => e.Sp).HasColumnName("SP");

                entity.Property(e => e.StBack).HasColumnName("ST_back");

                entity.Property(e => e.StBothHand).HasColumnName("ST_both_hand");

                entity.Property(e => e.StChest).HasColumnName("ST_chest");

                entity.Property(e => e.StFeet).HasColumnName("ST_feet");

                entity.Property(e => e.StGloves).HasColumnName("ST_gloves");

                entity.Property(e => e.StHead).HasColumnName("ST_head");

                entity.Property(e => e.StLeftEar).HasColumnName("ST_left_ear");

                entity.Property(e => e.StLeftFinger).HasColumnName("ST_left_finger");

                entity.Property(e => e.StLeftHand).HasColumnName("ST_left_hand");

                entity.Property(e => e.StLegs).HasColumnName("ST_legs");

                entity.Property(e => e.StNeck).HasColumnName("ST_neck");

                entity.Property(e => e.StRightEar).HasColumnName("ST_right_ear");

                entity.Property(e => e.StRightFinger).HasColumnName("ST_right_finger");

                entity.Property(e => e.StRightHand).HasColumnName("ST_right_hand");

                entity.Property(e => e.StUnderware).HasColumnName("ST_underware");

                entity.Property(e => e.SurrenderWarId).HasColumnName("surrender_war_id");

                entity.Property(e => e.TempDeleteDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("temp_delete_date");

                entity.Property(e => e.UseTime).HasColumnName("use_time");

                entity.Property(e => e.World).HasColumnName("world");

                entity.Property(e => e.Xloc).HasColumnName("xloc");

                entity.Property(e => e.Yloc).HasColumnName("yloc");

                entity.Property(e => e.Zloc).HasColumnName("zloc");
            });

            modelBuilder.Entity<UserDataTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_data_temp");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Align).HasColumnName("align");

                entity.Property(e => e.Builder).HasColumnName("builder");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DropExp).HasColumnName("drop_exp");

                entity.Property(e => e.FaceIndex).HasColumnName("face_index");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.HairColorIndex).HasColumnName("hair_color_index");

                entity.Property(e => e.HairShapeIndex).HasColumnName("hair_shape_index");

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Login)
                    .HasColumnType("datetime")
                    .HasColumnName("login");

                entity.Property(e => e.Logout)
                    .HasColumnType("datetime")
                    .HasColumnName("logout");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.MaxMp).HasColumnName("max_mp");

                entity.Property(e => e.Mp).HasColumnName("MP");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.OldX).HasColumnName("old_x");

                entity.Property(e => e.OldY).HasColumnName("old_y");

                entity.Property(e => e.OldZ).HasColumnName("old_z");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Pkpardon).HasColumnName("PKpardon");

                entity.Property(e => e.PledgeDismissTime).HasColumnName("pledge_dismiss_time");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.PledgeLeaveStatus).HasColumnName("pledge_leave_status");

                entity.Property(e => e.PledgeLeaveTime).HasColumnName("pledge_leave_time");

                entity.Property(e => e.PledgeOustedTime).HasColumnName("pledge_ousted_time");

                entity.Property(e => e.PledgeWithdrawTime).HasColumnName("pledge_withdraw_time");

                entity.Property(e => e.PowerFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("power_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("quest_flag")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestMemo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("quest_memo")
                    .IsFixedLength(true)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Race).HasColumnName("race");

                entity.Property(e => e.Sp).HasColumnName("SP");

                entity.Property(e => e.StBack).HasColumnName("ST_back");

                entity.Property(e => e.StBothHand).HasColumnName("ST_both_hand");

                entity.Property(e => e.StChest).HasColumnName("ST_chest");

                entity.Property(e => e.StFeet).HasColumnName("ST_feet");

                entity.Property(e => e.StGloves).HasColumnName("ST_gloves");

                entity.Property(e => e.StHead).HasColumnName("ST_head");

                entity.Property(e => e.StLeftEar).HasColumnName("ST_left_ear");

                entity.Property(e => e.StLeftFinger).HasColumnName("ST_left_finger");

                entity.Property(e => e.StLeftHand).HasColumnName("ST_left_hand");

                entity.Property(e => e.StLegs).HasColumnName("ST_legs");

                entity.Property(e => e.StNeck).HasColumnName("ST_neck");

                entity.Property(e => e.StRightEar).HasColumnName("ST_right_ear");

                entity.Property(e => e.StRightFinger).HasColumnName("ST_right_finger");

                entity.Property(e => e.StRightHand).HasColumnName("ST_right_hand");

                entity.Property(e => e.StUnderware).HasColumnName("ST_underware");

                entity.Property(e => e.SurrenderWarId).HasColumnName("surrender_war_id");

                entity.Property(e => e.TempDeleteDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("temp_delete_date");

                entity.Property(e => e.UseTime).HasColumnName("use_time");

                entity.Property(e => e.World).HasColumnName("world");

                entity.Property(e => e.Xloc).HasColumnName("xloc");

                entity.Property(e => e.Yloc).HasColumnName("yloc");

                entity.Property(e => e.Zloc).HasColumnName("zloc");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.ToTable("user_data");

                entity.HasIndex(e => e.CharName, "idx_user_data1")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.AccountId, "idx_user_data_1")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.AccountName, "idx_user_data_account_name")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.PledgeId, "idx_user_data_pledge")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.AioId).HasColumnName("aio_id");

                entity.Property(e => e.AioTimestamp).HasColumnName("aio_timestamp");

                entity.Property(e => e.Align).HasColumnName("align");

                entity.Property(e => e.Augmentation).HasColumnName("augmentation");

                entity.Property(e => e.Builder).HasColumnName("builder");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.Cp).HasColumnName("cp");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DropExp).HasColumnName("drop_exp");

                entity.Property(e => e.EffectiveMana0).HasColumnName("effective_mana0");

                entity.Property(e => e.EffectiveMana1).HasColumnName("effective_mana1");

                entity.Property(e => e.EffectiveMana2).HasColumnName("effective_mana2");

                entity.Property(e => e.EffectiveMana3).HasColumnName("effective_mana3");

                entity.Property(e => e.FaceIndex).HasColumnName("face_index");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.HairColorIndex).HasColumnName("hair_color_index");

                entity.Property(e => e.HairShapeIndex).HasColumnName("hair_shape_index");

                entity.Property(e => e.HardwareId).HasColumnName("hardware_id");

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Login)
                    .HasColumnType("datetime")
                    .HasColumnName("login");

                entity.Property(e => e.Logout)
                    .HasColumnType("datetime")
                    .HasColumnName("logout");

                entity.Property(e => e.LongHardwareId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("long_hardware_id")
                    .HasDefaultValueSql("(N'00000000000000000000000000000000')");

                entity.Property(e => e.MaxCp).HasColumnName("max_cp");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.MaxMp).HasColumnName("max_mp");

                entity.Property(e => e.Mp).HasColumnName("MP");

                entity.Property(e => e.NameColor).HasColumnName("name_color");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.OldX).HasColumnName("old_x");

                entity.Property(e => e.OldY).HasColumnName("old_y");

                entity.Property(e => e.OldZ).HasColumnName("old_z");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.Pkpardon).HasColumnName("PKpardon");

                entity.Property(e => e.PledgeDismissTime).HasColumnName("pledge_dismiss_time");

                entity.Property(e => e.PledgeId).HasColumnName("pledge_id");

                entity.Property(e => e.PledgeLeaveStatus).HasColumnName("pledge_leave_status");

                entity.Property(e => e.PledgeLeaveTime).HasColumnName("pledge_leave_time");

                entity.Property(e => e.PledgeOustedTime).HasColumnName("pledge_ousted_time");

                entity.Property(e => e.PledgeWithdrawTime).HasColumnName("pledge_withdraw_time");

                entity.Property(e => e.PowerFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("power_flag")
                    .HasDefaultValueSql("(0x0000000000000000000000000000000000000000000000000000000000000000)")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestFlag)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("quest_flag")
                    .HasDefaultValueSql("(0x00)")
                    .IsFixedLength(true);

                entity.Property(e => e.QuestMemo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("quest_memo")
                    .IsFixedLength(true)
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.Race).HasColumnName("race");

                entity.Property(e => e.Rank).HasDefaultValueSql("((6))");

                entity.Property(e => e.Sp).HasColumnName("SP");

                entity.Property(e => e.SpiritCount).HasColumnName("spirit_count");

                entity.Property(e => e.SponsorId).HasColumnName("sponsor_id");

                entity.Property(e => e.SsqDawnRound).HasColumnName("ssq_dawn_round");

                entity.Property(e => e.StBack).HasColumnName("ST_back");

                entity.Property(e => e.StBothHand).HasColumnName("ST_both_hand");

                entity.Property(e => e.StChest).HasColumnName("ST_chest");

                entity.Property(e => e.StFeet).HasColumnName("ST_feet");

                entity.Property(e => e.StGloves).HasColumnName("ST_gloves");

                entity.Property(e => e.StHair).HasColumnName("ST_hair");

                entity.Property(e => e.StHairAll).HasColumnName("ST_hair_all");

                entity.Property(e => e.StHairDeco).HasColumnName("ST_hair_deco");

                entity.Property(e => e.StHead).HasColumnName("ST_head");

                entity.Property(e => e.StLeftEar).HasColumnName("ST_left_ear");

                entity.Property(e => e.StLeftFinger).HasColumnName("ST_left_finger");

                entity.Property(e => e.StLeftHand).HasColumnName("ST_left_hand");

                entity.Property(e => e.StLegs).HasColumnName("ST_legs");

                entity.Property(e => e.StNeck).HasColumnName("ST_neck");

                entity.Property(e => e.StRightEar).HasColumnName("ST_right_ear");

                entity.Property(e => e.StRightFinger).HasColumnName("ST_right_finger");

                entity.Property(e => e.StRightHand).HasColumnName("ST_right_hand");

                entity.Property(e => e.StUnderware).HasColumnName("ST_underware");

                entity.Property(e => e.Subjob0Class)
                    .HasColumnName("subjob0_class")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Subjob1Class)
                    .HasColumnName("subjob1_class")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Subjob2Class)
                    .HasColumnName("subjob2_class")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Subjob3Class)
                    .HasColumnName("subjob3_class")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");

                entity.Property(e => e.SurrenderWarId).HasColumnName("surrender_war_id");

                entity.Property(e => e.TempDeleteDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("temp_delete_date");

                entity.Property(e => e.TitleColor).HasColumnName("title_color");

                entity.Property(e => e.UseTime).HasColumnName("use_time");

                entity.Property(e => e.VipLevel).HasColumnName("vip_level");

                entity.Property(e => e.VipTimestamp).HasColumnName("vip_timestamp");

                entity.Property(e => e.VisualArmorId).HasColumnName("visual_armor_id");

                entity.Property(e => e.World).HasColumnName("world");

                entity.Property(e => e.Xloc).HasColumnName("xloc");

                entity.Property(e => e.Yloc).HasColumnName("yloc");

                entity.Property(e => e.Zloc).HasColumnName("zloc");
            });

            modelBuilder.Entity<UserDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_deleted");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_date");
            });

            modelBuilder.Entity<UserFriend>(entity =>
            {
                entity.HasKey(e => new { e.CharId, e.FriendCharId });

                entity.ToTable("user_friend");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.FriendCharId).HasColumnName("friend_char_id");

                entity.Property(e => e.FriendCharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("friend_char_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserHenna>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.ToTable("user_henna");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.Henna1).HasColumnName("henna_1");

                entity.Property(e => e.Henna2).HasColumnName("henna_2");

                entity.Property(e => e.Henna3).HasColumnName("henna_3");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");
            });

            modelBuilder.Entity<UserHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_history");

                entity.HasIndex(e => e.CharName, "IX_user_history")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("account_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CharName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.LogAction).HasColumnName("log_action");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserInstance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_instance");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.InstanceId).HasColumnName("instance_id");

                entity.Property(e => e.ReuseTimeout).HasColumnName("reuse_timeout");

                entity.Property(e => e.TimeSpent).HasColumnName("time_spent");
            });

            modelBuilder.Entity<UserItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("pk_user_item")
                    .IsClustered(false);

                entity.ToTable("user_item");

                entity.HasIndex(e => e.ItemType, "idx_item_type")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.CharId, "idx_user_item_charid")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Warehouse, "idx_useritem_ware")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.Warehouse, "idx_warehouse")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Augmentation).HasColumnName("augmentation");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LifeTime).HasColumnName("life_time");

                entity.Property(e => e.ManaLeft).HasColumnName("mana_left");

                entity.Property(e => e.ProtectionTimeout).HasColumnName("protection_timeout");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<UserJournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_journal");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.IntData1).HasColumnName("int_data_1");

                entity.Property(e => e.IntData2).HasColumnName("int_data_2");

                entity.Property(e => e.LogData)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("log_data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlayTime).HasColumnName("play_time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_log");

                entity.HasIndex(e => new { e.CharId, e.LogId, e.LogTo }, "IX_user_log")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogFrom).HasColumnName("log_from");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogTo).HasColumnName("log_to");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");

                entity.Property(e => e.UseTime).HasColumnName("use_time");
            });

            modelBuilder.Entity<UserMacro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_macro");

                entity.HasIndex(e => new { e.CharId, e.MacroId }, "IX_user_macro")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.MacroIconname)
                    .HasMaxLength(64)
                    .HasColumnName("macro_iconname")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.MacroIcontype).HasColumnName("macro_icontype");

                entity.Property(e => e.MacroId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("macro_id");

                entity.Property(e => e.MacroName)
                    .HasMaxLength(64)
                    .HasColumnName("macro_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.MacroTooltip)
                    .HasMaxLength(64)
                    .HasColumnName("macro_tooltip")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserMacroinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_macroinfo");

                entity.HasIndex(e => new { e.MacroId, e.MacroOrder }, "IX_user_macroinfo")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.MacroId).HasColumnName("macro_id");

                entity.Property(e => e.MacroInt1).HasColumnName("macro_int1");

                entity.Property(e => e.MacroInt2).HasColumnName("macro_int2");

                entity.Property(e => e.MacroInt3).HasColumnName("macro_int3");

                entity.Property(e => e.MacroOrder).HasColumnName("macro_order");

                entity.Property(e => e.MacroStr)
                    .HasMaxLength(255)
                    .HasColumnName("macro_str")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserMail>(entity =>
            {
                entity.ToTable("user_mail");

                entity.HasIndex(e => e.Id, "IX_user_mail_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(3500)
                    .HasColumnName("content")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("title")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserMailReceiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_mail_receiver");

                entity.HasIndex(e => e.MailId, "IX_user_mail_receiver_1");

                entity.HasIndex(e => new { e.ReceiverId, e.ReadStatus, e.Deleted }, "IX_user_mail_receiver_2");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.MailId).HasColumnName("mail_id");

                entity.Property(e => e.MailboxType).HasColumnName("mailbox_type");

                entity.Property(e => e.ReadDate)
                    .HasColumnType("datetime")
                    .HasColumnName("read_date");

                entity.Property(e => e.ReadStatus).HasColumnName("read_status");

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("receiver_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserMailSender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_mail_sender");

                entity.HasIndex(e => new { e.SenderId, e.MailboxType, e.Deleted }, "IX_user_mail_sender")
                    .IsClustered();

                entity.HasIndex(e => e.MailId, "IX_user_mail_sender_1");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.MailId).HasColumnName("mail_id");

                entity.Property(e => e.MailType).HasColumnName("mail_type");

                entity.Property(e => e.MailboxType)
                    .HasColumnName("mailbox_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceiverNameList)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("receiver_name_list")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.RelatedId).HasColumnName("related_id");

                entity.Property(e => e.SendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("send_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sender_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserNameColor>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.ToTable("user_name_color");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.ColorRgb).HasColumnName("color_rgb");
            });

            modelBuilder.Entity<UserNameReserved>(entity =>
            {
                entity.HasKey(e => e.CharName);

                entity.ToTable("user_name_reserved");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Used).HasColumnName("used");
            });

            modelBuilder.Entity<UserNewbie>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("user_newbie");

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("account_id");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.NewbieStat).HasColumnName("newbie_stat");
            });

            modelBuilder.Entity<UserNobless>(entity =>
            {
                entity.HasKey(e => e.CharId)
                    .HasName("PK__user_nob__2D4B233921DF2C68");

                entity.ToTable("user_nobless");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.HeroType)
                    .HasColumnName("hero_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistoryOpen)
                    .HasColumnName("history_open")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MatchCount)
                    .HasColumnName("match_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoblessType)
                    .HasColumnName("nobless_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OlympiadLoseCount)
                    .HasColumnName("olympiad_lose_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OlympiadPoint)
                    .HasColumnName("olympiad_point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OlympiadWinCount)
                    .HasColumnName("olympiad_win_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreviousPoint)
                    .HasColumnName("previous_point")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WinCount)
                    .HasColumnName("win_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Words)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("words")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserPin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_pin");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Pin).HasColumnName("pin");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<UserProhibit>(entity =>
            {
                entity.HasKey(e => e.CharName);

                entity.ToTable("user_prohibit");

                entity.Property(e => e.CharName)
                    .HasMaxLength(50)
                    .HasColumnName("char_name")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserProhibitWord>(entity =>
            {
                entity.HasKey(e => e.Words);

                entity.ToTable("user_prohibit_word");

                entity.Property(e => e.Words)
                    .HasMaxLength(50)
                    .HasColumnName("words")
                    .HasComment("Korean_Wansung_CI_AS");
            });

            modelBuilder.Entity<UserPunish>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_punish");

                entity.HasIndex(e => new { e.CharId, e.PunishId }, "IX_user_punish")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.PunishDate)
                    .HasColumnType("datetime")
                    .HasColumnName("punish_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PunishId).HasColumnName("punish_id");

                entity.Property(e => e.PunishOn).HasColumnName("punish_on");

                entity.Property(e => e.PunishSeconds).HasColumnName("punish_seconds");

                entity.Property(e => e.RemainGame).HasColumnName("remain_game");

                entity.Property(e => e.RemainReal).HasColumnName("remain_real");
            });

            modelBuilder.Entity<UserRebirth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_rebirth");

                entity.Property(e => e.AvailablePoints).HasColumnName("available_points");

                entity.Property(e => e.BonusCon).HasColumnName("bonus_con");

                entity.Property(e => e.BonusDex).HasColumnName("bonus_dex");

                entity.Property(e => e.BonusInt).HasColumnName("bonus_int");

                entity.Property(e => e.BonusMen).HasColumnName("bonus_men");

                entity.Property(e => e.BonusStr).HasColumnName("bonus_str");

                entity.Property(e => e.BonusWit).HasColumnName("bonus_wit");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.RebirthCount).HasColumnName("rebirth_count");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");
            });

            modelBuilder.Entity<UserRecipe>(entity =>
            {
                entity.HasKey(e => new { e.CharId, e.RecipeId });

                entity.ToTable("user_recipe");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            });

            modelBuilder.Entity<UserSchemeBuffer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_scheme_buffer");

                entity.Property(e => e.B0).HasColumnName("b0");

                entity.Property(e => e.B1).HasColumnName("b1");

                entity.Property(e => e.B10).HasColumnName("b10");

                entity.Property(e => e.B11).HasColumnName("b11");

                entity.Property(e => e.B12).HasColumnName("b12");

                entity.Property(e => e.B13).HasColumnName("b13");

                entity.Property(e => e.B14).HasColumnName("b14");

                entity.Property(e => e.B15).HasColumnName("b15");

                entity.Property(e => e.B16).HasColumnName("b16");

                entity.Property(e => e.B17).HasColumnName("b17");

                entity.Property(e => e.B18).HasColumnName("b18");

                entity.Property(e => e.B19).HasColumnName("b19");

                entity.Property(e => e.B2).HasColumnName("b2");

                entity.Property(e => e.B20).HasColumnName("b20");

                entity.Property(e => e.B21).HasColumnName("b21");

                entity.Property(e => e.B22).HasColumnName("b22");

                entity.Property(e => e.B23).HasColumnName("b23");

                entity.Property(e => e.B24).HasColumnName("b24");

                entity.Property(e => e.B25).HasColumnName("b25");

                entity.Property(e => e.B26).HasColumnName("b26");

                entity.Property(e => e.B27).HasColumnName("b27");

                entity.Property(e => e.B28).HasColumnName("b28");

                entity.Property(e => e.B29).HasColumnName("b29");

                entity.Property(e => e.B3).HasColumnName("b3");

                entity.Property(e => e.B30).HasColumnName("b30");

                entity.Property(e => e.B31).HasColumnName("b31");

                entity.Property(e => e.B32).HasColumnName("b32");

                entity.Property(e => e.B33).HasColumnName("b33");

                entity.Property(e => e.B34).HasColumnName("b34");

                entity.Property(e => e.B35).HasColumnName("b35");

                entity.Property(e => e.B36).HasColumnName("b36");

                entity.Property(e => e.B37).HasColumnName("b37");

                entity.Property(e => e.B38).HasColumnName("b38");

                entity.Property(e => e.B39).HasColumnName("b39");

                entity.Property(e => e.B4).HasColumnName("b4");

                entity.Property(e => e.B40).HasColumnName("b40");

                entity.Property(e => e.B41).HasColumnName("b41");

                entity.Property(e => e.B42).HasColumnName("b42");

                entity.Property(e => e.B43).HasColumnName("b43");

                entity.Property(e => e.B44).HasColumnName("b44");

                entity.Property(e => e.B45).HasColumnName("b45");

                entity.Property(e => e.B46).HasColumnName("b46");

                entity.Property(e => e.B47).HasColumnName("b47");

                entity.Property(e => e.B5).HasColumnName("b5");

                entity.Property(e => e.B6).HasColumnName("b6");

                entity.Property(e => e.B7).HasColumnName("b7");

                entity.Property(e => e.B8).HasColumnName("b8");

                entity.Property(e => e.B9).HasColumnName("b9");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.SubjobIndex).HasColumnName("subjob_index");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.HasKey(e => new { e.CharId, e.SkillId, e.SubjobId });

                entity.ToTable("user_skill");

                entity.HasIndex(e => e.SkillLev, "idx_skill_lev")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ToEndTime, "idx_skill_toend")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");

                entity.Property(e => e.SkillLev).HasColumnName("skill_lev");

                entity.Property(e => e.ToEndTime).HasColumnName("to_end_time");
            });

            modelBuilder.Entity<UserSkillOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_skill_old");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SkillLev).HasColumnName("skill_lev");

                entity.Property(e => e.ToEndTime).HasColumnName("to_end_time");
            });

            modelBuilder.Entity<UserSociality>(entity =>
            {
                entity.HasKey(e => e.CharId);

                entity.ToTable("user_sociality");

                entity.Property(e => e.CharId)
                    .ValueGeneratedNever()
                    .HasColumnName("char_id");

                entity.Property(e => e.LastChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("last_changed");

                entity.Property(e => e.Sociality).HasColumnName("sociality");

                entity.Property(e => e.UsedSulffrage).HasColumnName("used_sulffrage");
            });

            modelBuilder.Entity<UserSubjob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_subjob");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.Henna1).HasColumnName("henna_1");

                entity.Property(e => e.Henna2).HasColumnName("henna_2");

                entity.Property(e => e.Henna3).HasColumnName("henna_3");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Mp).HasColumnName("mp");

                entity.Property(e => e.Sp).HasColumnName("sp");

                entity.Property(e => e.SubjobId).HasColumnName("subjob_id");
            });

            modelBuilder.Entity<UserSurrender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_surrender");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.SurrenderWarId).HasColumnName("surrender_war_id");
            });

            modelBuilder.Entity<UserVote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_vote");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.VotePoints).HasColumnName("vote_points");

                entity.Property(e => e.VoteTimestamp).HasColumnName("vote_timestamp");
            });

            modelBuilder.Entity<UserWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_warehouse");

                entity.HasIndex(e => e.CharId, "idx_user_warehouse_charid")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ItemId, "idx_user_warehouse_itemid")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.ItemType, "idx_user_warehouse_itemtype")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Bless).HasColumnName("bless");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.Enchant).HasColumnName("enchant");

                entity.Property(e => e.Eroded).HasColumnName("eroded");

                entity.Property(e => e.Ident).HasColumnName("ident");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.Wished).HasColumnName("wished");
            });

            modelBuilder.Entity<UserWedding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_wedding");

                entity.Property(e => e.CharId).HasColumnName("char_id");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("partner_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PenaltyTimeout).HasColumnName("penalty_timeout");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TeleportTimeout).HasColumnName("teleport_timeout");

                entity.Property(e => e.WeddingTime).HasColumnName("wedding_time");
            });

            modelBuilder.Entity<WarDeclare>(entity =>
            {
                entity.HasKey(e => new { e.Challenger, e.Challengee });

                entity.ToTable("war_declare");

                entity.Property(e => e.Challenger).HasColumnName("challenger");

                entity.Property(e => e.Challengee).HasColumnName("challengee");

                entity.Property(e => e.DeclareTime).HasColumnName("declare_time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
