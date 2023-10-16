using PKHeX.Core;

namespace PluginPile.Sorting; 
class Gen3_Kanto : SortingBase {

  public static Func<PKM, IComparable>[] GetSortFunctions() {
    return Gen1_Kanto.GetSortFunctions();
  }

}
