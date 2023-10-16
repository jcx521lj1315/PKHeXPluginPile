using PKHeX.Core;

namespace PluginPile.Sorting; 
class Gen5_Unova : SortingBase {

  private static readonly Dictionary<Species, PositionForms> BWdex = new Dictionary<Species, PositionForms>() {
    {Species.Victini, 0},
    {Species.Snivy, 1},
    {Species.Servine, 2},
    {Species.Serperior, 3},
    {Species.Tepig, 4},
    {Species.Pignite, 5},
    {Species.Emboar, 6},
    {Species.Oshawott, 7},
    {Species.Dewott, 8},
    {Species.Samurott, 9},
    {Species.Patrat, 10},
    {Species.Watchog, 11},
    {Species.Lillipup, 12},
    {Species.Herdier, 13},
    {Species.Stoutland, 14},
    {Species.Purrloin, 15},
    {Species.Liepard, 16},
    {Species.Pansage, 17},
    {Species.Simisage, 18},
    {Species.Pansear, 19},
    {Species.Simisear, 20},
    {Species.Panpour, 21},
    {Species.Simipour, 22},
    {Species.Munna, 23},
    {Species.Musharna, 24},
    {Species.Pidove, 25},
    {Species.Tranquill, 26},
    {Species.Unfezant, 27},
    {Species.Blitzle, 28},
    {Species.Zebstrika, 29},
    {Species.Roggenrola, 30},
    {Species.Boldore, 31},
    {Species.Gigalith, 32},
    {Species.Woobat, 33},
    {Species.Swoobat, 34},
    {Species.Drilbur, 35},
    {Species.Excadrill, 36},
    {Species.Audino, 37},
    {Species.Timburr, 38},
    {Species.Gurdurr, 39},
    {Species.Conkeldurr, 40},
    {Species.Tympole, 41},
    {Species.Palpitoad, 42},
    {Species.Seismitoad, 43},
    {Species.Throh, 44},
    {Species.Sawk, 45},
    {Species.Sewaddle, 46},
    {Species.Swadloon, 47},
    {Species.Leavanny, 48},
    {Species.Venipede, 49},
    {Species.Whirlipede, 50},
    {Species.Scolipede, 51},
    {Species.Cottonee, 52},
    {Species.Whimsicott, 53},
    {Species.Petilil, 54},
    {Species.Lilligant, 55},
    {Species.Basculin, (56, 0..1)},
    {Species.Sandile, 57},
    {Species.Krokorok, 58},
    {Species.Krookodile, 59},
    {Species.Darumaka, 60},
    {Species.Darmanitan, (61, 0..1)},
    {Species.Maractus, 62},
    {Species.Dwebble, 63},
    {Species.Crustle, 64},
    {Species.Scraggy, 65},
    {Species.Scrafty, 66},
    {Species.Sigilyph, 67},
    {Species.Yamask, 68},
    {Species.Cofagrigus, 69},
    {Species.Tirtouga, 70},
    {Species.Carracosta, 71},
    {Species.Archen, 72},
    {Species.Archeops, 73},
    {Species.Trubbish, 74},
    {Species.Garbodor, 75},
    {Species.Zorua, 76},
    {Species.Zoroark, 77},
    {Species.Minccino, 78},
    {Species.Cinccino, 79},
    {Species.Gothita, 80},
    {Species.Gothorita, 81},
    {Species.Gothitelle, 82},
    {Species.Solosis, 83},
    {Species.Duosion, 84},
    {Species.Reuniclus, 85},
    {Species.Ducklett, 86},
    {Species.Swanna, 87},
    {Species.Vanillite, 88},
    {Species.Vanillish, 89},
    {Species.Vanilluxe, 90},
    {Species.Deerling, (91, 0..3)},
    {Species.Sawsbuck, (92, 0..3)},
    {Species.Emolga, 93},
    {Species.Karrablast, 94},
    {Species.Escavalier, 95},
    {Species.Foongus, 96},
    {Species.Amoonguss, 97},
    {Species.Frillish, 98},
    {Species.Jellicent, 99},
    {Species.Alomomola, 100},
    {Species.Joltik, 101},
    {Species.Galvantula, 102},
    {Species.Ferroseed, 103},
    {Species.Ferrothorn, 104},
    {Species.Klink, 105},
    {Species.Klang, 106},
    {Species.Klinklang, 107},
    {Species.Tynamo, 108},
    {Species.Eelektrik, 109},
    {Species.Eelektross, 110},
    {Species.Elgyem, 111},
    {Species.Beheeyem, 112},
    {Species.Litwick, 113},
    {Species.Lampent, 114},
    {Species.Chandelure, 115},
    {Species.Axew, 116},
    {Species.Fraxure, 117},
    {Species.Haxorus, 118},
    {Species.Cubchoo, 119},
    {Species.Beartic, 120},
    {Species.Cryogonal, 121},
    {Species.Shelmet, 122},
    {Species.Accelgor, 123},
    {Species.Stunfisk, 124},
    {Species.Mienfoo, 125},
    {Species.Mienshao, 126},
    {Species.Druddigon, 127},
    {Species.Golett, 128},
    {Species.Golurk, 129},
    {Species.Pawniard, 130},
    {Species.Bisharp, 131},
    {Species.Bouffalant, 132},
    {Species.Rufflet, 133},
    {Species.Braviary, 134},
    {Species.Vullaby, 135},
    {Species.Mandibuzz, 136},
    {Species.Heatmor, 137},
    {Species.Durant, 138},
    {Species.Deino, 139},
    {Species.Zweilous, 140},
    {Species.Hydreigon, 141},
    {Species.Larvesta, 142},
    {Species.Volcarona, 143},
    {Species.Cobalion, 144},
    {Species.Terrakion, 145},
    {Species.Virizion, 146},
    {Species.Tornadus, (147, 0..1)},
    {Species.Thundurus, (148, 0..1)},
    {Species.Reshiram, 149},
    {Species.Zekrom, 150},
    {Species.Landorus, (151, 0..1)},
    {Species.Kyurem, (152, 0..2)},
    {Species.Keldeo, (153, 0..1)},
    {Species.Meloetta, (154, 0..1)},
    {Species.Genesect, (155, 0..4)},
  };

