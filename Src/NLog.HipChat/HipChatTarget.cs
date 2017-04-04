using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Targets;
using System.ComponentModel.DataAnnotations;
using HipChat;
using System.ComponentModel;

namespace NLog.Targets.HipChat
{
    [Target("HipChat")]
    public sealed class HipChatTarget : TargetWithLayout
    {
        public HipChatTarget()
        {
        }

        [Required]
        public string AuthToken { get; set; }

        [Required]
        public string RoomId { get; set; }

        [DefaultValue("Nlog.HipChatTarget")]
        public string SenderName { get; set; }

        [DefaultValue(HipChatClient.BackgroundColor.yellow)]
        public HipChatClient.BackgroundColor BackgroundColor { get; set; }

        [DefaultValue("html")]
        public string MessageFormat { get; set; }


        protected override void Write(LogEventInfo logEvent)
        {
            string log = this.Layout.Render(logEvent);

            this.SendMessageToHipchat(log);
        }

        private HipChatClient.MessageFormat ParseFormat()
        {
            var isText = string.Equals(MessageFormat, "text", StringComparison.OrdinalIgnoreCase);
            return isText
                ? HipChatClient.MessageFormat.text
                : HipChatClient.MessageFormat.html;
        }

        private void SendMessageToHipchat(string message)
        {
            var format = ParseFormat();

            var client = new HipChatClient(this.AuthToken, this.RoomId, format);
            client.From = SenderName;

            client.SendMessage(message, this.BackgroundColor);
        }
    }
}
