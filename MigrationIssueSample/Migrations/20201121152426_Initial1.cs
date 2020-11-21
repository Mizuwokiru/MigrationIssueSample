using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationIssueSample.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account_ch2",
                columns: table => new
                {
                    account = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AdditionalBox",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "agit",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    pledge_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    auction_price = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    auction_date = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    hp_stove = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    mp_flame = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    hatcher = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    hp_stove_expire = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    mp_flame_expire = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((2))"),
                    next_war_time = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    auction_id = table.Column<int>(type: "int", nullable: true),
                    last_price = table.Column<int>(type: "int", nullable: true),
                    last_cancel = table.Column<int>(type: "int", nullable: true),
                    teleport_level = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    teleport_expire = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    next_cost = table.Column<int>(type: "int", nullable: true),
                    cost_fail = table.Column<int>(type: "int", nullable: true),
                    tax_rate = table.Column<int>(type: "int", nullable: false),
                    shop_income = table.Column<int>(type: "int", nullable: false),
                    tax_rate_to_change = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((-1))"),
                    tax_child_rate = table.Column<short>(type: "smallint", nullable: false),
                    tax_child_rate_to_change = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((-1))"),
                    shop_income_temp = table.Column<int>(type: "int", nullable: false),
                    team_battle_status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "agit_adena",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: true),
                    pledge_id = table.Column<int>(type: "int", nullable: true),
                    auction_id = table.Column<int>(type: "int", nullable: true),
                    reason = table.Column<int>(type: "int", nullable: true),
                    adena = table.Column<int>(type: "int", nullable: true),
                    log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "agit_auction",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: true),
                    auction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    auction_desc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    min_price = table.Column<int>(type: "int", nullable: true),
                    accepted_bid = table.Column<int>(type: "int", nullable: true),
                    auction_time = table.Column<int>(type: "int", nullable: true),
                    auction_tax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "agit_bid",
                columns: table => new
                {
                    auction_id = table.Column<int>(type: "int", nullable: true),
                    attend_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attend_price = table.Column<int>(type: "int", nullable: true),
                    attend_pledge_id = table.Column<int>(type: "int", nullable: true),
                    attend_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    attend_time = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "agit_deco",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    level = table.Column<int>(type: "int", nullable: true),
                    expire = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agit_deco", x => new { x.agit_id, x.type });
                });

            migrationBuilder.CreateTable(
                name: "Alliance",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    master_pledge_id = table.Column<int>(type: "int", nullable: false),
                    oust_time = table.Column<int>(type: "int", nullable: false),
                    crest_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliance", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Auction",
                columns: table => new
                {
                    auction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seller_id = table.Column<int>(type: "int", nullable: false),
                    seller_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, defaultValueSql: "(N'')"),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    augmentation = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    expire_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AuctionPayment",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    price_id = table.Column<int>(type: "int", nullable: false),
                    price_amount = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    item_amount = table.Column<int>(type: "int", nullable: false),
                    buyer = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "banned_account",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banned_account", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "BannedHardwareId",
                columns: table => new
                {
                    hardware_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'00000000000000000000000000000000')"),
                    account = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, defaultValueSql: "(N'')"),
                    gm = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, defaultValueSql: "(N'')"),
                    timeout = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "bookmark",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    world = table.Column<int>(type: "int", nullable: true),
                    x = table.Column<int>(type: "int", nullable: true),
                    y = table.Column<int>(type: "int", nullable: true),
                    z = table.Column<int>(type: "int", nullable: true),
                    bookmarkid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "builder_account",
                columns: table => new
                {
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    default_builder = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_builder", x => x.account_name);
                });

            migrationBuilder.CreateTable(
                name: "castle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    next_war_time = table.Column<int>(type: "int", nullable: false),
                    tax_rate = table.Column<short>(type: "smallint", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))"),
                    status = table.Column<byte>(type: "tinyint", nullable: false),
                    crop_income = table.Column<int>(type: "int", nullable: false),
                    shop_income = table.Column<int>(type: "int", nullable: false),
                    siege_elapsed_time = table.Column<int>(type: "int", nullable: false),
                    tax_child_rate = table.Column<int>(type: "int", nullable: false),
                    shop_income_temp = table.Column<int>(type: "int", nullable: false),
                    tax_rate_to_change = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((-1))"),
                    tax_child_rate_to_change = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((-1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_castle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "castle_crop",
                columns: table => new
                {
                    castle_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    dropRate = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_castle_crop", x => new { x.castle_id, x.item_type });
                });

            migrationBuilder.CreateTable(
                name: "castle_tax",
                columns: table => new
                {
                    income_update_t = table.Column<int>(type: "int", nullable: false),
                    tax_change_t = table.Column<int>(type: "int", nullable: false),
                    manor_reset_t = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "castle_war",
                columns: table => new
                {
                    castle_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    propose_time = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ch2_temp",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false),
                    account = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    last_login = table.Column<DateTime>(type: "datetime", nullable: true),
                    last_world = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ch3_lotto_char",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_count = table.Column<int>(type: "int", nullable: true),
                    round_number = table.Column<int>(type: "int", nullable: true),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    number_flag = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ch3_lott__2D4B2339B4154CAD", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "char_pet",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    pet_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CharacterLock",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    code_hash = table.Column<string>(type: "nvarchar(33)", maxLength: 33, nullable: false, defaultValueSql: "(N'')"),
                    hardware_id = table.Column<string>(type: "nvarchar(33)", maxLength: 33, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "class_list",
                columns: table => new
                {
                    @class = table.Column<short>(name: "class", type: "smallint", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    race = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "control_tower",
                columns: table => new
                {
                    name = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    control_level = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    hp = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__control___72E12F1A05A8BA76", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "DBNpcMaker",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    npc_id = table.Column<int>(type: "int", nullable: false),
                    spawn_x = table.Column<int>(type: "int", nullable: false),
                    spawn_y = table.Column<int>(type: "int", nullable: false),
                    spawn_z = table.Column<int>(type: "int", nullable: false),
                    heading = table.Column<int>(type: "int", nullable: false),
                    start_time = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(datediff(second,'1970-01-01 00:00:00',getutcdate()))"),
                    end_time = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(datediff(second,'1970-01-01 00:00:00',getutcdate())+(2592000))"),
                    comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "door",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    hp = table.Column<int>(type: "int", nullable: false),
                    max_hp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_door", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "dt_adena_rank_temp",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_item_1",
                columns: table => new
                {
                    etc_num5 = table.Column<int>(type: "int", nullable: true),
                    str_actor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    actor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_pet1_9_28",
                columns: table => new
                {
                    uiid = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<byte>(type: "tinyint", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    act_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_id = table.Column<short>(type: "smallint", nullable: true),
                    actor = table.Column<int>(type: "int", nullable: true),
                    actor_account = table.Column<int>(type: "int", nullable: true),
                    target = table.Column<int>(type: "int", nullable: true),
                    target_account = table.Column<int>(type: "int", nullable: true),
                    location_x = table.Column<int>(type: "int", nullable: true),
                    location_y = table.Column<int>(type: "int", nullable: true),
                    location_z = table.Column<int>(type: "int", nullable: true),
                    etc_str1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_num1 = table.Column<double>(type: "float", nullable: true),
                    etc_num2 = table.Column<double>(type: "float", nullable: true),
                    etc_num3 = table.Column<int>(type: "int", nullable: true),
                    etc_num4 = table.Column<int>(type: "int", nullable: true),
                    etc_num5 = table.Column<int>(type: "int", nullable: true),
                    etc_num6 = table.Column<int>(type: "int", nullable: true),
                    etc_num7 = table.Column<int>(type: "int", nullable: true),
                    etc_num8 = table.Column<int>(type: "int", nullable: true),
                    etc_num9 = table.Column<int>(type: "int", nullable: true),
                    etc_num10 = table.Column<int>(type: "int", nullable: true),
                    STR_actor = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_actor_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_pet1_9_30",
                columns: table => new
                {
                    uiid = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<byte>(type: "tinyint", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    act_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_id = table.Column<short>(type: "smallint", nullable: true),
                    actor = table.Column<int>(type: "int", nullable: true),
                    actor_account = table.Column<int>(type: "int", nullable: true),
                    target = table.Column<int>(type: "int", nullable: true),
                    target_account = table.Column<int>(type: "int", nullable: true),
                    location_x = table.Column<int>(type: "int", nullable: true),
                    location_y = table.Column<int>(type: "int", nullable: true),
                    location_z = table.Column<int>(type: "int", nullable: true),
                    etc_str1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_num1 = table.Column<double>(type: "float", nullable: true),
                    etc_num2 = table.Column<double>(type: "float", nullable: true),
                    etc_num3 = table.Column<int>(type: "int", nullable: true),
                    etc_num4 = table.Column<int>(type: "int", nullable: true),
                    etc_num5 = table.Column<int>(type: "int", nullable: true),
                    etc_num6 = table.Column<int>(type: "int", nullable: true),
                    etc_num7 = table.Column<int>(type: "int", nullable: true),
                    etc_num8 = table.Column<int>(type: "int", nullable: true),
                    etc_num9 = table.Column<int>(type: "int", nullable: true),
                    etc_num10 = table.Column<int>(type: "int", nullable: true),
                    STR_actor = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_actor_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_pet2_9_28",
                columns: table => new
                {
                    uiid = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<byte>(type: "tinyint", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    act_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_id = table.Column<short>(type: "smallint", nullable: true),
                    actor = table.Column<int>(type: "int", nullable: true),
                    actor_account = table.Column<int>(type: "int", nullable: true),
                    target = table.Column<int>(type: "int", nullable: true),
                    target_account = table.Column<int>(type: "int", nullable: true),
                    location_x = table.Column<int>(type: "int", nullable: true),
                    location_y = table.Column<int>(type: "int", nullable: true),
                    location_z = table.Column<int>(type: "int", nullable: true),
                    etc_str1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_num1 = table.Column<double>(type: "float", nullable: true),
                    etc_num2 = table.Column<double>(type: "float", nullable: true),
                    etc_num3 = table.Column<int>(type: "int", nullable: true),
                    etc_num4 = table.Column<int>(type: "int", nullable: true),
                    etc_num5 = table.Column<int>(type: "int", nullable: true),
                    etc_num6 = table.Column<int>(type: "int", nullable: true),
                    etc_num7 = table.Column<int>(type: "int", nullable: true),
                    etc_num8 = table.Column<int>(type: "int", nullable: true),
                    etc_num9 = table.Column<int>(type: "int", nullable: true),
                    etc_num10 = table.Column<int>(type: "int", nullable: true),
                    STR_actor = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_actor_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_pet2_9_30",
                columns: table => new
                {
                    uiid = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<byte>(type: "tinyint", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    act_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_id = table.Column<short>(type: "smallint", nullable: true),
                    actor = table.Column<int>(type: "int", nullable: true),
                    actor_account = table.Column<int>(type: "int", nullable: true),
                    target = table.Column<int>(type: "int", nullable: true),
                    target_account = table.Column<int>(type: "int", nullable: true),
                    location_x = table.Column<int>(type: "int", nullable: true),
                    location_y = table.Column<int>(type: "int", nullable: true),
                    location_z = table.Column<int>(type: "int", nullable: true),
                    etc_str1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_str3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    etc_num1 = table.Column<double>(type: "float", nullable: true),
                    etc_num2 = table.Column<double>(type: "float", nullable: true),
                    etc_num3 = table.Column<int>(type: "int", nullable: true),
                    etc_num4 = table.Column<int>(type: "int", nullable: true),
                    etc_num5 = table.Column<int>(type: "int", nullable: true),
                    etc_num6 = table.Column<int>(type: "int", nullable: true),
                    etc_num7 = table.Column<int>(type: "int", nullable: true),
                    etc_num8 = table.Column<int>(type: "int", nullable: true),
                    etc_num9 = table.Column<int>(type: "int", nullable: true),
                    etc_num10 = table.Column<int>(type: "int", nullable: true),
                    STR_actor = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_actor_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target = table.Column<string>(type: "varchar(48)", unicode: false, maxLength: 48, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    STR_target_account = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    iid = table.Column<int>(type: "int", nullable: true),
                    at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "err_skill_1",
                columns: table => new
                {
                    class_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    @class = table.Column<int>(name: "class", type: "int", nullable: true),
                    lev = table.Column<int>(type: "int", nullable: true),
                    skill_id = table.Column<int>(type: "int", nullable: true),
                    skill_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "event_items",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    class_id = table.Column<int>(type: "int", nullable: true),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "event_point",
                columns: table => new
                {
                    point_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_id = table.Column<int>(type: "int", nullable: true),
                    group_point = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0.0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "item_amount0_backup",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: true),
                    char_id = table.Column<int>(type: "int", nullable: true),
                    item_type = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: true),
                    enchant = table.Column<int>(type: "int", nullable: true),
                    eroded = table.Column<int>(type: "int", nullable: true),
                    bless = table.Column<int>(type: "int", nullable: true),
                    ident = table.Column<int>(type: "int", nullable: true),
                    wished = table.Column<int>(type: "int", nullable: true),
                    warehouse = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "item_classid_normal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_classid_normal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "item_market_price",
                columns: table => new
                {
                    item_type = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    avg_price = table.Column<double>(type: "float", nullable: false),
                    frequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "item_temp",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ItemData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    logdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    consumetype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    IsQuest = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ItemDelivery",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    item_amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KillDeathStat",
                columns: table => new
                {
                    victim_id = table.Column<int>(type: "int", nullable: false),
                    victim_class_id = table.Column<int>(type: "int", nullable: false),
                    victim_level = table.Column<int>(type: "int", nullable: false),
                    killer_id = table.Column<int>(type: "int", nullable: false),
                    killer_class_id = table.Column<int>(type: "int", nullable: false),
                    killer_level = table.Column<int>(type: "int", nullable: false),
                    killer_hp = table.Column<int>(type: "int", nullable: false),
                    killer_max_hp = table.Column<int>(type: "int", nullable: false),
                    killer_cp = table.Column<int>(type: "int", nullable: false),
                    killer_max_cp = table.Column<int>(type: "int", nullable: false),
                    x = table.Column<int>(type: "int", nullable: false),
                    y = table.Column<int>(type: "int", nullable: false),
                    z = table.Column<int>(type: "int", nullable: false),
                    pvp = table.Column<int>(type: "int", nullable: false),
                    skill_id = table.Column<int>(type: "int", nullable: false),
                    skill_level = table.Column<int>(type: "int", nullable: false),
                    death_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "L2NetworkVote",
                columns: table => new
                {
                    identity = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false, defaultValueSql: "(N'')"),
                    last_vote_time = table.Column<int>(type: "int", nullable: false),
                    last_reward_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LockedHardwareId",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    hardware_id = table.Column<string>(type: "nvarchar(33)", maxLength: 33, nullable: false, defaultValueSql: "(N'')"),
                    locked_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "login_announce",
                columns: table => new
                {
                    announce_id = table.Column<int>(type: "int", nullable: false),
                    announce_msg = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    interval_10 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "lotto_game",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<int>(type: "int", nullable: false),
                    left_time = table.Column<int>(type: "int", nullable: false),
                    chosen_number_flag = table.Column<int>(type: "int", nullable: false),
                    rule_number = table.Column<int>(type: "int", nullable: false),
                    winner1_count = table.Column<int>(type: "int", nullable: false),
                    winner2_count = table.Column<int>(type: "int", nullable: false),
                    winner3_count = table.Column<int>(type: "int", nullable: false),
                    winner4_count = table.Column<int>(type: "int", nullable: false),
                    total_count = table.Column<int>(type: "int", nullable: false),
                    carried_adena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lotto_game", x => x.round_number);
                });

            migrationBuilder.CreateTable(
                name: "lotto_game_backup_20050302",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<int>(type: "int", nullable: false),
                    left_time = table.Column<int>(type: "int", nullable: false),
                    chosen_number_flag = table.Column<int>(type: "int", nullable: false),
                    rule_number = table.Column<int>(type: "int", nullable: false),
                    winner1_count = table.Column<int>(type: "int", nullable: false),
                    winner2_count = table.Column<int>(type: "int", nullable: false),
                    winner3_count = table.Column<int>(type: "int", nullable: false),
                    winner4_count = table.Column<int>(type: "int", nullable: false),
                    total_count = table.Column<int>(type: "int", nullable: false),
                    carried_adena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "lotto_items",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    number_flag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "manor_data",
                columns: table => new
                {
                    manor_id = table.Column<int>(type: "int", nullable: false),
                    data_index = table.Column<int>(type: "int", nullable: false),
                    seed_id = table.Column<int>(type: "int", nullable: false),
                    seed_price = table.Column<int>(type: "int", nullable: false),
                    seed_sell_count = table.Column<int>(type: "int", nullable: false),
                    seed_remain_count = table.Column<int>(type: "int", nullable: false),
                    crop_id = table.Column<int>(type: "int", nullable: false),
                    crop_buy_count = table.Column<int>(type: "int", nullable: false),
                    crop_price = table.Column<int>(type: "int", nullable: false),
                    crop_type = table.Column<int>(type: "int", nullable: false),
                    crop_remain_count = table.Column<int>(type: "int", nullable: false),
                    crop_deposit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manor_data", x => new { x.manor_id, x.data_index });
                });

            migrationBuilder.CreateTable(
                name: "manor_data_n",
                columns: table => new
                {
                    manor_id = table.Column<int>(type: "int", nullable: false),
                    data_index = table.Column<int>(type: "int", nullable: false),
                    seed_id_n = table.Column<int>(type: "int", nullable: false),
                    seed_price_n = table.Column<int>(type: "int", nullable: false),
                    seed_sell_count_n = table.Column<int>(type: "int", nullable: false),
                    crop_id_n = table.Column<int>(type: "int", nullable: false),
                    crop_buy_count_n = table.Column<int>(type: "int", nullable: false),
                    crop_price_n = table.Column<int>(type: "int", nullable: false),
                    crop_type_n = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manor_data_n", x => new { x.manor_id, x.data_index });
                });

            migrationBuilder.CreateTable(
                name: "manor_fix",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    error_amount = table.Column<int>(type: "int", nullable: true),
                    to_dec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "manor_info",
                columns: table => new
                {
                    manor_id = table.Column<int>(type: "int", nullable: false),
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    adena_vault = table.Column<int>(type: "int", nullable: false),
                    crop_buy_vault = table.Column<int>(type: "int", nullable: false),
                    change_state = table.Column<byte>(type: "tinyint", nullable: false),
                    last_changed_t = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manor_info", x => x.manor_id);
                });

            migrationBuilder.CreateTable(
                name: "map",
                columns: table => new
                {
                    map2 = table.Column<int>(type: "int", nullable: true),
                    x2 = table.Column<int>(type: "int", nullable: true),
                    y2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mercenary",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    npc_id = table.Column<int>(type: "int", nullable: false),
                    x = table.Column<int>(type: "int", nullable: false),
                    y = table.Column<int>(type: "int", nullable: false),
                    z = table.Column<int>(type: "int", nullable: false),
                    angle = table.Column<int>(type: "int", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: false),
                    mp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "monrace",
                columns: table => new
                {
                    race_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    make_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    lane1 = table.Column<short>(type: "smallint", nullable: true),
                    lane2 = table.Column<short>(type: "smallint", nullable: true),
                    lane3 = table.Column<short>(type: "smallint", nullable: true),
                    lane4 = table.Column<short>(type: "smallint", nullable: true),
                    lane5 = table.Column<short>(type: "smallint", nullable: true),
                    lane6 = table.Column<short>(type: "smallint", nullable: true),
                    lane7 = table.Column<short>(type: "smallint", nullable: true),
                    lane8 = table.Column<short>(type: "smallint", nullable: true),
                    run1 = table.Column<double>(type: "float", nullable: true),
                    run2 = table.Column<double>(type: "float", nullable: true),
                    run3 = table.Column<double>(type: "float", nullable: true),
                    run4 = table.Column<double>(type: "float", nullable: true),
                    run5 = table.Column<double>(type: "float", nullable: true),
                    run6 = table.Column<double>(type: "float", nullable: true),
                    run7 = table.Column<double>(type: "float", nullable: true),
                    run8 = table.Column<double>(type: "float", nullable: true),
                    win1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    win2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    winrate1 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0.0))"),
                    winrate2 = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0.0))"),
                    race_end = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    tax_rate = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "monrace_mon",
                columns: table => new
                {
                    runner_id = table.Column<int>(type: "int", nullable: true),
                    initial_win = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    run_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    win_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "monrace_ticket",
                columns: table => new
                {
                    ticket_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monraceid = table.Column<int>(type: "int", nullable: true),
                    bet_type = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    bet_1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    bet_2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    bet_3 = table.Column<short>(type: "smallint", nullable: true),
                    bet_money = table.Column<int>(type: "int", nullable: true),
                    item_id = table.Column<int>(type: "int", nullable: true),
                    tax_money = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    deleted = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    remotefee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MultiSell_Log",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    price1_id = table.Column<int>(type: "int", nullable: false),
                    price1_count = table.Column<int>(type: "int", nullable: false),
                    price2_id = table.Column<int>(type: "int", nullable: false),
                    price2_count = table.Column<int>(type: "int", nullable: false),
                    price3_id = table.Column<int>(type: "int", nullable: false),
                    price3_count = table.Column<int>(type: "int", nullable: false),
                    price4_id = table.Column<int>(type: "int", nullable: false),
                    price4_count = table.Column<int>(type: "int", nullable: false),
                    price5_id = table.Column<int>(type: "int", nullable: false),
                    price5_count = table.Column<int>(type: "int", nullable: false),
                    reward1_id = table.Column<int>(type: "int", nullable: false),
                    reward1_count = table.Column<int>(type: "int", nullable: false),
                    reward2_id = table.Column<int>(type: "int", nullable: false),
                    reward2_count = table.Column<int>(type: "int", nullable: false),
                    reward3_id = table.Column<int>(type: "int", nullable: false),
                    reward3_count = table.Column<int>(type: "int", nullable: false),
                    reward4_id = table.Column<int>(type: "int", nullable: false),
                    reward4_count = table.Column<int>(type: "int", nullable: false),
                    reward5_id = table.Column<int>(type: "int", nullable: false),
                    reward5_count = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "nobless_achievements",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    win_type = table.Column<int>(type: "int", nullable: true),
                    target = table.Column<int>(type: "int", nullable: true),
                    win_time = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "npc_boss",
                columns: table => new
                {
                    npc_db_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    alive = table.Column<int>(type: "int", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: true),
                    mp = table.Column<int>(type: "int", nullable: true),
                    pos_x = table.Column<int>(type: "int", nullable: true),
                    pos_y = table.Column<int>(type: "int", nullable: true),
                    pos_z = table.Column<int>(type: "int", nullable: true),
                    time_low = table.Column<int>(type: "int", nullable: true),
                    time_high = table.Column<int>(type: "int", nullable: true),
                    i0 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NpcDeath",
                columns: table => new
                {
                    npc_class_id = table.Column<int>(type: "int", nullable: false),
                    death_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "npcname",
                columns: table => new
                {
                    npc_id = table.Column<int>(type: "int", nullable: true),
                    npc_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "object_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    owner_id = table.Column<int>(type: "int", nullable: false),
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    max_hp = table.Column<int>(type: "int", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: false),
                    x_pos = table.Column<int>(type: "int", nullable: false),
                    y_pos = table.Column<int>(type: "int", nullable: false),
                    z_pos = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_object_data", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OHEC_SUBJOB",
                columns: table => new
                {
                    server = table.Column<int>(type: "int", nullable: true),
                    All_75 = table.Column<int>(type: "int", nullable: true),
                    Sub0 = table.Column<int>(type: "int", nullable: true),
                    Sub1 = table.Column<int>(type: "int", nullable: true),
                    Sub2 = table.Column<int>(type: "int", nullable: true),
                    Sub3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OHEC_SUBJOB_TEMP",
                columns: table => new
                {
                    server = table.Column<int>(type: "int", nullable: true),
                    All_75 = table.Column<int>(type: "int", nullable: true),
                    Sub0 = table.Column<int>(type: "int", nullable: true),
                    Sub1 = table.Column<int>(type: "int", nullable: true),
                    Sub2 = table.Column<int>(type: "int", nullable: true),
                    Sub3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "olympiad",
                columns: table => new
                {
                    season = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    step = table.Column<int>(type: "int", nullable: true),
                    season_start_time = table.Column<int>(type: "int", nullable: true),
                    start_sec = table.Column<int>(type: "int", nullable: true),
                    bonus1_sec = table.Column<int>(type: "int", nullable: true),
                    bonus2_sec = table.Column<int>(type: "int", nullable: true),
                    bonus3_sec = table.Column<int>(type: "int", nullable: true),
                    bonus4_sec = table.Column<int>(type: "int", nullable: true),
                    nominate_sec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "olympiad_match",
                columns: table => new
                {
                    season = table.Column<int>(type: "int", nullable: true),
                    @class = table.Column<int>(name: "class", type: "int", nullable: true),
                    match_time = table.Column<int>(type: "int", nullable: true),
                    char_id = table.Column<int>(type: "int", nullable: true),
                    rival_id = table.Column<int>(type: "int", nullable: true),
                    point = table.Column<int>(type: "int", nullable: true),
                    is_winner = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "olympiad_result",
                columns: table => new
                {
                    season = table.Column<int>(type: "int", nullable: false),
                    @class = table.Column<int>(name: "class", type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    point = table.Column<int>(type: "int", nullable: false),
                    match_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_olympiad_result", x => new { x.season, x.@class, x.char_id });
                });

            migrationBuilder.CreateTable(
                name: "pet_data",
                columns: table => new
                {
                    pet_id = table.Column<int>(type: "int", nullable: false),
                    npc_class_id = table.Column<int>(type: "int", nullable: false),
                    expoint = table.Column<int>(type: "int", nullable: false),
                    nick_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    hp = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    mp = table.Column<double>(type: "float", nullable: false),
                    sp = table.Column<int>(type: "int", nullable: false),
                    meal = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    slot1 = table.Column<int>(type: "int", nullable: false),
                    slot2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet_data", x => x.pet_id);
                });

            migrationBuilder.CreateTable(
                name: "PetitionMsg",
                columns: table => new
                {
                    Char_Id = table.Column<int>(type: "int", nullable: false),
                    msg = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Pledge",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ruler_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    alliance_id = table.Column<int>(type: "int", nullable: false),
                    challenge_time = table.Column<int>(type: "int", nullable: false),
                    root_name_value = table.Column<int>(type: "int", nullable: false),
                    now_war_id = table.Column<int>(type: "int", nullable: false),
                    oust_time = table.Column<int>(type: "int", nullable: false),
                    skill_level = table.Column<short>(type: "smallint", nullable: false),
                    castle_id = table.Column<int>(type: "int", nullable: false),
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    name_value = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    private_flag = table.Column<int>(type: "int", nullable: false),
                    crest_id = table.Column<int>(type: "int", nullable: false),
                    is_guilty = table.Column<int>(type: "int", nullable: false),
                    dismiss_reserved_time = table.Column<int>(type: "int", nullable: false),
                    alliance_withdraw_time = table.Column<int>(type: "int", nullable: false),
                    alliance_dismiss_time = table.Column<int>(type: "int", nullable: false),
                    alliance_ousted_time = table.Column<int>(type: "int", nullable: false),
                    siege_kill = table.Column<int>(type: "int", nullable: false),
                    siege_death = table.Column<int>(type: "int", nullable: false),
                    emblem_id = table.Column<int>(type: "int", nullable: false),
                    delegate_clid = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge", x => x.pledge_id);
                });

            migrationBuilder.CreateTable(
                name: "pledge_announce",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    show_flag = table.Column<short>(type: "smallint", nullable: false),
                    content = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "pledge_contribution",
                columns: table => new
                {
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    contribution = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pledge_contribution", x => new { x.residence_id, x.pledge_id });
                });

            migrationBuilder.CreateTable(
                name: "Pledge_Crest",
                columns: table => new
                {
                    crest_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bitmap_size = table.Column<short>(type: "smallint", nullable: false),
                    bitmap = table.Column<byte[]>(type: "varbinary(3072)", maxLength: 3072, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge_Crest", x => x.crest_id);
                });

            migrationBuilder.CreateTable(
                name: "pledge_ext",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    reputation_points = table.Column<int>(type: "int", nullable: false),
                    Rank1 = table.Column<long>(type: "bigint", nullable: false),
                    Rank2 = table.Column<long>(type: "bigint", nullable: false),
                    Rank3 = table.Column<long>(type: "bigint", nullable: false),
                    Rank4 = table.Column<long>(type: "bigint", nullable: false),
                    Rank5 = table.Column<long>(type: "bigint", nullable: false),
                    Rank6 = table.Column<long>(type: "bigint", nullable: false),
                    Rank7 = table.Column<long>(type: "bigint", nullable: false),
                    Rank8 = table.Column<long>(type: "bigint", nullable: false),
                    Rank9 = table.Column<long>(type: "bigint", nullable: false),
                    Skill0 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill1 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill3 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill4 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill5 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill6 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill7 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill8 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill9 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill10 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill11 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill12 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill13 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill14 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill15 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill16 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill17 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill18 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill19 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill20 = table.Column<byte>(type: "tinyint", nullable: false),
                    Skill21 = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pledge_ext", x => x.pledge_id);
                });

            migrationBuilder.CreateTable(
                name: "pledge_skill",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    skill_id = table.Column<int>(type: "int", nullable: false),
                    skill_level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "pledge_subpledge",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    pledge_type = table.Column<int>(type: "int", nullable: false),
                    sub_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    leader_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    leader_dbid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "point",
                columns: table => new
                {
                    map = table.Column<int>(type: "int", nullable: true),
                    align = table.Column<int>(type: "int", nullable: true),
                    loc = table.Column<int>(type: "int", nullable: true),
                    x = table.Column<int>(type: "int", nullable: true),
                    y = table.Column<int>(type: "int", nullable: true),
                    z = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PrivateStore",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    store_type = table.Column<int>(type: "int", nullable: true),
                    x_loc = table.Column<int>(type: "int", nullable: true),
                    y_loc = table.Column<int>(type: "int", nullable: true),
                    z_loc = table.Column<int>(type: "int", nullable: true),
                    is_offline = table.Column<int>(type: "int", nullable: true),
                    item1_id = table.Column<int>(type: "int", nullable: true),
                    item1_count = table.Column<int>(type: "int", nullable: true),
                    item1_price = table.Column<int>(type: "int", nullable: true),
                    item1_enchant = table.Column<int>(type: "int", nullable: true),
                    item2_id = table.Column<int>(type: "int", nullable: true),
                    item2_count = table.Column<int>(type: "int", nullable: true),
                    item2_price = table.Column<int>(type: "int", nullable: true),
                    item2_enchant = table.Column<int>(type: "int", nullable: true),
                    item3_id = table.Column<int>(type: "int", nullable: true),
                    item3_count = table.Column<int>(type: "int", nullable: true),
                    item3_price = table.Column<int>(type: "int", nullable: true),
                    item3_enchant = table.Column<int>(type: "int", nullable: true),
                    item4_id = table.Column<int>(type: "int", nullable: true),
                    item4_count = table.Column<int>(type: "int", nullable: true),
                    item4_price = table.Column<int>(type: "int", nullable: true),
                    item4_enchant = table.Column<int>(type: "int", nullable: true),
                    item5_id = table.Column<int>(type: "int", nullable: true),
                    item5_count = table.Column<int>(type: "int", nullable: true),
                    item5_price = table.Column<int>(type: "int", nullable: true),
                    item5_enchant = table.Column<int>(type: "int", nullable: true),
                    item6_id = table.Column<int>(type: "int", nullable: true),
                    item6_count = table.Column<int>(type: "int", nullable: true),
                    item6_price = table.Column<int>(type: "int", nullable: true),
                    item6_enchant = table.Column<int>(type: "int", nullable: true),
                    item7_id = table.Column<int>(type: "int", nullable: true),
                    item7_count = table.Column<int>(type: "int", nullable: true),
                    item7_price = table.Column<int>(type: "int", nullable: true),
                    item7_enchant = table.Column<int>(type: "int", nullable: true),
                    item8_id = table.Column<int>(type: "int", nullable: true),
                    item8_count = table.Column<int>(type: "int", nullable: true),
                    item8_price = table.Column<int>(type: "int", nullable: true),
                    item8_enchant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "quest",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    q1 = table.Column<int>(type: "int", nullable: false),
                    s1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    q2 = table.Column<int>(type: "int", nullable: false),
                    s2 = table.Column<int>(type: "int", nullable: false),
                    q3 = table.Column<int>(type: "int", nullable: false),
                    s3 = table.Column<int>(type: "int", nullable: false),
                    q4 = table.Column<int>(type: "int", nullable: false),
                    s4 = table.Column<int>(type: "int", nullable: false),
                    q5 = table.Column<int>(type: "int", nullable: false),
                    s5 = table.Column<int>(type: "int", nullable: false),
                    q6 = table.Column<int>(type: "int", nullable: false),
                    s6 = table.Column<int>(type: "int", nullable: false),
                    q7 = table.Column<int>(type: "int", nullable: false),
                    s7 = table.Column<int>(type: "int", nullable: false),
                    q8 = table.Column<int>(type: "int", nullable: false),
                    s8 = table.Column<int>(type: "int", nullable: false),
                    q9 = table.Column<int>(type: "int", nullable: false),
                    s9 = table.Column<int>(type: "int", nullable: false),
                    q10 = table.Column<int>(type: "int", nullable: false),
                    s10 = table.Column<int>(type: "int", nullable: false),
                    q11 = table.Column<int>(type: "int", nullable: false),
                    s11 = table.Column<int>(type: "int", nullable: false),
                    q12 = table.Column<int>(type: "int", nullable: false),
                    s12 = table.Column<int>(type: "int", nullable: false),
                    q13 = table.Column<int>(type: "int", nullable: false),
                    s13 = table.Column<int>(type: "int", nullable: false),
                    q14 = table.Column<int>(type: "int", nullable: false),
                    s14 = table.Column<int>(type: "int", nullable: false),
                    q15 = table.Column<int>(type: "int", nullable: false),
                    s15 = table.Column<int>(type: "int", nullable: false),
                    q16 = table.Column<int>(type: "int", nullable: false),
                    s16 = table.Column<int>(type: "int", nullable: false),
                    j1 = table.Column<int>(type: "int", nullable: false),
                    j2 = table.Column<int>(type: "int", nullable: false),
                    j3 = table.Column<int>(type: "int", nullable: false),
                    j4 = table.Column<int>(type: "int", nullable: false),
                    j5 = table.Column<int>(type: "int", nullable: false),
                    j6 = table.Column<int>(type: "int", nullable: false),
                    j7 = table.Column<int>(type: "int", nullable: false),
                    j8 = table.Column<int>(type: "int", nullable: false),
                    j9 = table.Column<int>(type: "int", nullable: false),
                    j10 = table.Column<int>(type: "int", nullable: false),
                    j11 = table.Column<int>(type: "int", nullable: false),
                    j12 = table.Column<int>(type: "int", nullable: false),
                    j13 = table.Column<int>(type: "int", nullable: false),
                    j14 = table.Column<int>(type: "int", nullable: false),
                    j15 = table.Column<int>(type: "int", nullable: false),
                    j16 = table.Column<int>(type: "int", nullable: false),
                    s2_1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_3 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_4 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_5 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_6 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_7 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_8 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_9 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_10 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_11 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_12 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_13 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_14 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_15 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    s2_16 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    q17 = table.Column<int>(type: "int", nullable: false),
                    s17 = table.Column<int>(type: "int", nullable: false),
                    q18 = table.Column<int>(type: "int", nullable: false),
                    s18 = table.Column<int>(type: "int", nullable: false),
                    q19 = table.Column<int>(type: "int", nullable: false),
                    s19 = table.Column<int>(type: "int", nullable: false),
                    q20 = table.Column<int>(type: "int", nullable: false),
                    s20 = table.Column<int>(type: "int", nullable: false),
                    q21 = table.Column<int>(type: "int", nullable: false),
                    s21 = table.Column<int>(type: "int", nullable: false),
                    q22 = table.Column<int>(type: "int", nullable: false),
                    s22 = table.Column<int>(type: "int", nullable: false),
                    q23 = table.Column<int>(type: "int", nullable: false),
                    s23 = table.Column<int>(type: "int", nullable: false),
                    q24 = table.Column<int>(type: "int", nullable: false),
                    s24 = table.Column<int>(type: "int", nullable: false),
                    q25 = table.Column<int>(type: "int", nullable: false),
                    s25 = table.Column<int>(type: "int", nullable: false),
                    q26 = table.Column<int>(type: "int", nullable: false),
                    s26 = table.Column<int>(type: "int", nullable: false),
                    j17 = table.Column<int>(type: "int", nullable: false),
                    j18 = table.Column<int>(type: "int", nullable: false),
                    j19 = table.Column<int>(type: "int", nullable: false),
                    j20 = table.Column<int>(type: "int", nullable: false),
                    j21 = table.Column<int>(type: "int", nullable: false),
                    j22 = table.Column<int>(type: "int", nullable: false),
                    j23 = table.Column<int>(type: "int", nullable: false),
                    j24 = table.Column<int>(type: "int", nullable: false),
                    j25 = table.Column<int>(type: "int", nullable: false),
                    j26 = table.Column<int>(type: "int", nullable: false),
                    s2_17 = table.Column<int>(type: "int", nullable: false),
                    s2_18 = table.Column<int>(type: "int", nullable: false),
                    s2_19 = table.Column<int>(type: "int", nullable: false),
                    s2_20 = table.Column<int>(type: "int", nullable: false),
                    s2_21 = table.Column<int>(type: "int", nullable: false),
                    s2_22 = table.Column<int>(type: "int", nullable: false),
                    s2_23 = table.Column<int>(type: "int", nullable: false),
                    s2_24 = table.Column<int>(type: "int", nullable: false),
                    s2_25 = table.Column<int>(type: "int", nullable: false),
                    s2_26 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QuestData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    data = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    logdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "req_char",
                columns: table => new
                {
                    server_id = table.Column<int>(type: "int", nullable: true),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "req_charmove",
                columns: table => new
                {
                    old_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    old_char_id = table.Column<int>(type: "int", nullable: true),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: true),
                    old_world_id = table.Column<int>(type: "int", nullable: true),
                    req_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    req_id = table.Column<int>(type: "int", nullable: false),
                    new_world_id = table.Column<int>(type: "int", nullable: true),
                    new_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    new_char_id = table.Column<int>(type: "int", nullable: true),
                    is_pc_bang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "req_charmove_old",
                columns: table => new
                {
                    old_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    old_char_id = table.Column<int>(type: "int", nullable: true),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: true),
                    old_world_id = table.Column<int>(type: "int", nullable: true),
                    req_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    req_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    new_world_id = table.Column<int>(type: "int", nullable: true),
                    new_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    new_char_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "req_pledge",
                columns: table => new
                {
                    server_id = table.Column<int>(type: "int", nullable: true),
                    pledge_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "residence_guard",
                columns: table => new
                {
                    x = table.Column<int>(type: "int", nullable: false),
                    y = table.Column<int>(type: "int", nullable: false),
                    z = table.Column<int>(type: "int", nullable: false),
                    residence_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    npc_id = table.Column<int>(type: "int", nullable: false),
                    guard_type = table.Column<int>(type: "int", nullable: false),
                    can_move = table.Column<int>(type: "int", nullable: false),
                    angle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_residence_guard", x => new { x.x, x.y, x.z });
                });

            migrationBuilder.CreateTable(
                name: "shortcut_data",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    slotnum = table.Column<int>(type: "int", nullable: false),
                    subjob_id = table.Column<int>(type: "int", nullable: false),
                    shortcut_type = table.Column<int>(type: "int", nullable: false),
                    shortcut_id = table.Column<int>(type: "int", nullable: false),
                    shortcut_macro = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shortcut_data", x => new { x.char_id, x.slotnum, x.subjob_id });
                });

            migrationBuilder.CreateTable(
                name: "siege_agit_pledge",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    propose_time = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SiegeStat",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    castle_id = table.Column<int>(type: "int", nullable: false),
                    kill_count = table.Column<int>(type: "int", nullable: true),
                    death_count = table.Column<int>(type: "int", nullable: true),
                    damage_taken = table.Column<int>(type: "int", nullable: true),
                    damage_dealt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SkillData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    lev = table.Column<short>(type: "smallint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    logdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    skill_desc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    bIsMagic = table.Column<byte>(type: "tinyint", nullable: true),
                    activate_type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillData", x => new { x.id, x.lev });
                });

            migrationBuilder.CreateTable(
                name: "ssq_data",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<byte>(type: "tinyint", nullable: false),
                    winner = table.Column<byte>(type: "tinyint", nullable: false),
                    event_start_time = table.Column<int>(type: "int", nullable: false),
                    seal_effect_time = table.Column<int>(type: "int", nullable: false),
                    event_end_time = table.Column<int>(type: "int", nullable: false),
                    seal_effect_end_time = table.Column<int>(type: "int", nullable: false),
                    seal1 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal2 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal3 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal4 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal5 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal6 = table.Column<byte>(type: "tinyint", nullable: false),
                    seal7 = table.Column<byte>(type: "tinyint", nullable: false),
                    last_changed_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    castle_snapshot_time = table.Column<int>(type: "int", nullable: true),
                    can_drop_guard = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ssq_join_data",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    point = table.Column<int>(type: "int", nullable: false),
                    main_event_point = table.Column<int>(type: "int", nullable: true),
                    collected_point = table.Column<int>(type: "int", nullable: true),
                    member_count = table.Column<int>(type: "int", nullable: false),
                    seal1_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal2_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal3_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal4_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal5_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal6_selection_count = table.Column<int>(type: "int", nullable: false),
                    seal7_selection_count = table.Column<int>(type: "int", nullable: false),
                    last_changed_time = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ssq_top_point_user",
                columns: table => new
                {
                    ssq_round = table.Column<int>(type: "int", nullable: false),
                    record_id = table.Column<int>(type: "int", nullable: false),
                    rank_time = table.Column<int>(type: "int", nullable: false),
                    ssq_point = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    ssq_part = table.Column<byte>(type: "tinyint", nullable: false),
                    ssq_position = table.Column<byte>(type: "tinyint", nullable: false),
                    seal_selection_no = table.Column<byte>(type: "tinyint", nullable: false),
                    last_changed_time = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ssq_user_data",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    round_number = table.Column<int>(type: "int", nullable: false),
                    ssq_part = table.Column<byte>(type: "tinyint", nullable: false),
                    ssq_position = table.Column<byte>(type: "tinyint", nullable: false),
                    seal_selection_no = table.Column<byte>(type: "tinyint", nullable: false),
                    ssq_join_time = table.Column<int>(type: "int", nullable: false),
                    ssq_point = table.Column<int>(type: "int", nullable: false),
                    twilight_a_item_num = table.Column<int>(type: "int", nullable: false),
                    twilight_b_item_num = table.Column<int>(type: "int", nullable: false),
                    twilight_c_item_num = table.Column<int>(type: "int", nullable: false),
                    dawn_a_item_num = table.Column<int>(type: "int", nullable: false),
                    dawn_b_item_num = table.Column<int>(type: "int", nullable: false),
                    dawn_c_item_num = table.Column<int>(type: "int", nullable: false),
                    ticket_buy_count = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_acc_class",
                columns: table => new
                {
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_acc_lev",
                columns: table => new
                {
                    lev = table.Column<byte>(type: "tinyint", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_acc_mlev",
                columns: table => new
                {
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    lev = table.Column<byte>(type: "tinyint", nullable: false),
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_acc_race",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_item_cnt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    sum = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_item_ent",
                columns: table => new
                {
                    item_type = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    sum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_item_ment",
                columns: table => new
                {
                    item_type = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    max_ent = table.Column<int>(type: "int", nullable: false),
                    builder = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "stat_item_mincnt",
                columns: table => new
                {
                    item_type = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SubStack",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    baseClass0 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    baseClass1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    baseClass2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    baseClass3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    stackClass0 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    stackClass1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    stackClass2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    stackClass3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "team_battle_agit_member",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    propose_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "team_battle_agit_pledge",
                columns: table => new
                {
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    propose_time = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<int>(type: "int", nullable: false),
                    npc_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_account",
                columns: table => new
                {
                    real_account = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    user_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_inv",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_pet_inv",
                columns: table => new
                {
                    pet_item_id = table.Column<int>(type: "int", nullable: false),
                    pet_item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    pet_collar_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_recipe",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    item_type = table.Column<int>(type: "int", nullable: true),
                    warehouse = table.Column<int>(type: "int", nullable: true),
                    recipecount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_skill",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    skill = table.Column<int>(type: "int", nullable: true),
                    lev = table.Column<int>(type: "int", nullable: true),
                    temptime = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_skill2",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    skill_id = table.Column<int>(type: "int", nullable: true),
                    skill_lev = table.Column<int>(type: "int", nullable: true),
                    temptime = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "temp_update",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEST",
                columns: table => new
                {
                    _ = table.Column<int>(name: "??", type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: true),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    lev = table.Column<byte>(type: "tinyint", nullable: true),
                    @class = table.Column<int>(name: "class", type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "time_attack_record",
                columns: table => new
                {
                    ssq_round = table.Column<int>(type: "int", nullable: false),
                    room_no = table.Column<byte>(type: "tinyint", nullable: false),
                    record_type = table.Column<byte>(type: "tinyint", nullable: false),
                    ssq_part = table.Column<byte>(type: "tinyint", nullable: false),
                    point = table.Column<int>(type: "int", nullable: false),
                    record_time = table.Column<int>(type: "int", nullable: false),
                    elapsed_time = table.Column<int>(type: "int", nullable: false),
                    member_count = table.Column<int>(type: "int", nullable: false),
                    member_names = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    member_dbid_list = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    member_reward_flags = table.Column<int>(type: "int", nullable: true),
                    fee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "time_attack_record_test",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col006 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col007 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col008 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col009 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col010 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col011 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    Col012 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "time_data",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false),
                    last_logout = table.Column<DateTime>(type: "datetime", nullable: false),
                    used_sec = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_char_data2", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "tmp_alliance",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    master_pledge_id = table.Column<int>(type: "int", nullable: false),
                    oust_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_die_user",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    account_name = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    before_die_exp = table.Column<int>(type: "int", nullable: true),
                    die_minus_exp = table.Column<int>(type: "int", nullable: true),
                    after_resurrect_exp = table.Column<int>(type: "int", nullable: true),
                    resurrect_add_exp = table.Column<int>(type: "int", nullable: true),
                    hasSubjob = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_lotto_price_given",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    char_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    rank = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    new_price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_pledge",
                columns: table => new
                {
                    pledge_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ruler_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    alliance_id = table.Column<int>(type: "int", nullable: false),
                    root_name_value = table.Column<int>(type: "int", nullable: false),
                    name_value = table.Column<int>(type: "int", nullable: false),
                    oust_time = table.Column<int>(type: "int", nullable: false),
                    skill_level = table.Column<short>(type: "smallint", nullable: false),
                    castle_id = table.Column<int>(type: "int", nullable: false),
                    agit_id = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    is_guilty = table.Column<int>(type: "int", nullable: false),
                    dismiss_reserved_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_recover_user",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    addedExp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_seed_dp",
                columns: table => new
                {
                    seed_id = table.Column<int>(type: "int", nullable: true),
                    dp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_user_data",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    char_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    builder = table.Column<byte>(type: "tinyint", nullable: false),
                    gender = table.Column<byte>(type: "tinyint", nullable: false),
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false),
                    world = table.Column<short>(type: "smallint", nullable: false),
                    SP = table.Column<int>(type: "int", nullable: false),
                    EXP = table.Column<int>(type: "int", nullable: false),
                    Lev = table.Column<byte>(type: "tinyint", nullable: false),
                    align = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    PKpardon = table.Column<int>(type: "int", nullable: false),
                    Duel = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    login = table.Column<DateTime>(type: "datetime", nullable: true),
                    logout = table.Column<DateTime>(type: "datetime", nullable: true),
                    nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    max_hp = table.Column<int>(type: "int", nullable: false),
                    max_mp = table.Column<int>(type: "int", nullable: false),
                    use_time = table.Column<int>(type: "int", nullable: false),
                    drop_exp = table.Column<int>(type: "int", nullable: false),
                    cp = table.Column<double>(type: "float", nullable: false),
                    max_cp = table.Column<double>(type: "float", nullable: false),
                    subjob_id = table.Column<int>(type: "int", nullable: true),
                    subjob0_class = table.Column<int>(type: "int", nullable: false),
                    subjob1_class = table.Column<int>(type: "int", nullable: false),
                    subjob2_class = table.Column<int>(type: "int", nullable: false),
                    subjob3_class = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_user_item",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tmp_user_nobless",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    nobless_type = table.Column<byte>(type: "tinyint", nullable: true),
                    hero_type = table.Column<byte>(type: "tinyint", nullable: true),
                    win_count = table.Column<int>(type: "int", nullable: true),
                    previous_point = table.Column<int>(type: "int", nullable: true),
                    olympiad_point = table.Column<int>(type: "int", nullable: true),
                    match_count = table.Column<int>(type: "int", nullable: true),
                    words = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_ActiveSkill",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    s1 = table.Column<int>(type: "int", nullable: true),
                    l1 = table.Column<byte>(type: "tinyint", nullable: true),
                    d1 = table.Column<int>(type: "int", nullable: true),
                    s2 = table.Column<int>(type: "int", nullable: true),
                    l2 = table.Column<byte>(type: "tinyint", nullable: true),
                    d2 = table.Column<int>(type: "int", nullable: true),
                    s3 = table.Column<int>(type: "int", nullable: true),
                    l3 = table.Column<byte>(type: "tinyint", nullable: true),
                    d3 = table.Column<int>(type: "int", nullable: true),
                    s4 = table.Column<int>(type: "int", nullable: true),
                    l4 = table.Column<byte>(type: "tinyint", nullable: true),
                    d4 = table.Column<int>(type: "int", nullable: true),
                    s5 = table.Column<int>(type: "int", nullable: true),
                    l5 = table.Column<byte>(type: "tinyint", nullable: true),
                    d5 = table.Column<int>(type: "int", nullable: true),
                    s6 = table.Column<int>(type: "int", nullable: true),
                    l6 = table.Column<byte>(type: "tinyint", nullable: true),
                    d6 = table.Column<int>(type: "int", nullable: true),
                    s7 = table.Column<int>(type: "int", nullable: true),
                    l7 = table.Column<byte>(type: "tinyint", nullable: true),
                    d7 = table.Column<int>(type: "int", nullable: true),
                    s8 = table.Column<int>(type: "int", nullable: true),
                    l8 = table.Column<byte>(type: "tinyint", nullable: true),
                    d8 = table.Column<int>(type: "int", nullable: true),
                    s9 = table.Column<int>(type: "int", nullable: true),
                    l9 = table.Column<byte>(type: "tinyint", nullable: true),
                    d9 = table.Column<int>(type: "int", nullable: true),
                    s10 = table.Column<int>(type: "int", nullable: true),
                    l10 = table.Column<byte>(type: "tinyint", nullable: true),
                    d10 = table.Column<int>(type: "int", nullable: true),
                    s11 = table.Column<int>(type: "int", nullable: true),
                    l11 = table.Column<byte>(type: "tinyint", nullable: true),
                    d11 = table.Column<int>(type: "int", nullable: true),
                    s12 = table.Column<int>(type: "int", nullable: true),
                    l12 = table.Column<byte>(type: "tinyint", nullable: true),
                    d12 = table.Column<int>(type: "int", nullable: true),
                    s13 = table.Column<int>(type: "int", nullable: true),
                    l13 = table.Column<byte>(type: "tinyint", nullable: true),
                    d13 = table.Column<int>(type: "int", nullable: true),
                    s14 = table.Column<int>(type: "int", nullable: true),
                    l14 = table.Column<byte>(type: "tinyint", nullable: true),
                    d14 = table.Column<int>(type: "int", nullable: true),
                    s15 = table.Column<int>(type: "int", nullable: true),
                    l15 = table.Column<byte>(type: "tinyint", nullable: true),
                    d15 = table.Column<int>(type: "int", nullable: true),
                    s16 = table.Column<int>(type: "int", nullable: true),
                    l16 = table.Column<byte>(type: "tinyint", nullable: true),
                    d16 = table.Column<int>(type: "int", nullable: true),
                    s17 = table.Column<int>(type: "int", nullable: true),
                    l17 = table.Column<byte>(type: "tinyint", nullable: true),
                    d17 = table.Column<int>(type: "int", nullable: true),
                    s18 = table.Column<int>(type: "int", nullable: true),
                    l18 = table.Column<byte>(type: "tinyint", nullable: true),
                    d18 = table.Column<int>(type: "int", nullable: true),
                    s19 = table.Column<int>(type: "int", nullable: true),
                    l19 = table.Column<byte>(type: "tinyint", nullable: true),
                    d19 = table.Column<int>(type: "int", nullable: true),
                    s20 = table.Column<int>(type: "int", nullable: true),
                    l20 = table.Column<byte>(type: "tinyint", nullable: true),
                    d20 = table.Column<int>(type: "int", nullable: true),
                    s21 = table.Column<int>(type: "int", nullable: true),
                    l21 = table.Column<byte>(type: "tinyint", nullable: true),
                    d21 = table.Column<int>(type: "int", nullable: true),
                    s22 = table.Column<int>(type: "int", nullable: true),
                    l22 = table.Column<byte>(type: "tinyint", nullable: true),
                    d22 = table.Column<int>(type: "int", nullable: true),
                    s23 = table.Column<int>(type: "int", nullable: true),
                    l23 = table.Column<byte>(type: "tinyint", nullable: true),
                    d23 = table.Column<int>(type: "int", nullable: true),
                    s24 = table.Column<int>(type: "int", nullable: true),
                    l24 = table.Column<byte>(type: "tinyint", nullable: true),
                    d24 = table.Column<int>(type: "int", nullable: true),
                    s25 = table.Column<int>(type: "int", nullable: true),
                    l25 = table.Column<byte>(type: "tinyint", nullable: true),
                    d25 = table.Column<int>(type: "int", nullable: true),
                    s26 = table.Column<int>(type: "int", nullable: true),
                    l26 = table.Column<byte>(type: "tinyint", nullable: true),
                    d26 = table.Column<int>(type: "int", nullable: true),
                    s27 = table.Column<int>(type: "int", nullable: true),
                    l27 = table.Column<byte>(type: "tinyint", nullable: true),
                    d27 = table.Column<int>(type: "int", nullable: true),
                    s28 = table.Column<int>(type: "int", nullable: true),
                    l28 = table.Column<byte>(type: "tinyint", nullable: true),
                    d28 = table.Column<int>(type: "int", nullable: true),
                    s29 = table.Column<int>(type: "int", nullable: true),
                    l29 = table.Column<byte>(type: "tinyint", nullable: true),
                    d29 = table.Column<int>(type: "int", nullable: true),
                    s30 = table.Column<int>(type: "int", nullable: true),
                    l30 = table.Column<byte>(type: "tinyint", nullable: true),
                    d30 = table.Column<int>(type: "int", nullable: true),
                    s31 = table.Column<int>(type: "int", nullable: true),
                    l31 = table.Column<byte>(type: "tinyint", nullable: true),
                    d31 = table.Column<int>(type: "int", nullable: true),
                    s32 = table.Column<int>(type: "int", nullable: true),
                    l32 = table.Column<byte>(type: "tinyint", nullable: true),
                    d32 = table.Column<int>(type: "int", nullable: true),
                    s33 = table.Column<int>(type: "int", nullable: true),
                    l33 = table.Column<byte>(type: "tinyint", nullable: true),
                    d33 = table.Column<int>(type: "int", nullable: true),
                    s34 = table.Column<int>(type: "int", nullable: true),
                    l34 = table.Column<byte>(type: "tinyint", nullable: true),
                    d34 = table.Column<int>(type: "int", nullable: true),
                    s35 = table.Column<int>(type: "int", nullable: true),
                    l35 = table.Column<byte>(type: "tinyint", nullable: true),
                    d35 = table.Column<int>(type: "int", nullable: true),
                    s36 = table.Column<int>(type: "int", nullable: true),
                    l36 = table.Column<byte>(type: "tinyint", nullable: true),
                    d36 = table.Column<int>(type: "int", nullable: true),
                    s37 = table.Column<int>(type: "int", nullable: true),
                    l37 = table.Column<byte>(type: "tinyint", nullable: true),
                    d37 = table.Column<int>(type: "int", nullable: true),
                    s38 = table.Column<int>(type: "int", nullable: true),
                    l38 = table.Column<byte>(type: "tinyint", nullable: true),
                    d38 = table.Column<int>(type: "int", nullable: true),
                    s39 = table.Column<int>(type: "int", nullable: true),
                    l39 = table.Column<byte>(type: "tinyint", nullable: true),
                    d39 = table.Column<int>(type: "int", nullable: true),
                    s40 = table.Column<int>(type: "int", nullable: true),
                    l40 = table.Column<byte>(type: "tinyint", nullable: true),
                    d40 = table.Column<int>(type: "int", nullable: true),
                    c1 = table.Column<byte>(type: "tinyint", nullable: true),
                    c2 = table.Column<byte>(type: "tinyint", nullable: true),
                    c3 = table.Column<byte>(type: "tinyint", nullable: true),
                    c4 = table.Column<byte>(type: "tinyint", nullable: true),
                    c5 = table.Column<byte>(type: "tinyint", nullable: true),
                    c6 = table.Column<byte>(type: "tinyint", nullable: true),
                    c7 = table.Column<byte>(type: "tinyint", nullable: true),
                    c8 = table.Column<byte>(type: "tinyint", nullable: true),
                    c9 = table.Column<byte>(type: "tinyint", nullable: true),
                    c10 = table.Column<byte>(type: "tinyint", nullable: true),
                    c11 = table.Column<byte>(type: "tinyint", nullable: true),
                    c12 = table.Column<byte>(type: "tinyint", nullable: true),
                    c13 = table.Column<byte>(type: "tinyint", nullable: true),
                    c14 = table.Column<byte>(type: "tinyint", nullable: true),
                    c15 = table.Column<byte>(type: "tinyint", nullable: true),
                    c16 = table.Column<byte>(type: "tinyint", nullable: true),
                    c17 = table.Column<byte>(type: "tinyint", nullable: true),
                    c18 = table.Column<byte>(type: "tinyint", nullable: true),
                    c19 = table.Column<byte>(type: "tinyint", nullable: true),
                    c20 = table.Column<byte>(type: "tinyint", nullable: true),
                    c21 = table.Column<byte>(type: "tinyint", nullable: true),
                    c22 = table.Column<byte>(type: "tinyint", nullable: true),
                    c23 = table.Column<byte>(type: "tinyint", nullable: true),
                    c24 = table.Column<byte>(type: "tinyint", nullable: true),
                    c25 = table.Column<byte>(type: "tinyint", nullable: true),
                    c26 = table.Column<byte>(type: "tinyint", nullable: true),
                    c27 = table.Column<byte>(type: "tinyint", nullable: true),
                    c28 = table.Column<byte>(type: "tinyint", nullable: true),
                    c29 = table.Column<byte>(type: "tinyint", nullable: true),
                    c30 = table.Column<byte>(type: "tinyint", nullable: true),
                    c31 = table.Column<byte>(type: "tinyint", nullable: true),
                    c32 = table.Column<byte>(type: "tinyint", nullable: true),
                    c33 = table.Column<byte>(type: "tinyint", nullable: true),
                    c34 = table.Column<byte>(type: "tinyint", nullable: true),
                    c35 = table.Column<byte>(type: "tinyint", nullable: true),
                    c36 = table.Column<byte>(type: "tinyint", nullable: true),
                    c37 = table.Column<byte>(type: "tinyint", nullable: true),
                    c38 = table.Column<byte>(type: "tinyint", nullable: true),
                    c39 = table.Column<byte>(type: "tinyint", nullable: true),
                    c40 = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_ban",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ban_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ban_hour = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    ban_end = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_ban", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_blocklist",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    block_char_id = table.Column<int>(type: "int", nullable: false),
                    block_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_blocklist", x => new { x.char_id, x.block_char_id });
                });

            migrationBuilder.CreateTable(
                name: "user_comment",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    char_id = table.Column<int>(type: "int", nullable: true),
                    comment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    comment_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    writer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    deleted = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_data",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    builder = table.Column<byte>(type: "tinyint", nullable: false),
                    gender = table.Column<byte>(type: "tinyint", nullable: false),
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false),
                    world = table.Column<short>(type: "smallint", nullable: false),
                    xloc = table.Column<int>(type: "int", nullable: false),
                    yloc = table.Column<int>(type: "int", nullable: false),
                    zloc = table.Column<int>(type: "int", nullable: false),
                    IsInVehicle = table.Column<short>(type: "smallint", nullable: false),
                    HP = table.Column<double>(type: "float", nullable: false),
                    MP = table.Column<double>(type: "float", nullable: false),
                    SP = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Lev = table.Column<byte>(type: "tinyint", nullable: false),
                    align = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    PKpardon = table.Column<int>(type: "int", nullable: false),
                    Duel = table.Column<int>(type: "int", nullable: false),
                    ST_underware = table.Column<int>(type: "int", nullable: false),
                    ST_right_ear = table.Column<int>(type: "int", nullable: false),
                    ST_left_ear = table.Column<int>(type: "int", nullable: false),
                    ST_neck = table.Column<int>(type: "int", nullable: false),
                    ST_right_finger = table.Column<int>(type: "int", nullable: false),
                    ST_left_finger = table.Column<int>(type: "int", nullable: false),
                    ST_head = table.Column<int>(type: "int", nullable: false),
                    ST_right_hand = table.Column<int>(type: "int", nullable: false),
                    ST_left_hand = table.Column<int>(type: "int", nullable: false),
                    ST_gloves = table.Column<int>(type: "int", nullable: false),
                    ST_chest = table.Column<int>(type: "int", nullable: false),
                    ST_legs = table.Column<int>(type: "int", nullable: false),
                    ST_feet = table.Column<int>(type: "int", nullable: false),
                    ST_back = table.Column<int>(type: "int", nullable: false),
                    ST_both_hand = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    login = table.Column<DateTime>(type: "datetime", nullable: true),
                    logout = table.Column<DateTime>(type: "datetime", nullable: true),
                    quest_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false, defaultValueSql: "(0x00)"),
                    nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    power_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false, defaultValueSql: "(0x0000000000000000000000000000000000000000000000000000000000000000)"),
                    pledge_dismiss_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_status = table.Column<byte>(type: "tinyint", nullable: false),
                    max_hp = table.Column<int>(type: "int", nullable: false),
                    max_mp = table.Column<int>(type: "int", nullable: false),
                    quest_memo = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    face_index = table.Column<int>(type: "int", nullable: false),
                    hair_shape_index = table.Column<int>(type: "int", nullable: false),
                    hair_color_index = table.Column<int>(type: "int", nullable: false),
                    use_time = table.Column<int>(type: "int", nullable: false),
                    temp_delete_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    pledge_ousted_time = table.Column<int>(type: "int", nullable: false),
                    pledge_withdraw_time = table.Column<int>(type: "int", nullable: false),
                    surrender_war_id = table.Column<int>(type: "int", nullable: false),
                    drop_exp = table.Column<int>(type: "int", nullable: false),
                    old_x = table.Column<int>(type: "int", nullable: true),
                    old_y = table.Column<int>(type: "int", nullable: true),
                    old_z = table.Column<int>(type: "int", nullable: true),
                    subjob_id = table.Column<int>(type: "int", nullable: true),
                    ssq_dawn_round = table.Column<int>(type: "int", nullable: true),
                    cp = table.Column<double>(type: "float", nullable: false),
                    max_cp = table.Column<double>(type: "float", nullable: false),
                    ST_hair = table.Column<int>(type: "int", nullable: false),
                    subjob0_class = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    subjob1_class = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    subjob2_class = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    subjob3_class = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((-1))"),
                    ST_hair_deco = table.Column<int>(type: "int", nullable: false),
                    ST_hair_all = table.Column<int>(type: "int", nullable: false),
                    spirit_count = table.Column<int>(type: "int", nullable: false),
                    augmentation = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((6))"),
                    PledgeType = table.Column<int>(type: "int", nullable: false),
                    sponsor_id = table.Column<int>(type: "int", nullable: false),
                    JoinPledgeLevel = table.Column<int>(type: "int", nullable: false),
                    effective_mana0 = table.Column<int>(type: "int", nullable: false),
                    effective_mana1 = table.Column<int>(type: "int", nullable: false),
                    effective_mana2 = table.Column<int>(type: "int", nullable: false),
                    effective_mana3 = table.Column<int>(type: "int", nullable: false),
                    vip_level = table.Column<int>(type: "int", nullable: false),
                    vip_timestamp = table.Column<int>(type: "int", nullable: false),
                    hardware_id = table.Column<int>(type: "int", nullable: false),
                    aio_id = table.Column<int>(type: "int", nullable: false),
                    aio_timestamp = table.Column<int>(type: "int", nullable: false),
                    long_hardware_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'00000000000000000000000000000000')"),
                    name_color = table.Column<int>(type: "int", nullable: false),
                    title_color = table.Column<int>(type: "int", nullable: false),
                    visual_armor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_data", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_data_moved",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    char_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    builder = table.Column<byte>(type: "tinyint", nullable: false),
                    gender = table.Column<byte>(type: "tinyint", nullable: false),
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false),
                    world = table.Column<short>(type: "smallint", nullable: false),
                    xloc = table.Column<int>(type: "int", nullable: false),
                    yloc = table.Column<int>(type: "int", nullable: false),
                    zloc = table.Column<int>(type: "int", nullable: false),
                    IsInVehicle = table.Column<short>(type: "smallint", nullable: false),
                    HP = table.Column<double>(type: "float", nullable: false),
                    MP = table.Column<double>(type: "float", nullable: false),
                    SP = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Lev = table.Column<byte>(type: "tinyint", nullable: false),
                    align = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    PKpardon = table.Column<int>(type: "int", nullable: false),
                    Duel = table.Column<int>(type: "int", nullable: false),
                    ST_underware = table.Column<int>(type: "int", nullable: false),
                    ST_right_ear = table.Column<int>(type: "int", nullable: false),
                    ST_left_ear = table.Column<int>(type: "int", nullable: false),
                    ST_neck = table.Column<int>(type: "int", nullable: false),
                    ST_right_finger = table.Column<int>(type: "int", nullable: false),
                    ST_left_finger = table.Column<int>(type: "int", nullable: false),
                    ST_head = table.Column<int>(type: "int", nullable: false),
                    ST_right_hand = table.Column<int>(type: "int", nullable: false),
                    ST_left_hand = table.Column<int>(type: "int", nullable: false),
                    ST_gloves = table.Column<int>(type: "int", nullable: false),
                    ST_chest = table.Column<int>(type: "int", nullable: false),
                    ST_legs = table.Column<int>(type: "int", nullable: false),
                    ST_feet = table.Column<int>(type: "int", nullable: false),
                    ST_back = table.Column<int>(type: "int", nullable: false),
                    ST_both_hand = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    login = table.Column<DateTime>(type: "datetime", nullable: true),
                    logout = table.Column<DateTime>(type: "datetime", nullable: true),
                    quest_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false),
                    nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    power_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false),
                    pledge_dismiss_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_status = table.Column<byte>(type: "tinyint", nullable: false),
                    max_hp = table.Column<int>(type: "int", nullable: false),
                    max_mp = table.Column<int>(type: "int", nullable: false),
                    quest_memo = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    face_index = table.Column<int>(type: "int", nullable: false),
                    hair_shape_index = table.Column<int>(type: "int", nullable: false),
                    hair_color_index = table.Column<int>(type: "int", nullable: false),
                    use_time = table.Column<int>(type: "int", nullable: false),
                    temp_delete_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    pledge_ousted_time = table.Column<int>(type: "int", nullable: false),
                    pledge_withdraw_time = table.Column<int>(type: "int", nullable: false),
                    surrender_war_id = table.Column<int>(type: "int", nullable: false),
                    drop_exp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_data_temp",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    pledge_id = table.Column<int>(type: "int", nullable: false),
                    builder = table.Column<byte>(type: "tinyint", nullable: false),
                    gender = table.Column<byte>(type: "tinyint", nullable: false),
                    race = table.Column<byte>(type: "tinyint", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint", nullable: false),
                    world = table.Column<short>(type: "smallint", nullable: false),
                    xloc = table.Column<int>(type: "int", nullable: false),
                    yloc = table.Column<int>(type: "int", nullable: false),
                    zloc = table.Column<int>(type: "int", nullable: false),
                    IsInVehicle = table.Column<short>(type: "smallint", nullable: false),
                    HP = table.Column<double>(type: "float", nullable: false),
                    MP = table.Column<double>(type: "float", nullable: false),
                    SP = table.Column<int>(type: "int", nullable: false),
                    Exp = table.Column<int>(type: "int", nullable: false),
                    Lev = table.Column<byte>(type: "tinyint", nullable: false),
                    align = table.Column<int>(type: "int", nullable: false),
                    PK = table.Column<int>(type: "int", nullable: false),
                    PKpardon = table.Column<int>(type: "int", nullable: false),
                    Duel = table.Column<int>(type: "int", nullable: false),
                    ST_underware = table.Column<int>(type: "int", nullable: false),
                    ST_right_ear = table.Column<int>(type: "int", nullable: false),
                    ST_left_ear = table.Column<int>(type: "int", nullable: false),
                    ST_neck = table.Column<int>(type: "int", nullable: false),
                    ST_right_finger = table.Column<int>(type: "int", nullable: false),
                    ST_left_finger = table.Column<int>(type: "int", nullable: false),
                    ST_head = table.Column<int>(type: "int", nullable: false),
                    ST_right_hand = table.Column<int>(type: "int", nullable: false),
                    ST_left_hand = table.Column<int>(type: "int", nullable: false),
                    ST_gloves = table.Column<int>(type: "int", nullable: false),
                    ST_chest = table.Column<int>(type: "int", nullable: false),
                    ST_legs = table.Column<int>(type: "int", nullable: false),
                    ST_feet = table.Column<int>(type: "int", nullable: false),
                    ST_back = table.Column<int>(type: "int", nullable: false),
                    ST_both_hand = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    login = table.Column<DateTime>(type: "datetime", nullable: true),
                    logout = table.Column<DateTime>(type: "datetime", nullable: true),
                    quest_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false),
                    nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    power_flag = table.Column<byte[]>(type: "binary(32)", fixedLength: true, maxLength: 32, nullable: false),
                    pledge_dismiss_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_time = table.Column<int>(type: "int", nullable: false),
                    pledge_leave_status = table.Column<byte>(type: "tinyint", nullable: false),
                    max_hp = table.Column<int>(type: "int", nullable: false),
                    max_mp = table.Column<int>(type: "int", nullable: false),
                    quest_memo = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    face_index = table.Column<int>(type: "int", nullable: false),
                    hair_shape_index = table.Column<int>(type: "int", nullable: false),
                    hair_color_index = table.Column<int>(type: "int", nullable: false),
                    use_time = table.Column<int>(type: "int", nullable: false),
                    temp_delete_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    pledge_ousted_time = table.Column<int>(type: "int", nullable: false),
                    pledge_withdraw_time = table.Column<int>(type: "int", nullable: false),
                    surrender_war_id = table.Column<int>(type: "int", nullable: false),
                    drop_exp = table.Column<int>(type: "int", nullable: false),
                    old_x = table.Column<int>(type: "int", nullable: true),
                    old_y = table.Column<int>(type: "int", nullable: true),
                    old_z = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_deleted",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    delete_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_friend",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    friend_char_id = table.Column<int>(type: "int", nullable: false),
                    friend_char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_friend", x => new { x.char_id, x.friend_char_id });
                });

            migrationBuilder.CreateTable(
                name: "user_henna",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    henna_1 = table.Column<int>(type: "int", nullable: false),
                    henna_2 = table.Column<int>(type: "int", nullable: false),
                    henna_3 = table.Column<int>(type: "int", nullable: false),
                    subjob_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_henna", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_history",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    log_action = table.Column<byte>(type: "tinyint", nullable: false),
                    account_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_instance",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    instance_id = table.Column<int>(type: "int", nullable: false),
                    time_spent = table.Column<int>(type: "int", nullable: false),
                    reuse_timeout = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_item",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<int>(type: "int", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    augmentation = table.Column<int>(type: "int", nullable: false),
                    mana_left = table.Column<int>(type: "int", nullable: false),
                    life_time = table.Column<int>(type: "int", nullable: false),
                    protection_timeout = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_item", x => x.item_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "user_journal",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<short>(type: "smallint", nullable: false),
                    int_data_1 = table.Column<int>(type: "int", nullable: true),
                    int_data_2 = table.Column<int>(type: "int", nullable: true),
                    log_data = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    play_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_log",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    log_id = table.Column<byte>(type: "tinyint", nullable: true),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    log_from = table.Column<int>(type: "int", nullable: true),
                    log_to = table.Column<int>(type: "int", nullable: true),
                    use_time = table.Column<int>(type: "int", nullable: true),
                    subjob_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_macro",
                columns: table => new
                {
                    macro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    char_id = table.Column<int>(type: "int", nullable: true),
                    macro_name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    macro_tooltip = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    macro_iconname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    macro_icontype = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_macroinfo",
                columns: table => new
                {
                    macro_id = table.Column<int>(type: "int", nullable: false),
                    macro_order = table.Column<int>(type: "int", nullable: true),
                    macro_int1 = table.Column<int>(type: "int", nullable: true),
                    macro_int2 = table.Column<int>(type: "int", nullable: true),
                    macro_int3 = table.Column<int>(type: "int", nullable: true),
                    macro_str = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_mail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    content = table.Column<string>(type: "nvarchar(3500)", maxLength: 3500, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_mail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_mail_receiver",
                columns: table => new
                {
                    mail_id = table.Column<int>(type: "int", nullable: false),
                    mailbox_type = table.Column<byte>(type: "tinyint", nullable: false),
                    receiver_id = table.Column<int>(type: "int", nullable: false),
                    receiver_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    read_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    read_status = table.Column<byte>(type: "tinyint", nullable: false),
                    deleted = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_mail_sender",
                columns: table => new
                {
                    mail_id = table.Column<int>(type: "int", nullable: false),
                    related_id = table.Column<int>(type: "int", nullable: false),
                    mail_type = table.Column<byte>(type: "tinyint", nullable: false),
                    mailbox_type = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))"),
                    sender_id = table.Column<int>(type: "int", nullable: false),
                    sender_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    send_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    receiver_name_list = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    deleted = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_name_color",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    color_rgb = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_name_color", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_name_reserved",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    used = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_name_reserved", x => x.char_name);
                });

            migrationBuilder.CreateTable(
                name: "user_newbie",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    newbie_stat = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_newbie", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "user_nobless",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    nobless_type = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    hero_type = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    win_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    previous_point = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    olympiad_point = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    match_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    words = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true, comment: "Korean_Wansung_CI_AS"),
                    olympiad_win_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    olympiad_lose_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    history_open = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user_nob__2D4B233921DF2C68", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_pin",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    pin = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_prohibit",
                columns: table => new
                {
                    char_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_prohibit", x => x.char_name);
                });

            migrationBuilder.CreateTable(
                name: "user_prohibit_word",
                columns: table => new
                {
                    words = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Korean_Wansung_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_prohibit_word", x => x.words);
                });

            migrationBuilder.CreateTable(
                name: "user_punish",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    punish_id = table.Column<int>(type: "int", nullable: false),
                    punish_on = table.Column<byte>(type: "tinyint", nullable: false),
                    remain_game = table.Column<int>(type: "int", nullable: true),
                    remain_real = table.Column<int>(type: "int", nullable: true),
                    punish_seconds = table.Column<int>(type: "int", nullable: true),
                    punish_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_rebirth",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    subjob_id = table.Column<int>(type: "int", nullable: false),
                    rebirth_count = table.Column<int>(type: "int", nullable: false),
                    available_points = table.Column<int>(type: "int", nullable: false),
                    bonus_int = table.Column<int>(type: "int", nullable: false),
                    bonus_str = table.Column<int>(type: "int", nullable: false),
                    bonus_con = table.Column<int>(type: "int", nullable: false),
                    bonus_men = table.Column<int>(type: "int", nullable: false),
                    bonus_dex = table.Column<int>(type: "int", nullable: false),
                    bonus_wit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_recipe",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    recipe_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_recipe", x => new { x.char_id, x.recipe_id });
                });

            migrationBuilder.CreateTable(
                name: "user_scheme_buffer",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    subjob_index = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    b0 = table.Column<int>(type: "int", nullable: false),
                    b1 = table.Column<int>(type: "int", nullable: false),
                    b2 = table.Column<int>(type: "int", nullable: false),
                    b3 = table.Column<int>(type: "int", nullable: false),
                    b4 = table.Column<int>(type: "int", nullable: false),
                    b5 = table.Column<int>(type: "int", nullable: false),
                    b6 = table.Column<int>(type: "int", nullable: false),
                    b7 = table.Column<int>(type: "int", nullable: false),
                    b8 = table.Column<int>(type: "int", nullable: false),
                    b9 = table.Column<int>(type: "int", nullable: false),
                    b10 = table.Column<int>(type: "int", nullable: false),
                    b11 = table.Column<int>(type: "int", nullable: false),
                    b12 = table.Column<int>(type: "int", nullable: false),
                    b13 = table.Column<int>(type: "int", nullable: false),
                    b14 = table.Column<int>(type: "int", nullable: false),
                    b15 = table.Column<int>(type: "int", nullable: false),
                    b16 = table.Column<int>(type: "int", nullable: false),
                    b17 = table.Column<int>(type: "int", nullable: false),
                    b18 = table.Column<int>(type: "int", nullable: false),
                    b19 = table.Column<int>(type: "int", nullable: false),
                    b20 = table.Column<int>(type: "int", nullable: false),
                    b21 = table.Column<int>(type: "int", nullable: false),
                    b22 = table.Column<int>(type: "int", nullable: false),
                    b23 = table.Column<int>(type: "int", nullable: false),
                    b24 = table.Column<int>(type: "int", nullable: false),
                    b25 = table.Column<int>(type: "int", nullable: false),
                    b26 = table.Column<int>(type: "int", nullable: false),
                    b27 = table.Column<int>(type: "int", nullable: false),
                    b28 = table.Column<int>(type: "int", nullable: false),
                    b29 = table.Column<int>(type: "int", nullable: false),
                    b30 = table.Column<int>(type: "int", nullable: false),
                    b31 = table.Column<int>(type: "int", nullable: false),
                    b32 = table.Column<int>(type: "int", nullable: false),
                    b33 = table.Column<int>(type: "int", nullable: false),
                    b34 = table.Column<int>(type: "int", nullable: false),
                    b35 = table.Column<int>(type: "int", nullable: false),
                    b36 = table.Column<int>(type: "int", nullable: false),
                    b37 = table.Column<int>(type: "int", nullable: false),
                    b38 = table.Column<int>(type: "int", nullable: false),
                    b39 = table.Column<int>(type: "int", nullable: false),
                    b40 = table.Column<int>(type: "int", nullable: false),
                    b41 = table.Column<int>(type: "int", nullable: false),
                    b42 = table.Column<int>(type: "int", nullable: false),
                    b43 = table.Column<int>(type: "int", nullable: false),
                    b44 = table.Column<int>(type: "int", nullable: false),
                    b45 = table.Column<int>(type: "int", nullable: false),
                    b46 = table.Column<int>(type: "int", nullable: false),
                    b47 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_skill",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    skill_id = table.Column<int>(type: "int", nullable: false),
                    subjob_id = table.Column<int>(type: "int", nullable: false),
                    skill_lev = table.Column<byte>(type: "tinyint", nullable: false),
                    to_end_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_skill", x => new { x.char_id, x.skill_id, x.subjob_id });
                });

            migrationBuilder.CreateTable(
                name: "user_skill_old",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    skill_id = table.Column<int>(type: "int", nullable: false),
                    skill_lev = table.Column<byte>(type: "tinyint", nullable: false),
                    to_end_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_sociality",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    sociality = table.Column<int>(type: "int", nullable: false),
                    used_sulffrage = table.Column<int>(type: "int", nullable: false),
                    last_changed = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_sociality", x => x.char_id);
                });

            migrationBuilder.CreateTable(
                name: "user_subjob",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: true),
                    hp = table.Column<double>(type: "float", nullable: true),
                    mp = table.Column<double>(type: "float", nullable: true),
                    sp = table.Column<int>(type: "int", nullable: true),
                    exp = table.Column<int>(type: "int", nullable: true),
                    level = table.Column<byte>(type: "tinyint", nullable: true),
                    henna_1 = table.Column<int>(type: "int", nullable: true),
                    henna_2 = table.Column<int>(type: "int", nullable: true),
                    henna_3 = table.Column<int>(type: "int", nullable: true),
                    subjob_id = table.Column<int>(type: "int", nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_surrender",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    surrender_war_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_vote",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false),
                    vote_points = table.Column<int>(type: "int", nullable: false),
                    vote_timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_warehouse",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false),
                    char_id = table.Column<int>(type: "int", nullable: false),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    enchant = table.Column<int>(type: "int", nullable: false),
                    eroded = table.Column<int>(type: "int", nullable: false),
                    bless = table.Column<byte>(type: "tinyint", nullable: false),
                    ident = table.Column<byte>(type: "tinyint", nullable: false),
                    wished = table.Column<byte>(type: "tinyint", nullable: true),
                    warehouse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_wedding",
                columns: table => new
                {
                    char_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<int>(type: "int", nullable: false),
                    partner_id = table.Column<int>(type: "int", nullable: false),
                    partner_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, defaultValueSql: "(N'')"),
                    penalty_timeout = table.Column<int>(type: "int", nullable: false),
                    teleport_timeout = table.Column<int>(type: "int", nullable: false),
                    wedding_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "war_declare",
                columns: table => new
                {
                    challenger = table.Column<int>(type: "int", nullable: false),
                    challengee = table.Column<int>(type: "int", nullable: false),
                    declare_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_war_declare", x => new { x.challenger, x.challengee });
                });

            migrationBuilder.CreateIndex(
                name: "IX_agit_adena",
                table: "agit_adena",
                columns: new[] { "pledge_id", "auction_id", "reason" });

            migrationBuilder.CreateIndex(
                name: "IX_agit_auction_1",
                table: "agit_auction",
                columns: new[] { "agit_id", "auction_time" });

            migrationBuilder.CreateIndex(
                name: "IX_agit_auction_2",
                table: "agit_auction",
                column: "auction_id");

            migrationBuilder.CreateIndex(
                name: "IX_agit_auction",
                table: "agit_bid",
                column: "auction_id");

            migrationBuilder.CreateIndex(
                name: "IX_agit_bid",
                table: "agit_bid",
                columns: new[] { "auction_id", "attend_pledge_id" },
                unique: true,
                filter: "[auction_id] IS NOT NULL AND [attend_pledge_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_agit_price",
                table: "agit_bid",
                columns: new[] { "attend_price", "attend_date" });

            migrationBuilder.CreateIndex(
                name: "ix_bookmark",
                table: "bookmark",
                column: "char_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_err_table2",
                table: "err_skill_1",
                columns: new[] { "class", "lev" });

            migrationBuilder.CreateIndex(
                name: "IX_event_point",
                table: "event_point",
                column: "group_id")
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_itemdata_name",
                table: "ItemData",
                column: "name")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_ItemData",
                table: "ItemData",
                columns: new[] { "id", "consumetype" })
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_lotto_items",
                table: "lotto_items",
                column: "round_number")
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_monrace",
                table: "monrace",
                column: "race_id")
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_monrace_ticket",
                table: "monrace_ticket",
                column: "item_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_monrace_ticket_1",
                table: "monrace_ticket",
                columns: new[] { "monraceid", "bet_type", "bet_1", "bet_2" })
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_npc_boss_unique_name",
                table: "npc_boss",
                column: "npc_db_name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_petmsg_charid",
                table: "PetitionMsg",
                column: "Char_Id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Pledge",
                table: "Pledge",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quest",
                table: "quest",
                column: "char_id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_req_charmove",
                table: "req_charmove_old",
                column: "new_char_name",
                unique: true,
                filter: "[new_char_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_req_charmove_1",
                table: "req_charmove_old",
                columns: new[] { "old_char_id", "old_world_id" },
                unique: true,
                filter: "[old_char_id] IS NOT NULL AND [old_world_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_req_charmove_2",
                table: "req_charmove_old",
                column: "account_id",
                unique: true,
                filter: "[account_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_req_charmove_3",
                table: "req_charmove_old",
                columns: new[] { "new_char_name", "new_world_id" },
                unique: true,
                filter: "[new_char_name] IS NOT NULL AND [new_world_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "sap_uniq",
                table: "siege_agit_pledge",
                columns: new[] { "agit_id", "pledge_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_name",
                table: "SkillData",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "tbam_uniq",
                table: "team_battle_agit_member",
                columns: new[] { "agit_id", "char_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "tbap_uniq",
                table: "team_battle_agit_pledge",
                columns: new[] { "agit_id", "pledge_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_comment",
                table: "user_comment",
                columns: new[] { "char_id", "deleted", "comment_id" })
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_user_comment_1",
                table: "user_comment",
                column: "comment_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_data_1",
                table: "user_data",
                column: "account_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_data_account_name",
                table: "user_data",
                column: "account_name")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_data_pledge",
                table: "user_data",
                column: "pledge_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_data1",
                table: "user_data",
                column: "char_name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_user_history",
                table: "user_history",
                column: "char_name")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_item_type",
                table: "user_item",
                column: "item_type")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_item_charid",
                table: "user_item",
                column: "char_id")
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_useritem_ware",
                table: "user_item",
                column: "warehouse")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_warehouse",
                table: "user_item",
                column: "warehouse")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_user_log",
                table: "user_log",
                columns: new[] { "char_id", "log_id", "log_to" })
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_user_macro",
                table: "user_macro",
                columns: new[] { "char_id", "macro_id" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_user_macroinfo",
                table: "user_macroinfo",
                columns: new[] { "macro_id", "macro_order" })
                .Annotation("SqlServer:Clustered", true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_user_mail_1",
                table: "user_mail",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_user_mail_receiver_1",
                table: "user_mail_receiver",
                column: "mail_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_mail_receiver_2",
                table: "user_mail_receiver",
                columns: new[] { "receiver_id", "read_status", "deleted" });

            migrationBuilder.CreateIndex(
                name: "IX_user_mail_sender",
                table: "user_mail_sender",
                columns: new[] { "sender_id", "mailbox_type", "deleted" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_user_mail_sender_1",
                table: "user_mail_sender",
                column: "mail_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_punish",
                table: "user_punish",
                columns: new[] { "char_id", "punish_id" })
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_skill_lev",
                table: "user_skill",
                column: "skill_lev")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_skill_toend",
                table: "user_skill",
                column: "to_end_time")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_warehouse_charid",
                table: "user_warehouse",
                column: "char_id")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_warehouse_itemid",
                table: "user_warehouse",
                column: "item_id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "idx_user_warehouse_itemtype",
                table: "user_warehouse",
                column: "item_type")
                .Annotation("SqlServer:FillFactor", 90);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account_ch2");

            migrationBuilder.DropTable(
                name: "AdditionalBox");

            migrationBuilder.DropTable(
                name: "agit");

            migrationBuilder.DropTable(
                name: "agit_adena");

            migrationBuilder.DropTable(
                name: "agit_auction");

            migrationBuilder.DropTable(
                name: "agit_bid");

            migrationBuilder.DropTable(
                name: "agit_deco");

            migrationBuilder.DropTable(
                name: "Alliance");

            migrationBuilder.DropTable(
                name: "Auction");

            migrationBuilder.DropTable(
                name: "AuctionPayment");

            migrationBuilder.DropTable(
                name: "banned_account");

            migrationBuilder.DropTable(
                name: "BannedHardwareId");

            migrationBuilder.DropTable(
                name: "bookmark");

            migrationBuilder.DropTable(
                name: "builder_account");

            migrationBuilder.DropTable(
                name: "castle");

            migrationBuilder.DropTable(
                name: "castle_crop");

            migrationBuilder.DropTable(
                name: "castle_tax");

            migrationBuilder.DropTable(
                name: "castle_war");

            migrationBuilder.DropTable(
                name: "ch2_temp");

            migrationBuilder.DropTable(
                name: "ch3_lotto_char");

            migrationBuilder.DropTable(
                name: "char_pet");

            migrationBuilder.DropTable(
                name: "CharacterLock");

            migrationBuilder.DropTable(
                name: "class_list");

            migrationBuilder.DropTable(
                name: "control_tower");

            migrationBuilder.DropTable(
                name: "DBNpcMaker");

            migrationBuilder.DropTable(
                name: "door");

            migrationBuilder.DropTable(
                name: "dt_adena_rank_temp");

            migrationBuilder.DropTable(
                name: "err_item_1");

            migrationBuilder.DropTable(
                name: "err_pet1_9_28");

            migrationBuilder.DropTable(
                name: "err_pet1_9_30");

            migrationBuilder.DropTable(
                name: "err_pet2_9_28");

            migrationBuilder.DropTable(
                name: "err_pet2_9_30");

            migrationBuilder.DropTable(
                name: "err_skill_1");

            migrationBuilder.DropTable(
                name: "event_items");

            migrationBuilder.DropTable(
                name: "event_point");

            migrationBuilder.DropTable(
                name: "item_amount0_backup");

            migrationBuilder.DropTable(
                name: "item_classid_normal");

            migrationBuilder.DropTable(
                name: "item_list");

            migrationBuilder.DropTable(
                name: "item_market_price");

            migrationBuilder.DropTable(
                name: "item_temp");

            migrationBuilder.DropTable(
                name: "ItemData");

            migrationBuilder.DropTable(
                name: "ItemDelivery");

            migrationBuilder.DropTable(
                name: "KillDeathStat");

            migrationBuilder.DropTable(
                name: "L2NetworkVote");

            migrationBuilder.DropTable(
                name: "LockedHardwareId");

            migrationBuilder.DropTable(
                name: "login_announce");

            migrationBuilder.DropTable(
                name: "lotto_game");

            migrationBuilder.DropTable(
                name: "lotto_game_backup_20050302");

            migrationBuilder.DropTable(
                name: "lotto_items");

            migrationBuilder.DropTable(
                name: "manor_data");

            migrationBuilder.DropTable(
                name: "manor_data_n");

            migrationBuilder.DropTable(
                name: "manor_fix");

            migrationBuilder.DropTable(
                name: "manor_info");

            migrationBuilder.DropTable(
                name: "map");

            migrationBuilder.DropTable(
                name: "mercenary");

            migrationBuilder.DropTable(
                name: "monrace");

            migrationBuilder.DropTable(
                name: "monrace_mon");

            migrationBuilder.DropTable(
                name: "monrace_ticket");

            migrationBuilder.DropTable(
                name: "MultiSell_Log");

            migrationBuilder.DropTable(
                name: "nobless_achievements");

            migrationBuilder.DropTable(
                name: "npc_boss");

            migrationBuilder.DropTable(
                name: "NpcDeath");

            migrationBuilder.DropTable(
                name: "npcname");

            migrationBuilder.DropTable(
                name: "object_data");

            migrationBuilder.DropTable(
                name: "OHEC_SUBJOB");

            migrationBuilder.DropTable(
                name: "OHEC_SUBJOB_TEMP");

            migrationBuilder.DropTable(
                name: "olympiad");

            migrationBuilder.DropTable(
                name: "olympiad_match");

            migrationBuilder.DropTable(
                name: "olympiad_result");

            migrationBuilder.DropTable(
                name: "pet_data");

            migrationBuilder.DropTable(
                name: "PetitionMsg");

            migrationBuilder.DropTable(
                name: "Pledge");

            migrationBuilder.DropTable(
                name: "pledge_announce");

            migrationBuilder.DropTable(
                name: "pledge_contribution");

            migrationBuilder.DropTable(
                name: "Pledge_Crest");

            migrationBuilder.DropTable(
                name: "pledge_ext");

            migrationBuilder.DropTable(
                name: "pledge_skill");

            migrationBuilder.DropTable(
                name: "pledge_subpledge");

            migrationBuilder.DropTable(
                name: "point");

            migrationBuilder.DropTable(
                name: "PrivateStore");

            migrationBuilder.DropTable(
                name: "quest");

            migrationBuilder.DropTable(
                name: "QuestData");

            migrationBuilder.DropTable(
                name: "req_char");

            migrationBuilder.DropTable(
                name: "req_charmove");

            migrationBuilder.DropTable(
                name: "req_charmove_old");

            migrationBuilder.DropTable(
                name: "req_pledge");

            migrationBuilder.DropTable(
                name: "residence_guard");

            migrationBuilder.DropTable(
                name: "shortcut_data");

            migrationBuilder.DropTable(
                name: "siege_agit_pledge");

            migrationBuilder.DropTable(
                name: "SiegeStat");

            migrationBuilder.DropTable(
                name: "SkillData");

            migrationBuilder.DropTable(
                name: "ssq_data");

            migrationBuilder.DropTable(
                name: "ssq_join_data");

            migrationBuilder.DropTable(
                name: "ssq_top_point_user");

            migrationBuilder.DropTable(
                name: "ssq_user_data");

            migrationBuilder.DropTable(
                name: "stat_acc_class");

            migrationBuilder.DropTable(
                name: "stat_acc_lev");

            migrationBuilder.DropTable(
                name: "stat_acc_mlev");

            migrationBuilder.DropTable(
                name: "stat_acc_race");

            migrationBuilder.DropTable(
                name: "stat_item_cnt");

            migrationBuilder.DropTable(
                name: "stat_item_ent");

            migrationBuilder.DropTable(
                name: "stat_item_ment");

            migrationBuilder.DropTable(
                name: "stat_item_mincnt");

            migrationBuilder.DropTable(
                name: "SubStack");

            migrationBuilder.DropTable(
                name: "team_battle_agit_member");

            migrationBuilder.DropTable(
                name: "team_battle_agit_pledge");

            migrationBuilder.DropTable(
                name: "temp_account");

            migrationBuilder.DropTable(
                name: "temp_inv");

            migrationBuilder.DropTable(
                name: "temp_pet_inv");

            migrationBuilder.DropTable(
                name: "temp_recipe");

            migrationBuilder.DropTable(
                name: "temp_skill");

            migrationBuilder.DropTable(
                name: "temp_skill2");

            migrationBuilder.DropTable(
                name: "temp_update");

            migrationBuilder.DropTable(
                name: "TEST");

            migrationBuilder.DropTable(
                name: "time_attack_record");

            migrationBuilder.DropTable(
                name: "time_attack_record_test");

            migrationBuilder.DropTable(
                name: "time_data");

            migrationBuilder.DropTable(
                name: "tmp_alliance");

            migrationBuilder.DropTable(
                name: "tmp_die_user");

            migrationBuilder.DropTable(
                name: "tmp_lotto_price_given");

            migrationBuilder.DropTable(
                name: "tmp_pledge");

            migrationBuilder.DropTable(
                name: "tmp_recover_user");

            migrationBuilder.DropTable(
                name: "tmp_seed_dp");

            migrationBuilder.DropTable(
                name: "tmp_user_data");

            migrationBuilder.DropTable(
                name: "tmp_user_item");

            migrationBuilder.DropTable(
                name: "tmp_user_nobless");

            migrationBuilder.DropTable(
                name: "user_ActiveSkill");

            migrationBuilder.DropTable(
                name: "user_ban");

            migrationBuilder.DropTable(
                name: "user_blocklist");

            migrationBuilder.DropTable(
                name: "user_comment");

            migrationBuilder.DropTable(
                name: "user_data");

            migrationBuilder.DropTable(
                name: "user_data_moved");

            migrationBuilder.DropTable(
                name: "user_data_temp");

            migrationBuilder.DropTable(
                name: "user_deleted");

            migrationBuilder.DropTable(
                name: "user_friend");

            migrationBuilder.DropTable(
                name: "user_henna");

            migrationBuilder.DropTable(
                name: "user_history");

            migrationBuilder.DropTable(
                name: "user_instance");

            migrationBuilder.DropTable(
                name: "user_item");

            migrationBuilder.DropTable(
                name: "user_journal");

            migrationBuilder.DropTable(
                name: "user_log");

            migrationBuilder.DropTable(
                name: "user_macro");

            migrationBuilder.DropTable(
                name: "user_macroinfo");

            migrationBuilder.DropTable(
                name: "user_mail");

            migrationBuilder.DropTable(
                name: "user_mail_receiver");

            migrationBuilder.DropTable(
                name: "user_mail_sender");

            migrationBuilder.DropTable(
                name: "user_name_color");

            migrationBuilder.DropTable(
                name: "user_name_reserved");

            migrationBuilder.DropTable(
                name: "user_newbie");

            migrationBuilder.DropTable(
                name: "user_nobless");

            migrationBuilder.DropTable(
                name: "user_pin");

            migrationBuilder.DropTable(
                name: "user_prohibit");

            migrationBuilder.DropTable(
                name: "user_prohibit_word");

            migrationBuilder.DropTable(
                name: "user_punish");

            migrationBuilder.DropTable(
                name: "user_rebirth");

            migrationBuilder.DropTable(
                name: "user_recipe");

            migrationBuilder.DropTable(
                name: "user_scheme_buffer");

            migrationBuilder.DropTable(
                name: "user_skill");

            migrationBuilder.DropTable(
                name: "user_skill_old");

            migrationBuilder.DropTable(
                name: "user_sociality");

            migrationBuilder.DropTable(
                name: "user_subjob");

            migrationBuilder.DropTable(
                name: "user_surrender");

            migrationBuilder.DropTable(
                name: "user_vote");

            migrationBuilder.DropTable(
                name: "user_warehouse");

            migrationBuilder.DropTable(
                name: "user_wedding");

            migrationBuilder.DropTable(
                name: "war_declare");
        }
    }
}
