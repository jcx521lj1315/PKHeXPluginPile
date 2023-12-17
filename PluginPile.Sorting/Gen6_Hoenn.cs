using PKHeX.Core;

namespace PluginPile.Sorting;
internal class Gen6_Hoenn : SortingBase {

  private static readonly Dictionary<Species, PositionForms> Dex = new Dictionary<Species, PositionForms>() {
    {Species.Treecko, 1},
    {Species.Grovyle, 2},
    {Species.Sceptile, 3},
    {Species.Torchic, 4},
    {Species.Combusken, 5},
    {Species.Blaziken, 6},
    {Species.Mudkip, 7},
    {Species.Marshtomp, 8},
    {Species.Swampert, 9},
    {Species.Poochyena, 10},
    {Species.Mightyena, 11},
    {Species.Zigzagoon, 12},
    {Species.Linoone, 13},
    {Species.Wurmple, 14},
    {Species.Silcoon, 15},
    {Species.Beautifly, 16},
    {Species.Cascoon, 17},
    {Species.Dustox, 18},
    {Species.Lotad, 19},
    {Species.Lombre, 20},
    {Species.Ludicolo, 21},
    {Species.Seedot, 22},
    {Species.Nuzleaf, 23},
    {Species.Shiftry, 24},
    {Species.Taillow, 25},
    {Species.Swellow, 26},
    {Species.Wingull, 27},
    {Species.Pelipper, 28},
    {Species.Ralts, 29},
    {Species.Kirlia, 30},
    {Species.Gardevoir, 31},
    {Species.Gallade, 32},
    {Species.Surskit, 33},
    {Species.Masquerain, 34},
    {Species.Shroomish, 35},
    {Species.Breloom, 36},
    {Species.Slakoth, 37},
    {Species.Vigoroth, 38},
    {Species.Slaking, 39},
    {Species.Abra, 40},
    {Species.Kadabra, 41},
    {Species.Alakazam, 42},
    {Species.Nincada, 43},
    {Species.Ninjask, 44},
    {Species.Shedinja, 45},
    {Species.Whismur, 46},
    {Species.Loudred, 47},
    {Species.Exploud, 48},
    {Species.Makuhita, 49},
    {Species.Hariyama, 50},
    {Species.Goldeen, 51},
    {Species.Seaking, 52},
    {Species.Magikarp, 53},
    {Species.Gyarados, 54},
    {Species.Azurill, 55},
    {Species.Marill, 56},
    {Species.Azumarill, 57},
    {Species.Geodude, 58},
    {Species.Graveler, 59},
    {Species.Golem, 60},
    {Species.Nosepass, 61},
    {Species.Probopass, 62},
    {Species.Skitty, 63},
    {Species.Delcatty, 64},
    {Species.Zubat, 65},
    {Species.Golbat, 66},
    {Species.Crobat, 67},
    {Species.Tentacool, 68},
    {Species.Tentacruel, 69},
    {Species.Sableye, 70},
    {Species.Mawile, 71},
    {Species.Aron, 72},
    {Species.Lairon, 73},
    {Species.Aggron, 74},
    {Species.Machop, 75},
    {Species.Machoke, 76},
    {Species.Machamp, 77},
    {Species.Meditite, 78},
    {Species.Medicham, 79},
    {Species.Electrike, 80},
    {Species.Manectric, 81},
    {Species.Plusle, 82},
    {Species.Minun, 83},
    {Species.Magnemite, 84},
    {Species.Magneton, 85},
    {Species.Magnezone, 86},
    {Species.Voltorb, 87},
    {Species.Electrode, 88},
    {Species.Volbeat, 89},
    {Species.Illumise, 90},
    {Species.Oddish, 91},
    {Species.Gloom, 92},
    {Species.Vileplume, 93},
    {Species.Bellossom, 94},
    {Species.Doduo, 95},
    {Species.Dodrio, 96},
    {Species.Budew, 97},
    {Species.Roselia, 98},
    {Species.Roserade, 99},
    {Species.Gulpin, 100},
    {Species.Swalot, 101},
    {Species.Carvanha, 102},
    {Species.Sharpedo, 103},
    {Species.Wailmer, 104},
    {Species.Wailord, 105},
    {Species.Numel, 106},
    {Species.Camerupt, 107},
    {Species.Slugma, 108},
    {Species.Magcargo, 109},
    {Species.Torkoal, 110},
    {Species.Grimer, 111},
    {Species.Muk, 112},
    {Species.Koffing, 113},
    {Species.Weezing, 114},
    {Species.Spoink, 115},
    {Species.Grumpig, 116},
    {Species.Sandshrew, 117},
    {Species.Sandslash, 118},
    {Species.Spinda, 119},
    {Species.Skarmory, 120},
    {Species.Trapinch, 121},
    {Species.Vibrava, 122},
    {Species.Flygon, 123},
    {Species.Cacnea, 124},
    {Species.Cacturne, 125},
    {Species.Swablu, 126},
    {Species.Altaria, 127},
    {Species.Zangoose, 128},
    {Species.Seviper, 129},
    {Species.Lunatone, 130},
    {Species.Solrock, 131},
    {Species.Barboach, 132},
    {Species.Whiscash, 133},
    {Species.Corphish, 134},
    {Species.Crawdaunt, 135},
    {Species.Baltoy, 136},
    {Species.Claydol, 137},
    {Species.Lileep, 138},
    {Species.Cradily, 139},
    {Species.Anorith, 140},
    {Species.Armaldo, 141},
    {Species.Igglybuff, 142},
    {Species.Jigglypuff, 143},
    {Species.Wigglytuff, 144},
    {Species.Feebas, 145},
    {Species.Milotic, 146},
    {Species.Castform, (147, 0..4)},
    {Species.Staryu, 148},
    {Species.Starmie, 149},
    {Species.Kecleon, 150},
    {Species.Shuppet, 151},
    {Species.Banette, 152},
    {Species.Duskull, 153},
    {Species.Dusclops, 154},
    {Species.Dusknoir, 155},
    {Species.Tropius, 156},
    {Species.Chingling, 157},
    {Species.Chimecho, 158},
    {Species.Absol, 159},
    {Species.Vulpix, 160},
    {Species.Ninetales, 161},
    {Species.Pichu, 162},
    {Species.Pikachu, 163},
    {Species.Raichu, 164},
    {Species.Psyduck, 165},
    {Species.Golduck, 166},
    {Species.Wynaut, 167},
    {Species.Wobbuffet, 168},
    {Species.Natu, 169},
    {Species.Xatu, 170},
    {Species.Girafarig, 171},
    {Species.Phanpy, 172},
    {Species.Donphan, 173},
    {Species.Pinsir, 174},
    {Species.Heracross, 175},
    {Species.Rhyhorn, 176},
    {Species.Rhydon, 177},
    {Species.Rhyperior, 178},
    {Species.Snorunt, 179},
    {Species.Glalie, 180},
    {Species.Froslass, 181},
    {Species.Spheal, 182},
    {Species.Sealeo, 183},
    {Species.Walrein, 184},
    {Species.Clamperl, 185},
    {Species.Huntail, 186},
    {Species.Gorebyss, 187},
    {Species.Relicanth, 188},
    {Species.Corsola, 189},
    {Species.Chinchou, 190},
    {Species.Lanturn, 191},
    {Species.Luvdisc, 192},
    {Species.Horsea, 193},
    {Species.Seadra, 194},
    {Species.Kingdra, 195},
    {Species.Bagon, 196},
    {Species.Shelgon, 197},
    {Species.Salamence, 198},
    {Species.Beldum, 199},
    {Species.Metang, 200},
    {Species.Metagross, 201},
    {Species.Regirock, 202},
    {Species.Regice, 203},
    {Species.Registeel, 204},
    {Species.Latias, 205},
    {Species.Latios, 206},
    {Species.Kyogre, (207, 0..1)},
    {Species.Groudon, (208, 0..1)},
    {Species.Rayquaza, (209, 0..1)},
    {Species.Jirachi, 210},
    {Species.Deoxys, (211, 0..3)},
  };

  public static Func<PKM, IComparable>[] GetSortFunctions() {
    return GenerateSortingFunctions(Dex);
  }

}
