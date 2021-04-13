using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigNGS
{
    namespace jsonObject
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class DefaultStutter
        {
            public double PhrThreshold { get; set; }
            public int NPlus { get; set; }
            public int NMinus { get; set; }
        }

        public class DefaultSequencingError
        {
            public double IntensityThreshold { get; set; }
        }

        public class PlusSequence
        {
            public string Seq { get; set; }
        }

        public class MinusSequence
        {
            public string Seq { get; set; }
        }

        public class Flank5p
        {
            public string Seq { get; set; }
        }

        public class Flank3p
        {
            public string Seq { get; set; }
        }

        public class RepeatMotif
        {
            public string Seq { get; set; }
        }

        public class Stutter
        {
            public double PhrThreshold { get; set; }
            public int NPlus { get; set; }
            public int NMinus { get; set; }
        }

        public class Loci
        {
            public string Marker { get; set; }
            public PlusSequence PlusSequence { get; set; }
            public MinusSequence MinusSequence { get; set; }
            public Flank5p Flank5p { get; set; }
            public Flank3p Flank3p { get; set; }
            public List<RepeatMotif> RepeatMotifs { get; set; }
            public List<Stutter> Stutter { get; set; }
            public string AlleleOffset { get; set; }
            public int? SizeStandard { get; set; }
        }

        public class Kit
        {
            public string Name { get; set; }
            public List<DefaultStutter> DefaultStutter { get; set; }
            public List<DefaultSequencingError> DefaultSequencingError { get; set; }
            public List<Loci> loci { get; set; }
        }

        public class Root
        {
            public int AbundanceThresholdInput { get; set; }
            public int AbundanceThresholdOutput { get; set; }
            public bool OutputRawSequences { get; set; }
            public string DefaultKit { get; set; }
            public int OutputAbundantAlleleSequences { get; set; }
            public List<Kit> kits { get; set; }
        }


    }
}
