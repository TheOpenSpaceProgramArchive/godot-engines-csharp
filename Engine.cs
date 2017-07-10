namespace OSP {
    public class Engine : PartModule, ThrustProducer {
        public const float G0 = 9.80665;

        public Engine() {
            Throttle = 1;
            ThrustLimiter = 1;
        }

        public Vector3 ThrustVector {
            get {
                return ThrustDirection * CurrentThrust;
            }
        }

        public float MaxThrustVac { get; set; }
        public float MaxThrustASL { get; set; }
        public float IspVac { get; set; }
        public float IspASL { get; set; }
        public float Throttle { get; set; }
        public float ThrustLimiter { get; set; }
        private Vector3 thrustDirection;

        public Vector3 ThrustDirection {
            get {
                return thrustDirection;
            } set {
                thrustDirection = value.Normalized();
            }
        }

        protected float GetAtmoPressure() {
            return 0;
        }

        public float CurrentThrust {
            get {
                return ((MaxThrustASL - MaxThrustVac) * GetAtmoPressure() + MaxThrustVac) * Throttle * ThrustLimiter;
            }
        }

        public float CurrentIsp {
            get {
                return (IspASL - IspVac) * GetAtmoPressure() + IspVac;
            }
        }
    }
}
