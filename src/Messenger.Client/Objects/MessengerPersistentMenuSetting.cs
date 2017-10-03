using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    [Obsolete]
    public class MessengerPersistentMenuSetting : MessengerThreadSetting
    {
        public MessengerPersistentMenuSetting()
        {
            ThreadState = "existing_thread";
        }

        public override string SettingType => "call_to_actions";

	     [JsonProperty("locale")]
	     public string Locale{ get; set; }
        
        [JsonProperty("composer_input_disabled")]
        public bool ComposerInputDisabled{ get; set; }

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerCallToAction> CallToActions { get; set; }

    }
}
