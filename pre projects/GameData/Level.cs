using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    [Serializable]
    public class Level
    {
        public List<List<Sceens>> SubLevels { get; set; }
        public int DefaultBackImage { get; set; }
        public int IntroCutSceen { get; set; }
        public int OutroCutSceen { get; set; }
        public string CompletionReward { get; set; }

        //Upgrades
        const string RewardHardwareUpgrade = "Reward.Upgrade.Hardware";
        const string RewardErrorUpgrade = "Reward.Upgrade.Error";
        const string RewardDebugUpgrade = "Reward.Upgrade.Debug";
        //Special
        const string RewardSpecial = "Reward.Special";
        //Tokens
        const string RewardTokenHint = "Reward.Token.Hint";
        const string RewardTokenCodeHint = "Reward.Token.Code.Hint";
        const string RewardTokenCodePass = "Reward.Token.Code.Pass";


    }
}
