using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class Gen9_Paldea : SortingBase {

    private static readonly Dictionary<SpeciesForm, int> PaldeaDex = new Dictionary<SpeciesForm, int>() {
      {Species.Sprigatito, 1},
      {Species.Floragato, 2},
      {Species.Meowscarada, 3},
      {Species.Fuecoco, 4},
      {Species.Crocalor, 5},
      {Species.Skeledirge, 6},
      {Species.Quaxly, 7},
      {Species.Quaxwell, 8},
      {Species.Quaquaval, 9},
      {Species.Lechonk, 10},
      {(Species.Oinkologne, 0), 11},
      {(Species.Oinkologne, 1), 11},
      {Species.Tarountula, 12},
      {Species.Spidops, 13},
      {Species.Nymble, 14},
      {Species.Lokix, 15},
      {Species.Hoppip, 16},
      {Species.Skiploom, 17},
      {Species.Jumpluff, 18},
      {Species.Fletchling, 19},
      {Species.Fletchinder, 20},
      {Species.Talonflame, 21},
      {Species.Pawmi, 22},
      {Species.Pawmo, 23},
      {Species.Pawmot, 24},
      {Species.Houndour, 25},
      {Species.Houndoom, 26},
      {Species.Yungoos, 27},
      {Species.Gumshoos, 28},
      {Species.Skwovet, 29},
      {Species.Greedent, 30},
      {Species.Sunkern, 31},
      {Species.Sunflora, 32},
      {Species.Kricketot, 33},
      {Species.Kricketune, 34},
      {(Species.Scatterbug, 0), 35},
      {(Species.Scatterbug, 1), 35},
      {(Species.Scatterbug, 2), 35},
      {(Species.Scatterbug, 3), 35},
      {(Species.Scatterbug, 4), 35},
      {(Species.Scatterbug, 5), 35},
      {(Species.Scatterbug, 6), 35},
      {(Species.Scatterbug, 7), 35},
      {(Species.Scatterbug, 8), 35},
      {(Species.Scatterbug, 9), 35},
      {(Species.Scatterbug, 10), 35},
      {(Species.Scatterbug, 11), 35},
      {(Species.Scatterbug, 12), 35},
      {(Species.Scatterbug, 13), 35},
      {(Species.Scatterbug, 14), 35},
      {(Species.Scatterbug, 15), 35},
      {(Species.Scatterbug, 16), 35},
      {(Species.Scatterbug, 17), 35},
      {(Species.Scatterbug, 18), 35},
      {(Species.Scatterbug, 19), 35},
      {(Species.Spewpa, 0), 36},
      {(Species.Spewpa, 1), 36},
      {(Species.Spewpa, 2), 36},
      {(Species.Spewpa, 3), 36},
      {(Species.Spewpa, 4), 36},
      {(Species.Spewpa, 5), 36},
      {(Species.Spewpa, 6), 36},
      {(Species.Spewpa, 7), 36},
      {(Species.Spewpa, 8), 36},
      {(Species.Spewpa, 9), 36},
      {(Species.Spewpa, 10), 36},
      {(Species.Spewpa, 11), 36},
      {(Species.Spewpa, 12), 36},
      {(Species.Spewpa, 13), 36},
      {(Species.Spewpa, 14), 36},
      {(Species.Spewpa, 15), 36},
      {(Species.Spewpa, 16), 36},
      {(Species.Spewpa, 17), 36},
      {(Species.Spewpa, 18), 36},
      {(Species.Spewpa, 19), 36},
      {(Species.Vivillon, 0), 37},
      {(Species.Vivillon, 1), 37},
      {(Species.Vivillon, 2), 37},
      {(Species.Vivillon, 3), 37},
      {(Species.Vivillon, 4), 37},
      {(Species.Vivillon, 5), 37},
      {(Species.Vivillon, 6), 37},
      {(Species.Vivillon, 7), 37},
      {(Species.Vivillon, 8), 37},
      {(Species.Vivillon, 9), 37},
      {(Species.Vivillon, 10), 37},
      {(Species.Vivillon, 11), 37},
      {(Species.Vivillon, 12), 37},
      {(Species.Vivillon, 13), 37},
      {(Species.Vivillon, 14), 37},
      {(Species.Vivillon, 15), 37},
      {(Species.Vivillon, 16), 37},
      {(Species.Vivillon, 17), 37},
      {(Species.Vivillon, 18), 37},
      {(Species.Vivillon, 19), 37},
      {Species.Combee, 38},
      {Species.Vespiquen, 39},
      {Species.Rookidee, 40},
      {Species.Corvisquire, 41},
      {Species.Corviknight, 42},
      {Species.Happiny, 43},
      {Species.Chansey, 44},
      {Species.Blissey, 45},
      {Species.Azurill, 46},
      {Species.Marill, 47},
      {Species.Azumarill, 48},
      {Species.Surskit, 49},
      {Species.Masquerain, 50},
      {Species.Buizel, 51},
      {Species.Floatzel, 52},
      {(Species.Wooper, 1), 53},
      {Species.Clodsire, 54},
      {Species.Psyduck, 55},
      {Species.Golduck, 56},
      {Species.Chewtle, 57},
      {Species.Drednaw, 58},
      {Species.Igglybuff, 59},
      {Species.Jigglypuff, 60},
      {Species.Wigglytuff, 61},
      {Species.Ralts, 62},
      {Species.Kirlia, 63},
      {Species.Gardevoir, 64},
      {Species.Gallade, 65},
      {Species.Drowzee, 66},
      {Species.Hypno, 67},
      {Species.Gastly, 68},
      {Species.Haunter, 69},
      {Species.Gengar, 70},
      {Species.Tandemaus, 71},
      {(Species.Maushold, 0), 72},
      {(Species.Maushold, 1), 72},
      {Species.Pichu, 73},
      {Species.Pikachu, 74},
      {Species.Raichu, 75},
      {Species.Fidough, 76},
      {Species.Dachsbun, 77},
      {Species.Slakoth, 78},
      {Species.Vigoroth, 79},
      {Species.Slaking, 80},
      {Species.Bounsweet, 81},
      {Species.Steenee, 82},
      {Species.Tsareena, 83},
      {Species.Smoliv, 84},
      {Species.Dolliv, 85},
      {Species.Arboliva, 86},
      {Species.Bonsly, 87},
      {Species.Sudowoodo, 88},
      {(Species.Rockruff, 0), 89},
      {(Species.Rockruff, 1), 89},
      {(Species.Lycanroc, 0), 90},
      {(Species.Lycanroc, 1), 90},
      {(Species.Lycanroc, 2), 90},
      {Species.Rolycoly, 91},
      {Species.Carkol, 92},
      {Species.Coalossal, 93},
      {Species.Shinx, 94},
      {Species.Luxio, 95},
      {Species.Luxray, 96},
      {Species.Starly, 97},
      {Species.Staravia, 98},
      {Species.Staraptor, 99},
      {(Species.Oricorio, 0), 100},
      {(Species.Oricorio, 1), 100},
      {(Species.Oricorio, 2), 100},
      {(Species.Oricorio, 3), 100},
      {Species.Mareep, 101},
      {Species.Flaaffy, 102},
      {Species.Ampharos, 103},
      {Species.Petilil, 104},
      {Species.Lilligant, 105},
      {Species.Shroomish, 106},
      {Species.Breloom, 107},
      {Species.Applin, 108},
      {Species.Flapple, 109},
      {Species.Appletun, 110},
      {Species.Spoink, 111},
      {Species.Grumpig, 112},
      {(Species.Squawkabilly, 0), 113},
      {(Species.Squawkabilly, 1), 113},
      {(Species.Squawkabilly, 2), 113},
      {(Species.Squawkabilly, 3), 113},
      {Species.Misdreavus, 114},
      {Species.Mismagius, 115},
      {Species.Makuhita, 116},
      {Species.Hariyama, 117},
      {Species.Crabrawler, 118},
      {Species.Crabominable, 119},
      {Species.Salandit, 120},
      {Species.Salazzle, 121},
      {Species.Phanpy, 122},
      {Species.Donphan, 123},
      {Species.Cufant, 124},
      {Species.Copperajah, 125},
      {Species.Gible, 126},
      {Species.Gabite, 127},
      {Species.Garchomp, 128},
      {Species.Nacli, 129},
      {Species.Naclstack, 130},
      {Species.Garganacl, 131},
      {Species.Wingull, 132},
      {Species.Pelipper, 133},
      {Species.Magikarp, 134},
      {Species.Gyarados, 135},
      {Species.Arrokuda, 136},
      {Species.Barraskewda, 137},
      {(Species.Basculin, 0), 138},
      {(Species.Basculin, 1), 138},
      {Species.Gulpin, 139},
      {Species.Swalot, 140},
      {Species.Meowth, 141},
      {Species.Persian, 142},
      {Species.Drifloon, 143},
      {Species.Drifblim, 144},
      {(Species.Flabébé, 0), 145},
      {(Species.Flabébé, 1), 145},
      {(Species.Flabébé, 2), 145},
      {(Species.Flabébé, 3), 145},
      {(Species.Flabébé, 4), 145},
      {(Species.Floette, 0), 146},
      {(Species.Floette, 1), 146},
      {(Species.Floette, 2), 146},
      {(Species.Floette, 3), 146},
      {(Species.Floette, 4), 146},
      {(Species.Florges, 0), 147},
      {(Species.Florges, 1), 147},
      {(Species.Florges, 2), 147},
      {(Species.Florges, 3), 147},
      {(Species.Florges, 4), 147},
      {Species.Diglett, 148},
      {Species.Dugtrio, 149},
      {Species.Torkoal, 150},
      {Species.Numel, 151},
      {Species.Camerupt, 152},
      {Species.Bronzor, 153},
      {Species.Bronzong, 154},
      {Species.Axew, 155},
      {Species.Fraxure, 156},
      {Species.Haxorus, 157},
      {Species.Mankey, 158},
      {Species.Primeape, 159},
      {Species.Annihilape, 160},
      {Species.Meditite, 161},
      {Species.Medicham, 162},
      {Species.Riolu, 163},
      {Species.Lucario, 164},
      {Species.Charcadet, 165},
      {Species.Armarouge, 166},
      {Species.Ceruledge, 167},
      {Species.Barboach, 168},
      {Species.Whiscash, 169},
      {Species.Tadbulb, 170},
      {Species.Bellibolt, 171},
      {Species.Goomy, 172},
      {Species.Sliggoo, 173},
      {Species.Goodra, 174},
      {Species.Croagunk, 175},
      {Species.Toxicroak, 176},
      {Species.Wattrel, 177},
      {Species.Kilowattrel, 178},
      {Species.Eevee, 179},
      {Species.Vaporeon, 180},
      {Species.Jolteon, 181},
      {Species.Flareon, 182},
      {Species.Espeon, 183},
      {Species.Umbreon, 184},
      {Species.Leafeon, 185},
      {Species.Glaceon, 186},
      {Species.Sylveon, 187},
      {Species.Dunsparce, 188},
      {(Species.Dudunsparce, 0), 189},
      {(Species.Dudunsparce, 1), 189},
      {(Species.Deerling, 0), 190},
      {(Species.Deerling, 1), 190},
      {(Species.Deerling, 2), 190},
      {(Species.Deerling, 3), 190},
      {(Species.Sawsbuck, 0), 191},
      {(Species.Sawsbuck, 1), 191},
      {(Species.Sawsbuck, 2), 191},
      {(Species.Sawsbuck, 3), 191},
      {Species.Girafarig, 192},
      {Species.Farigiraf, 193},
      {Species.Grimer, 194},
      {Species.Muk, 195},
      {Species.Maschiff, 196},
      {Species.Mabosstiff, 197},
      {Species.Toxel, 198},
      {(Species.Toxtricity, 0), 199},
      {(Species.Toxtricity, 1), 199},
      {Species.Dedenne, 200},
      {Species.Pachirisu, 201},
      {Species.Shroodle, 202},
      {Species.Grafaiai, 203},
      {Species.Stantler, 204},
      {Species.Foongus, 205},
      {Species.Amoonguss, 206},
      {Species.Voltorb, 207},
      {Species.Electrode, 208},
      {Species.Magnemite, 209},
      {Species.Magneton, 210},
      {Species.Magnezone, 211},
      {Species.Ditto, 212},
      {Species.Growlithe, 213},
      {Species.Arcanine, 214},
      {Species.Teddiursa, 215},
      {Species.Ursaring, 216},
      {Species.Zangoose, 217},
      {Species.Seviper, 218},
      {Species.Swablu, 219},
      {Species.Altaria, 220},
      {Species.Skiddo, 221},
      {Species.Gogoat, 222},
      {(Species.Tauros, 1), 223},
      {(Species.Tauros, 2), 223},
      {(Species.Tauros, 3), 223},
      {Species.Litleo, 224},
      {Species.Pyroar, 225},
      {Species.Stunky, 226},
      {Species.Skuntank, 227},
      {Species.Zorua, 228},
      {Species.Zoroark, 229},
      {Species.Sneasel, 230},
      {Species.Weavile, 231},
      {Species.Murkrow, 232},
      {Species.Honchkrow, 233},
      {Species.Gothita, 234},
      {Species.Gothorita, 235},
      {Species.Gothitelle, 236},
      {(Species.Sinistea, 0), 237},
      {(Species.Sinistea, 1), 237},
      {(Species.Polteageist, 0), 238},
      {(Species.Polteageist, 1), 238},
      {(Species.Mimikyu, 0), 239},
      {(Species.Mimikyu, 1), 239},
      {Species.Klefki, 240},
      {(Species.Indeedee, 0), 241},
      {(Species.Indeedee, 1), 241},
      {Species.Bramblin, 242},
      {Species.Brambleghast, 243},
      {Species.Toedscool, 244},
      {Species.Toedscruel, 245},
      {Species.Tropius, 246},
      {Species.Fomantis, 247},
      {Species.Lurantis, 248},
      {Species.Klawf, 249},
      {Species.Capsakid, 250},
      {Species.Scovillain, 251},
      {Species.Cacnea, 252},
      {Species.Cacturne, 253},
      {Species.Rellor, 254},
      {Species.Rabsca, 255},
      {Species.Venonat, 256},
      {Species.Venomoth, 257},
      {Species.Pineco, 258},
      {Species.Forretress, 259},
      {Species.Scyther, 260},
      {Species.Scizor, 261},
      {Species.Heracross, 262},
      {Species.Flittle, 263},
      {Species.Espathra, 264},
      {Species.Hippopotas, 265},
      {Species.Hippowdon, 266},
      {Species.Sandile, 267},
      {Species.Krokorok, 268},
      {Species.Krookodile, 269},
      {Species.Silicobra, 270},
      {Species.Sandaconda, 271},
      {Species.Mudbray, 272},
      {Species.Mudsdale, 273},
      {Species.Larvesta, 274},
      {Species.Volcarona, 275},
      {Species.Bagon, 276},
      {Species.Shelgon, 277},
      {Species.Salamence, 278},
      {Species.Tinkatink, 279},
      {Species.Tinkatuff, 280},
      {Species.Tinkaton, 281},
      {Species.Hatenna, 282},
      {Species.Hattrem, 283},
      {Species.Hatterene, 284},
      {Species.Impidimp, 285},
      {Species.Morgrem, 286},
      {Species.Grimmsnarl, 287},
      {Species.Wiglett, 288},
      {Species.Wugtrio, 289},
      {Species.Bombirdier, 290},
      {Species.Finizen, 291},
      {(Species.Palafin, 0), 292},
      {(Species.Palafin, 1), 292},
      {Species.Varoom, 293},
      {Species.Revavroom, 294},
      {Species.Cyclizar, 295},
      {Species.Orthworm, 296},
      {Species.Sableye, 297},
      {Species.Shuppet, 298},
      {Species.Banette, 299},
      {Species.Falinks, 300},
      {Species.Hawlucha, 301},
      {Species.Spiritomb, 302},
      {Species.Noibat, 303},
      {Species.Noivern, 304},
      {Species.Dreepy, 305},
      {Species.Drakloak, 306},
      {Species.Dragapult, 307},
      {Species.Glimmet, 308},
      {Species.Glimmora, 309},
      {(Species.Rotom, 0), 310},
      {(Species.Rotom, 1), 310},
      {(Species.Rotom, 2), 310},
      {(Species.Rotom, 3), 310},
      {(Species.Rotom, 4), 310},
      {(Species.Rotom, 5), 310},
      {Species.Greavard, 311},
      {Species.Houndstone, 312},
      {Species.Oranguru, 313},
      {Species.Passimian, 314},
      {Species.Komala, 315},
      {Species.Larvitar, 316},
      {Species.Pupitar, 317},
      {Species.Tyranitar, 318},
      {Species.Stonjourner, 319},
      {(Species.Eiscue, 0), 320},
      {(Species.Eiscue, 1), 320},
      {Species.Pincurchin, 321},
      {Species.Sandygast, 322},
      {Species.Palossand, 323},
      {Species.Slowpoke, 324},
      {Species.Slowbro, 325},
      {Species.Slowking, 326},
      {(Species.Shellos, 0), 327},
      {(Species.Shellos, 1), 327},
      {(Species.Gastrodon, 0), 328},
      {(Species.Gastrodon, 1), 328},
      {Species.Shellder, 329},
      {Species.Cloyster, 330},
      {Species.Qwilfish, 331},
      {Species.Luvdisc, 332},
      {Species.Finneon, 333},
      {Species.Lumineon, 334},
      {Species.Bruxish, 335},
      {Species.Alomomola, 336},
      {Species.Skrelp, 337},
      {Species.Dragalge, 338},
      {Species.Clauncher, 339},
      {Species.Clawitzer, 340},
      {Species.Tynamo, 341},
      {Species.Eelektrik, 342},
      {Species.Eelektross, 343},
      {Species.Mareanie, 344},
      {Species.Toxapex, 345},
      {Species.Flamigo, 346},
      {Species.Dratini, 347},
      {Species.Dragonair, 348},
      {Species.Dragonite, 349},
      {Species.Snom, 350},
      {Species.Frosmoth, 351},
      {Species.Snover, 352},
      {Species.Abomasnow, 353},
      {Species.Delibird, 354},
      {Species.Cubchoo, 355},
      {Species.Beartic, 356},
      {Species.Snorunt, 357},
      {Species.Glalie, 358},
      {Species.Froslass, 359},
      {Species.Cryogonal, 360},
      {Species.Cetoddle, 361},
      {Species.Cetitan, 362},
      {Species.Bergmite, 363},
      {Species.Avalugg, 364},
      {Species.Rufflet, 365},
      {Species.Braviary, 366},
      {Species.Pawniard, 367},
      {Species.Bisharp, 368},
      {Species.Kingambit, 369},
      {Species.Deino, 370},
      {Species.Zweilous, 371},
      {Species.Hydreigon, 372},
      {Species.Veluza, 373},
      {Species.Dondozo, 374},
      {(Species.Tatsugiri, 0), 375},
      {(Species.Tatsugiri, 1), 375},
      {(Species.Tatsugiri, 2), 375},
      {Species.GreatTusk, 376},
      {Species.ScreamTail, 377},
      {Species.BruteBonnet, 378},
      {Species.FlutterMane, 379},
      {Species.SlitherWing, 380},
      {Species.SandyShocks, 381},
      {Species.IronTreads, 382},
      {Species.IronBundle, 383},
      {Species.IronHands, 384},
      {Species.IronJugulis, 385},
      {Species.IronMoth, 386},
      {Species.IronThorns, 387},
      {Species.Frigibax, 388},
      {Species.Arctibax, 389},
      {Species.Baxcalibur, 390},
      {Species.Gimmighoul, 391},
      {Species.Gholdengo, 392},
      {Species.WoChien, 393},
      {Species.ChienPao, 394},
      {Species.TingLu, 395},
      {Species.ChiYu, 396},
      {Species.RoaringMoon, 397},
      {Species.IronValiant, 398},
      {Species.Koraidon, 399},
      {Species.Miraidon, 400}
    };

    private static readonly Dictionary<SpeciesForm, int> KitakamiDex = new Dictionary<SpeciesForm, int>() {
      {Species.Spinarak, 1},
      {Species.Ariados, 2},
      {Species.Yanma, 3},
      {Species.Yanmega, 4},
      {(Species.Wooper, 0), 5},
      {Species.Quagsire, 6},
      {Species.Poochyena, 7},
      {Species.Mightyena, 8},
      {Species.Volbeat, 9},
      {Species.Illumise, 10},
      {Species.Corphish, 11},
      {Species.Crawdaunt, 12},
      {Species.Sewaddle, 13},
      {Species.Swadloon, 14},
      {Species.Leavanny, 15},
      {Species.Cutiefly, 16},
      {Species.Ribombee, 17},
      {Species.Ekans, 18},
      {Species.Arbok, 19},
      {Species.Pichu, 20},
      {Species.Pikachu, 21},
      {Species.Raichu, 22},
      {Species.Bellsprout, 23},
      {Species.Weepinbell, 24},
      {Species.Victreebel, 25},
      {Species.Sentret, 26},
      {Species.Furret, 27},
      {Species.Starly, 28},
      {Species.Staravia, 29},
      {Species.Staraptor, 30},
      {Species.Fomantis, 31},
      {Species.Lurantis, 32},
      {Species.Applin, 33},
      {Species.Flapple, 34},
      {Species.Appletun, 35},
      {(Species) 1011 /*Species.Dipplin*/, 36},
      {Species.Vulpix, 37},
      {Species.Ninetales, 38},
      {Species.Poliwag, 39},
      {Species.Poliwhirl, 40},
      {Species.Poliwrath, 41},
      {Species.Politoed, 42},
      {Species.Magikarp, 43},
      {Species.Gyarados, 44},
      {Species.Hoothoot, 45},
      {Species.Noctowl, 46},
      {Species.Aipom, 47},
      {Species.Ambipom, 48},
      {Species.Heracross, 49},
      {Species.Swinub, 50},
      {Species.Piloswine, 51},
      {Species.Mamoswine, 52},
      {Species.Stantler, 53},
      {Species.Seedot, 54},
      {Species.Nuzleaf, 55},
      {Species.Shiftry, 56},
      {Species.Ralts, 57},
      {Species.Kirlia, 58},
      {Species.Gardevoir, 59},
      {Species.Gallade, 60},
      {Species.Kricketot, 61},
      {Species.Kricketune, 62},
      {Species.Pachirisu, 63},
      {Species.Riolu, 64},
      {Species.Lucario, 65},
      {Species.Petilil, 66},
      {Species.Lilligant, 67},
      {Species.Phantump, 68},
      {Species.Trevenant, 69},
      {(Species.Rockruff, 0), 70},
      {(Species.Rockruff, 1), 70},
      {(Species.Lycanroc, 0), 71},
      {(Species.Lycanroc, 1), 71},
      {(Species.Lycanroc, 2), 71},
      {Species.Skwovet, 72},
      {Species.Greedent, 73},
      {Species.Toedscool, 74},
      {Species.Toedscruel, 75},
      {((Species) 1012 /*Species.Poltchageist*/, 0), 76},
      {((Species) 1012 /*Species.Poltchageist*/, 1), 76},
      {((Species) 1013 /*Species.Sinistcha*/, 0), 77},
      {((Species) 1013 /*Species.Sinistcha*/, 1), 77},
      {Species.Growlithe, 78},
      {Species.Arcanine, 79},
      {Species.Geodude, 80},
      {Species.Graveler, 81},
      {Species.Golem, 82},
      {Species.Bonsly, 83},
      {Species.Sudowoodo, 84},
      {Species.Timburr, 85},
      {Species.Gurdurr, 86},
      {Species.Conkeldurr, 87},
      {Species.Noibat, 88},
      {Species.Noivern, 89},
      {Species.Arrokuda, 90},
      {Species.Barraskewda, 91},
      {Species.Hatenna, 92},
      {Species.Hattrem, 93},
      {Species.Hatterene, 94},
      {Species.Morpeko, 95},
      {Species.Orthworm, 96},
      {Species.Tandemaus, 97},
      {(Species.Maushold, 0), 98},
      {(Species.Maushold, 1), 98},
      {Species.Mankey, 99},
      {Species.Primeape, 100},
      {Species.Annihilape, 101},
      {Species.Munchlax, 102},
      {Species.Snorlax, 103},
      {Species.Lotad, 104},
      {Species.Lombre, 105},
      {Species.Ludicolo, 106},
      {Species.Nosepass, 107},
      {Species.Probopass, 108},
      {Species.Shinx, 109},
      {Species.Luxio, 110},
      {Species.Luxray, 111},
      {Species.Grubbin, 112},
      {Species.Charjabug, 113},
      {Species.Vikavolt, 114},
      {(Species.Oricorio, 0), 115},
      {(Species.Oricorio, 1), 115},
      {(Species.Oricorio, 2), 115},
      {(Species.Oricorio, 3), 115},
      {Species.Sandshrew, 116},
      {Species.Sandslash, 117},
      {Species.Gastly, 118},
      {Species.Haunter, 119},
      {Species.Gengar, 120},
      {Species.Gligar, 121},
      {Species.Gliscor, 122},
      {Species.Houndour, 123},
      {Species.Houndoom, 124},
      {Species.Spoink, 125},
      {Species.Grumpig, 126},
      {Species.Vullaby, 127},
      {Species.Mandibuzz, 128},
      {Species.Mudbray, 129},
      {Species.Mudsdale, 130},
      {Species.Jangmoo, 131},
      {Species.Hakamoo, 132},
      {Species.Kommoo, 133},
      {Species.Bombirdier, 134},
      {Species.Koffing, 135},
      {Species.Weezing, 136},
      {Species.Mienfoo, 137},
      {Species.Mienshao, 138},
      {Species.Duskull, 139},
      {Species.Dusclops, 140},
      {Species.Dusknoir, 141},
      {Species.Chingling, 142},
      {Species.Chimecho, 143},
      {Species.Slugma, 144},
      {Species.Magcargo, 145},
      {Species.Litwick, 146},
      {Species.Lampent, 147},
      {Species.Chandelure, 148},
      {Species.Surskit, 149},
      {Species.Masquerain, 150},
      {Species.Cleffa, 151},
      {Species.Clefairy, 152},
      {Species.Clefable, 153},
      {Species.Bronzor, 154},
      {Species.Bronzong, 155},
      {Species.Glimmet, 156},
      {Species.Glimmora, 157},
      {Species.Feebas, 158},
      {Species.Milotic, 159},
      {Species.Dunsparce, 160},
      {(Species.Dudunsparce, 0), 161},
      {(Species.Dudunsparce, 1), 161},
      {Species.Barboach, 162},
      {Species.Whiscash, 163},
      {Species.Gible, 164},
      {Species.Gabite, 165},
      {Species.Garchomp, 166},
      {Species.Carbink, 167},
      {Species.Salandit, 168},
      {Species.Salazzle, 169},
      {Species.Sneasel, 170},
      {Species.Weavile, 171},
      {Species.Snorunt, 172},
      {Species.Glalie, 173},
      {Species.Froslass, 174},
      {Species.Tynamo, 175},
      {Species.Eelektrik, 176},
      {Species.Eelektross, 177},
      {Species.Goomy, 178},
      {Species.Sliggoo, 179},
      {Species.Goodra, 180},
      {Species.Ducklett, 181},
      {Species.Swanna, 182},
      {Species.Chewtle, 183},
      {Species.Drednaw, 184},
      {(Species.Cramorant, 0), 185},
      {(Species.Cramorant, 1), 185},
      {(Species.Cramorant, 2), 185},
      {Species.Pawniard, 186},
      {Species.Bisharp, 187},
      {Species.Kingambit, 188},
      {(Species.Mimikyu, 0), 189},
      {(Species.Mimikyu, 1), 189},
      {Species.Impidimp, 190},
      {Species.Morgrem, 191},
      {Species.Grimmsnarl, 192},
      {(Species.Indeedee, 0), 193},
      {(Species.Indeedee, 1), 193},
      {(Species.Basculin, 2), 194},
      {(Species.Basculegion, 0), 195},
      {(Species.Basculegion, 1), 195},
      {(Species.Ursaluna, 1), 196},
      {(Species) 1014 /*Species.Okidogi*/, 197},
      {(Species) 1015 /*Species.Munkidori*/, 198},
      {(Species) 1016 /*Species.Fezandipiti*/, 199},
      {((Species) 1017 /*Species.Ogerpon*/, 0), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 1), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 2), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 3), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 4), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 5), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 6), 200},
      {((Species) 1017 /*Species.Ogerpon*/, 7), 200},
    };

    public static Func<PKM, IComparable>[] GetPaldeaSortFunctions() {
      return GenerateSortingFunctions(PaldeaDex);
    }

    public static Func<PKM, IComparable>[] GetKitakamiSortFunctions() {
      return GenerateSortingFunctions(KitakamiDex);
    }

    public static Func<PKM, IComparable>[] GetSortFunctions() {
      return GenerateSortingFunctions(PaldeaDex, KitakamiDex);
    }

  }
}
