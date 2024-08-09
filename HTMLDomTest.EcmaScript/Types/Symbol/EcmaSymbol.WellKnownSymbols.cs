namespace HTMLDomTest.EcmaScript.Types;

public partial class EcmaSymbol
{
    public static class WellKnownSymbols
    {
        public static readonly EcmaSymbol AsyncIterator = new("asyncIterator");
        
        public static readonly EcmaSymbol HasInstance = new("hasInstance");
        
        public static readonly EcmaSymbol IsConcatSpreadable = new("isConcatSpreadable");
        
        public static readonly EcmaSymbol Iterator = new("iterator");
        
        public static readonly EcmaSymbol Match = new("match");
        
        public static readonly EcmaSymbol MatchAll = new("matchAll");
        
        public static readonly EcmaSymbol Replace = new("replace");
        
        public static readonly EcmaSymbol Search = new("search");
        
        public static readonly EcmaSymbol Species = new("species");
        
        public static readonly EcmaSymbol Split = new("split");
        
        public static readonly EcmaSymbol ToPrimitive = new("toPrimitive");
        
        public static readonly EcmaSymbol ToStringTag = new("toStringTag");
        
        public static readonly EcmaSymbol Unscopables = new("unscopables");
    }
}
