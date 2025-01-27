using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compendium.Features;

namespace UpdateSuppressor {
    public class UpdateSuppressorFeature : ConfigFeatureBase {
        public override string Name => "UpdateSuppressor";
        public override bool IsPatch => true;
    }
}
