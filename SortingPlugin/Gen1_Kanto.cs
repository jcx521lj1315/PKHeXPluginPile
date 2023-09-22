using PKHeX.Core;

namespace PluginPile.SortingPlugin {
  class Gen1_Kanto : SortingBase {

    protected static readonly Dictionary<SpeciesForm, int> dex = new Dictionary<SpeciesForm, int>() {
      {Species.Bulbasaur, 1},
      {Species.Ivysaur, 2},
      {Species.Venusaur, 3},
      {Species.Charmander, 4},
      {Species.Charmeleon, 5},
      {Species.Charizard, 6},
      {Species.Squirtle, 7},
      {Species.Wartortle, 8},
      {Species.Blastoise, 9},
      {Species.Caterpie, 10},
      {Species.Metapod, 11},
      {Species.Butterfree, 12},
      {Species.Weedle, 13},
      {Species.Kakuna, 14},
      {Species.Beedrill, 15},
      {Species.Pidgey, 16},
      {Species.Pidgeotto, 17},
      {Species.Pidgeot, 18},
      {Species.Rattata, 19},
      {Species.Raticate, 20},
      {Species.Spearow, 21},
      {Species.Fearow, 22},
      {Species.Ekans, 23},
      {Species.Arbok, 24},
      {Species.Pikachu, 25},
      {Species.Raichu, 26},
      {Species.Sandshrew, 27},
      {Species.Sandslash, 28},
      {Species.NidoranF, 29},
      {Species.Nidorina, 30},
      {Species.Nidoqueen, 31},
      {Species.NidoranM, 32},
      {Species.Nidorino, 33},
      {Species.Nidoking, 34},
      {Species.Clefairy, 35},
      {Species.Clefable, 36},
      {Species.Vulpix, 37},
      {Species.Ninetales, 38},
      {Species.Jigglypuff, 39},
      {Species.Wigglytuff, 40},
      {Species.Zubat, 41},
      {Species.Golbat, 42},
      {Species.Oddish, 43},
      {Species.Gloom, 44},
      {Species.Vileplume, 45},
      {Species.Paras, 46},
      {Species.Parasect, 47},
      {Species.Venonat, 48},
      {Species.Venomoth, 49},
      {Species.Diglett, 50},
      {Species.Dugtrio, 51},
      {Species.Meowth, 52},
      {Species.Persian, 53},
      {Species.Psyduck, 54},
      {Species.Golduck, 55},
      {Species.Mankey, 56},
      {Species.Primeape, 57},
      {Species.Growlithe, 58},
      {Species.Arcanine, 59},
      {Species.Poliwag, 60},
      {Species.Poliwhirl, 61},
      {Species.Poliwrath, 62},
      {Species.Abra, 63},
      {Species.Kadabra, 64},
      {Species.Alakazam, 65},
      {Species.Machop, 66},
      {Species.Machoke, 67},
      {Species.Machamp, 68},
      {Species.Bellsprout, 69},
      {Species.Weepinbell, 70},
      {Species.Victreebel, 71},
      {Species.Tentacool, 72},
      {Species.Tentacruel, 73},
      {Species.Geodude, 74},
      {Species.Graveler, 75},
      {Species.Golem, 76},
      {Species.Ponyta, 77},
      {Species.Rapidash, 78},
      {Species.Slowpoke, 79},
      {Species.Slowbro, 80},
      {Species.Magnemite, 81},
      {Species.Magneton, 82},
      {Species.Farfetchd, 83},
      {Species.Doduo, 84},
      {Species.Dodrio, 85},
      {Species.Seel, 86},
      {Species.Dewgong, 87},
      {Species.Grimer, 88},
      {Species.Muk, 89},
      {Species.Shellder, 90},
      {Species.Cloyster, 91},
      {Species.Gastly, 92},
      {Species.Haunter, 93},
      {Species.Gengar, 94},
      {Species.Onix, 95},
      {Species.Drowzee, 96},
      {Species.Hypno, 97},
      {Species.Krabby, 98},
      {Species.Kingler, 99},
      {Species.Voltorb, 100},
      {Species.Electrode, 101},
      {Species.Exeggcute, 102},
      {Species.Exeggutor, 103},
      {Species.Cubone, 104},
      {Species.Marowak, 105},
      {Species.Hitmonlee, 106},
      {Species.Hitmonchan, 107},
      {Species.Lickitung, 108},
      {Species.Koffing, 109},
      {Species.Weezing, 110},
      {Species.Rhyhorn, 111},
      {Species.Rhydon, 112},
      {Species.Chansey, 113},
      {Species.Tangela, 114},
      {Species.Kangaskhan, 115},
      {Species.Horsea, 116},
      {Species.Seadra, 117},
      {Species.Goldeen, 118},
      {Species.Seaking, 119},
      {Species.Staryu, 120},
      {Species.Starmie, 121},
      {Species.MrMime, 122},
      {Species.Scyther, 123},
      {Species.Jynx, 124},
      {Species.Electabuzz, 125},
      {Species.Magmar, 126},
      {Species.Pinsir, 127},
      {Species.Tauros, 128},
      {Species.Magikarp, 129},
      {Species.Gyarados, 130},
      {Species.Lapras, 131},
      {Species.Ditto, 132},
      {Species.Eevee, 133},
      {Species.Vaporeon, 134},
      {Species.Jolteon, 135},
      {Species.Flareon, 136},
      {Species.Porygon, 137},
      {Species.Omanyte, 138},
      {Species.Omastar, 139},
      {Species.Kabuto, 140},
      {Species.Kabutops, 141},
      {Species.Aerodactyl, 142},
      {Species.Snorlax, 143},
      {Species.Articuno, 144},
      {Species.Zapdos, 145},
      {Species.Moltres, 146},
      {Species.Dratini, 147},
      {Species.Dragonair, 148},
      {Species.Dragonite, 149},
      {Species.Mewtwo, 150},
      {Species.Mew, 151},
    };

    public static Func<PKM, IComparable>[] GetSortFunctions() {
      return GenerateSortingFunctions(dex);
    }

  }
}
