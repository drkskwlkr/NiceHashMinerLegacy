﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Miners.IntegratedPlugins
{
    public class WildRigIntegratedPlugin : WildRig.WildRigPlugin, IntegratedPlugin, IMinerBinsSource
    {
        public WildRigIntegratedPlugin() : base("WildRig")
        { }

        public bool Is3rdParty => true;

        IEnumerable<string> IMinerBinsSource.GetMinerBinsUrls()
        {
            return MinersBinsUrls.GetMinerBinsUrlsForPlugin(PluginUUID);
        }
    }
}
