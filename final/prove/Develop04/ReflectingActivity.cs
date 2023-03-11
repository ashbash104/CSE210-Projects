namespace Develop04 {
    class ReflectingActivity : Activity {
        public ReflectingActivity (string activityName, string activityDescription) : base (activityName, activityDescription) {

        }

        public override int GetPoints()
        {
            return 20;
        }

    }

}