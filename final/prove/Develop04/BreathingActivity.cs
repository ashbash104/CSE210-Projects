namespace Develop04 {
    class BreathingActivity : Activity {
        public BreathingActivity (string activityName, string activityDescription) : base(activityName, activityDescription) {

        }

        public override int GetPoints()
        {
            return 10;
        }
        public override string GetActivityType(){
            return "Breathing Activity";
        }
    }
    
}

