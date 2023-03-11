namespace Develop04 {
    class ListingActivity : Activity {
        public ListingActivity (string activityName, string activityDescription) : base(activityName, activityDescription) {

        }

        public override int GetPoints()
        {
            return 30;
        }

    }

}