  private static readonly Dictionary<Species, PositionForms> B2W2dex = new Dictionary<Species, PositionForms>() {
    {Species.Victini, 0},
    {Species.Snivy, 1},
    {Species.Servine, 2},
    {Species.Serperior, 3},
    {Species.Tepig, 4},
    {Species.Pignite, 5},
    {Species.Emboar, 6},
    {Species.Oshawott, 7},
    {Species.Dewott, 8},
    {Species.Samurott, 9},
    {Species.Patrat, 10},
    {Species.Watchog, 11},
    {Species.Purrloin, 12},
    {Species.Liepard, 13},
    {Species.Pidove, 14},
    {Species.Tranquill, 15},
    {Species.Unfezant, 16},
    {Species.Sewaddle, 17},
    {Species.Swadloon, 18},
    {Species.Leavanny, 19},
    {Species.Sunkern, 20},
    {Species.Sunflora, 21},
    {Species.Lillipup, 22},
    {Species.Herdier, 23},
    {Species.Stoutland, 24},
    {Species.Mareep, 25},
    {Species.Flaaffy, 26},
    {Species.Ampharos, 27},
    {Species.Psyduck, 28},
    {Species.Golduck, 29},
    {Species.Azurill, 30},
    {Species.Marill, 31},
    {Species.Azumarill, 32},
    {Species.Riolu, 33},
    {Species.Lucario, 34},
    {Species.Dunsparce, 35},
    {Species.Audino, 36},
    {Species.Pansage, 37},
    {Species.Simisage, 38},
    {Species.Pansear, 39},
    {Species.Simisear, 40},
    {Species.Panpour, 41},
    {Species.Simipour, 42},
    {Species.Venipede, 43},
    {Species.Whirlipede, 44},
    {Species.Scolipede, 45},
    {Species.Koffing, 46},
    {Species.Weezing, 47},
    {Species.Magnemite, 48},
    {Species.Magneton, 49},
    {Species.Magnezone, 50},
    {Species.Growlithe, 51},
    {Species.Arcanine, 52},
    {Species.Magby, 53},
    {Species.Magmar, 54},
    {Species.Magmortar, 55},
    {Species.Elekid, 56},
    {Species.Electabuzz, 57},
    {Species.Electivire, 58},
    {Species.Rattata, 59},
    {Species.Raticate, 60},
    {Species.Zubat, 61},
    {Species.Golbat, 62},
    {Species.Crobat, 63},
    {Species.Grimer, 64},
    {Species.Muk, 65},
    {Species.Woobat, 66},
    {Species.Swoobat, 67},
    {Species.Roggenrola, 68},
    {Species.Boldore, 69},
    {Species.Gigalith, 70},
    {Species.Onix, 71},
    {Species.Steelix, 72},
    {Species.Timburr, 73},
    {Species.Gurdurr, 74},
    {Species.Conkeldurr, 75},
    {Species.Drilbur, 76},
    {Species.Excadrill, 77},
    {Species.Skitty, 78},
    {Species.Delcatty, 79},
    {Species.Buneary, 80},
    {Species.Lopunny, 81},
    {Species.Cottonee, 82},
    {Species.Whimsicott, 83},
    {Species.Petilil, 84},
    {Species.Lilligant, 85},
    {Species.Munna, 86},
    {Species.Musharna, 87},
    {Species.Cleffa, 88},
    {Species.Clefairy, 89},
    {Species.Clefable, 90},
    {Species.Eevee, 91},
    {Species.Vaporeon, 92},
    {Species.Jolteon, 93},
    {Species.Flareon, 94},
    {Species.Espeon, 95},
    {Species.Umbreon, 96},
    {Species.Leafeon, 97},
    {Species.Glaceon, 98},
    {Species.Sandile, 99},
    {Species.Krokorok, 100},
    {Species.Krookodile, 101},
    {Species.Darumaka, 102},
    {Species.Darmanitan, (103, 0..1)},
    {Species.Basculin, (104, 0..1)},
    {Species.Trubbish, 105},
    {Species.Garbodor, 106},
    {Species.Minccino, 107},
    {Species.Cinccino, 108},
    {Species.Rufflet, 109},
    {Species.Braviary, 110},
    {Species.Vullaby, 111},
    {Species.Mandibuzz, 112},
    {Species.Sandshrew, 113},
    {Species.Sandslash, 114},
    {Species.Dwebble, 115},
    {Species.Crustle, 116},
    {Species.Scraggy, 117},
    {Species.Scrafty, 118},
    {Species.Maractus, 119},
    {Species.Sigilyph, 120},
    {Species.Trapinch, 121},
    {Species.Vibrava, 122},
    {Species.Flygon, 123},
    {Species.Yamask, 124},
    {Species.Cofagrigus, 125},
    {Species.Tirtouga, 126},
    {Species.Carracosta, 127},
    {Species.Archen, 128},
    {Species.Archeops, 129},
    {Species.Klink, 130},
    {Species.Klang, 131},
    {Species.Klinklang, 132},
    {Species.Budew, 133},
    {Species.Roselia, 134},
    {Species.Roserade, 135},
    {Species.Gothita, 136},
    {Species.Gothorita, 137},
    {Species.Gothitelle, 138},
    {Species.Solosis, 139},
    {Species.Duosion, 140},
    {Species.Reuniclus, 141},
    {Species.Combee, 142},
    {Species.Vespiquen, 143},
    {Species.Emolga, 144},
    {Species.Heracross, 145},
    {Species.Pinsir, 146},
    {Species.Blitzle, 147},
    {Species.Zebstrika, 148},
    {Species.Buizel, 149},
    {Species.Floatzel, 150},
    {Species.Zorua, 151},
    {Species.Zoroark, 152},
    {Species.Ducklett, 153},
    {Species.Swanna, 154},
    {Species.Karrablast, 155},
    {Species.Escavalier, 156},
    {Species.Shelmet, 157},
    {Species.Accelgor, 158},
    {Species.Deerling, (159, 0..3)},
    {Species.Sawsbuck, (160, 0..3)},
    {Species.Foongus, 161},
    {Species.Amoonguss, 162},
    {Species.Castform, (163, 0..3)},
    {Species.Nosepass, 164},
    {Species.Probopass, 165},
    {Species.Aron, 166},
    {Species.Lairon, 167},
    {Species.Aggron, 168},
    {Species.Baltoy, 169},
    {Species.Claydol, 170},
    {Species.Larvesta, 171},
    {Species.Volcarona, 172},
    {Species.Joltik, 173},
    {Species.Galvantula, 174},
    {Species.Ferroseed, 175},
    {Species.Ferrothorn, 176},
    {Species.Tynamo, 177},
    {Species.Eelektrik, 178},
    {Species.Eelektross, 179},
    {Species.Frillish, 180},
    {Species.Jellicent, 181},
    {Species.Alomomola, 182},
    {Species.Axew, 183},
    {Species.Fraxure, 184},
    {Species.Haxorus, 185},
    {Species.Zangoose, 186},
    {Species.Seviper, 187},
    {Species.Elgyem, 188},
    {Species.Beheeyem, 189},
    {Species.Litwick, 190},
    {Species.Lampent, 191},
    {Species.Chandelure, 192},
    {Species.Heatmor, 193},
    {Species.Durant, 194},
    {Species.Cubchoo, 195},
    {Species.Beartic, 196},
    {Species.Cryogonal, 197},
    {Species.Tornadus, (198, 0..1)},
    {Species.Thundurus, (199, 0..1)},
    {Species.Landorus, (200, 0..1)},
    {Species.Skorupi, 201},
    {Species.Drapion, 202},
    {Species.Skarmory, 203},
    {Species.Numel, 204},
    {Species.Camerupt, 205},
    {Species.Spoink, 206},
    {Species.Grumpig, 207},
    {Species.Drifloon, 208},
    {Species.Drifblim, 209},
    {Species.Shuppet, 210},
    {Species.Banette, 211},
    {Species.Wingull, 212},
    {Species.Pelipper, 213},
    {Species.Lunatone, 214},
    {Species.Solrock, 215},
    {Species.Absol, 216},
    {Species.Tangela, 217},
    {Species.Tangrowth, 218},
    {Species.Mienfoo, 219},
    {Species.Mienshao, 220},
    {Species.Gligar, 221},
    {Species.Gliscor, 222},
    {Species.Pawniard, 223},
    {Species.Bisharp, 224},
    {Species.Cobalion, 225},
    {Species.Terrakion, 226},
    {Species.Virizion, 227},
    {Species.Tympole, 228},
    {Species.Palpitoad, 229},
    {Species.Seismitoad, 230},
    {Species.Stunfisk, 231},
    {Species.Shuckle, 232},
    {Species.Mantyke, 233},
    {Species.Mantine, 234},
    {Species.Remoraid, 235},
    {Species.Octillery, 236},
    {Species.Corsola, 237},
    {Species.Staryu, 238},
    {Species.Starmie, 239},
    {Species.Wailmer, 240},
    {Species.Wailord, 241},
    {Species.Lapras, 242},
    {Species.Spheal, 243},
    {Species.Sealeo, 244},
    {Species.Walrein, 245},
    {Species.Swablu, 246},
    {Species.Altaria, 247},
    {Species.Vulpix, 248},
    {Species.Ninetales, 249},
    {Species.Bronzor, 250},
    {Species.Bronzong, 251},
    {Species.Sneasel, 252},
    {Species.Weavile, 253},
    {Species.Delibird, 254},
    {Species.Vanillite, 255},
    {Species.Vanillish, 256},
    {Species.Vanilluxe, 257},
    {Species.Swinub, 258},
    {Species.Piloswine, 259},
    {Species.Mamoswine, 260},
    {Species.Ditto, 261},
    {Species.Beldum, 262},
    {Species.Metang, 263},
    {Species.Metagross, 264},
    {Species.Seel, 265},
    {Species.Dewgong, 266},
    {Species.Throh, 267},
    {Species.Sawk, 268},
    {Species.Bouffalant, 269},
    {Species.Druddigon, 270},
    {Species.Golett, 271},
    {Species.Golurk, 272},
    {Species.Deino, 273},
    {Species.Zweilous, 274},
    {Species.Hydreigon, 275},
    {Species.Slakoth, 276},
    {Species.Vigoroth, 277},
    {Species.Slaking, 278},
    {Species.Corphish, 279},
    {Species.Crawdaunt, 280},
    {Species.Igglybuff, 281},
    {Species.Jigglypuff, 282},
    {Species.Wigglytuff, 283},
    {Species.Lickitung, 284},
    {Species.Lickilicky, 285},
    {Species.Yanma, 286},
    {Species.Yanmega, 287},
    {Species.Tropius, 288},
    {Species.Carnivine, 289},
    {Species.Croagunk, 290},
    {Species.Toxicroak, 291},
    {Species.Larvitar, 292},
    {Species.Pupitar, 293},
    {Species.Tyranitar, 294},
    {Species.Reshiram, 295},
    {Species.Zekrom, 296},
    {Species.Kyurem, (297, 0..2)},
    {Species.Keldeo, (298, 0..1)},
    {Species.Meloetta, (299, 0..1)},
    {Species.Genesect, (300, 0 ..5)},
  };

  public static Func<PKM, IComparable>[] GetBWSortFunctions() {
    return GenerateSortingFunctions(BWdex);
  }

  public static Func<PKM, IComparable>[] GetB2W2SortFunctions() {
    return GenerateSortingFunctions(B2W2dex);
  }

}
