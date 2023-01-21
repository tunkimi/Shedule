
namespace ParserTgBot.Core.Shedule
{
    class SheduleSettings : IParcerSettings
    {
        public SheduleSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrls { get; set; } = "https://mai.ru/education/studies/schedule";
        public string Prefix { get; set; } = "groups.php?department=Институт+№currentNum&course=all";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }

    }
}
