namespace Almanapp.Models {
    public class AlmanaxDay() {
        public string? date { get; set; }
        public string? bonus { get; set; }
        public string? quest { get; set; }

        public AlmanaxDay(string? date, string? bonus, string? quest) : this() {
            this.date = date;
            this.bonus = bonus;
            this.quest = quest;
        }
    }
}
